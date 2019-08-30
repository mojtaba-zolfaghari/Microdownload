using AutoMapper;
using DNTBreadCrumb.Core;
using DNTPersianUtils.Core;
using Microdownload.Common.IdentityToolkit;
using Microdownload.Common.ZarinPal;
using Microdownload.DataLayer.Context;
using Microdownload.Entities;
using Microdownload.Services;
using Microdownload.Services.Identity;
using Microdownload.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Microdownload.Areas.Panel.Controllers
{
    [Authorize(Policy = ConstantPolicies.DynamicPermission)]
    [Area(AreaConstants.PanelArea)]
    [BreadCrumb(UseDefaultRouteUrl = true, Order = 0, GlyphIcon = "fa fa-hashtag")]
    [DisplayName("کیف پول")]
    public class WalletController : Controller
    {

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWalletService _walletService;
        private readonly IPaymentService _paymentService;
        private readonly IPortalSettingService _settingService;

        private readonly IToastNotification _toastNotification;


        public WalletController(IToastNotification toastNotification, IUnitOfWork unitOfWork, IWalletService walletService, IMapper mapper, IPaymentService paymentService, IPortalSettingService settingService)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _walletService = walletService;
            _paymentService = paymentService;
            _settingService = settingService;
            _toastNotification = toastNotification;
        }


        [DisplayName("ایندکس")]
        [BreadCrumb(Order = 1)]
        public async Task<IActionResult> Index(int pageNumber = 1, int pageSize = -1, int count = 10, int? Code = -8)
        {
            var userId = this.User.Identity.GetUserId<int>();

            var itemsPerPage = count;
            if (pageSize > 0)
            {
                itemsPerPage = pageSize;
            }
            var model = await _walletService.GetAllTWallet(userId,
                pageNumber, itemsPerPage).ConfigureAwait(false);

            model.Paging.CurrentPage = pageNumber;
            model.Paging.ItemsPerPage = itemsPerPage;
            var walletInventory = await _walletService.GetWalletInventory(userId);
            ViewBag.WalletInventory = walletInventory.ToPersianNumbers("N0");
            ViewBag.WalletInventoryLettersFa = walletInventory.NumberToText(Language.Persian);
            ViewBag.WalletInventoryLettersEn = walletInventory.NumberToText(Language.English);

            ViewBag.TotalRows = model.Paging.TotalItems;

            return View(model);
        }

        [HttpGet]
        [DisplayName("شارژ کیف پول")]
        [BreadCrumb(Order = 1)]
        public IActionResult WalletCharge()
        {
            return View();
        }

        [DisplayName("شارژ کیف پول ( پرداخت آنلاین )")]
        [BreadCrumb(Order = 1)]
        [HttpPost, ValidateAntiForgeryToken]

        public async Task<IActionResult> WalletCharge(WalletChargeViewModel model)
        {

            if (User.Identity.IsAuthenticated)
            {

                var amount = int.Parse(model.Amount.Replace(",", ""));
                var set = await _settingService.GetSettingsForEdit();
                var userId = this.User.Identity.GetUserId<int>();
                var paymentId = await _paymentService.InsertPayment(amount, "زرین پال", userId, PaymentType.WalletCharge);

                ZarinPal.PaymentGatewayImplementationServicePortTypeClient zp = new ZarinPal.PaymentGatewayImplementationServicePortTypeClient();


                var x = await zp.PaymentRequestAsync(set.ZarinPalCode, amount, "شارژ کیف پول", "", "", set.SiteUrl + "/Panel/Wallet/OnlinPayResult?PaymentId=" + paymentId.ToString());

                if (x.Body.Status == 100)
                {
                    await _paymentService.UpdatePayment(paymentId, "-100", 0, x.Body.Authority, false);
                    await _unitOfWork.SaveChangesAsync();
                    var auth = x.Body.Authority;
                    var longauth = long.Parse(auth);
                    return Redirect("https://www.zarinpal.com/pg/StartPay/" + longauth);
                    //+ @"/ZarinGate"

                }
                else
                {

                    ViewBag.Message = PaymentResult.ZarinPal(Convert.ToString(x.Body.Status));

                    return View();
                }
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }


        }


        private async Task<long> FindAmountPayment(long paymentId)
        {
            var set = await _paymentService.GetPayment(paymentId);
            var amount = set.Amount;
            return amount;
        }




        [DisplayName("نتیجه پرداخت آنلاین")]
        [BreadCrumb(Order = 1)]
        public async Task<IActionResult> OnlinPayResult(string PaymentId, string Authority, string Status)
        {
            long paymentId = Convert.ToInt64(PaymentId);
            // بررسی وضعیت پرداخت
            if (Status.Equals("OK"))
            {
                // پیدا کردن مبلغ پرداختی از دیتابیس 
                int amount = (int)await FindAmountPayment(paymentId);
                // شماره پیگیری
                long refId = 0;
                ZarinPal.PaymentGatewayImplementationServicePortTypeClient zp = new ZarinPal.PaymentGatewayImplementationServicePortTypeClient();
                var Set = await _settingService.GetSettingsForEdit();
                // کد پذیرنده
                string merchantCode = Set.ZarinPalCode;
                // وری فای کردن اطلاعات
                var status = await zp.PaymentVerificationWithExtraAsync(merchantCode, Authority, amount);
                // بررسی وضعیت
                if (status.Body.Status == 100)
                {
                    var userId = this.User.Identity.GetUserId<int>();
                    refId = status.Body.RefID;
                    // پرداخت موفق بوده و اطلاعات دریافتی را در دیتابیس ثبت می کنیم
                    await _paymentService.UpdatePayment(paymentId, status.Body.Status.ToString(), refId, Authority.ToString(), true, userId);

                    ViewBag.Message = "پرداخت با موفقیت انجام شد.";
                    ViewBag.SaleReferenceId = refId;
                    ViewBag.Imageurl = "/images/pardakhtm.png";

                    WalletViewModel w = new WalletViewModel
                    {
                        Amount = amount,
                        Description = "شارژ کیف پول",
                        TType = WalletTransactionType.Deposit,
                        UserId = userId
                    };

                    await _walletService.InsertTWalleTask(w);

                    await _unitOfWork.SaveChangesAsync();
                }
                else
                {
                    // پرداخت ناموفق بوده و اطلاعات دریافتی را در دیتابیس ثبت می کنیم
                    await _paymentService.UpdatePayment(paymentId, status.Body.Status.ToString(), 0, Authority.ToString(), false);
                    await _unitOfWork.SaveChangesAsync();
                    ViewBag.Message = PaymentResult.ZarinPal(Convert.ToString(status));
                    ViewBag.SaleReferenceId = "**************";
                    ViewBag.Imageurl = "/images/pardakhtn.png";
                    ViewBag.showlogin = false;
                }
            }
            else
            {
                ViewBag.Message = PaymentResult.ZarinPal(Convert.ToString(0));
                ViewBag.SaleReferenceId = "**************";
                ViewBag.Imageurl = "/images/pardakhtn.png";
                ViewBag.showlogin = false;
            }

            return View();
        }



        [DisplayName("برداشت از کیف پول")]
        [BreadCrumb(Order = 1)]
        public async Task<IActionResult> Withdrawal()
        {
            var userId = this.User.Identity.GetUserId<int>();

            var walletInventory = await _walletService.GetWalletInventory(userId);

            var walletInventoryRond = (walletInventory - (walletInventory % 1000)) - 5000;
            ViewBag.WalletInventory = $"مبلغ قابل برداشت { walletInventoryRond.ToPersianNumbers("N0")} تومان می باشد";

            return View();
        }

        [DisplayName("برداشت از کیف پول")]
        [BreadCrumb(Order = 1)]
        [HttpPost]
        public async Task<IActionResult> Withdrawal(int amount)
        {
            var userId = this.User.Identity.GetUserId<int>();

            var walletInventory = await _walletService.GetWalletInventory(userId);

            var walletInventoryRond = (walletInventory - (walletInventory % 1000)) - 5000;




            if (amount > walletInventoryRond)
            {
                ViewBag.WalletInventory = $"مبلغ قابل برداشت { walletInventoryRond.ToPersianNumbers("N0")} تومان می باشد";

                _toastNotification.AddInfoToastMessage("موجودی شما از مبلغ درخواستی کمتر می باشد", new NotyOptions()
                {
                    Layout = "center"
                });
                return View();
            }
            else
            {

                WalletViewModel w = new WalletViewModel
                {
                    Amount = amount,
                    Description = "در انتظار تایید درخواست",
                    TType = WalletTransactionType.Waiting,
                    UserId = userId
                };

                await _walletService.InsertTWalleTask(w);

                await _unitOfWork.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

        }

    }
}