using Microdownload.Common.GuardToolkit;
using Microdownload.Common.IdentityToolkit;
using Microdownload.Entities.Identity;
using Microdownload.Services.Contracts.Identity;
using Microdownload.ViewModels.Identity;
using DNTBreadCrumb.Core;
using DNTCaptcha.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using System;
using Microdownload.ViewModels.Identity.Emails;
using Microdownload.ViewModels.Identity.Settings;
using DNTPersianUtils.Core;
using DNTCommon.Web.Core;
using Microdownload.Areas.Panel;
using Microdownload.Services.Identity;
using System.ComponentModel;
using System.Linq;

namespace Microdownload.Controllers
{
    [DisplayName("افزودن کاربر جدید")]

    public class RegisterController : Controller
    {
        private readonly IEmailSender _emailSender;
        private readonly ILogger<RegisterController> _logger;
        private readonly IApplicationUserManager _userManager;
        private readonly IPasswordValidator<User> _passwordValidator;
        private readonly IUserValidator<User> _userValidator;
        private readonly IOptionsSnapshot<SiteSettings> _siteOptions;
        private readonly IApplicationRoleManager _roleManager;

        public RegisterController(
            IApplicationUserManager userManager,
            IPasswordValidator<User> passwordValidator,
            IUserValidator<User> userValidator,
            IEmailSender emailSender,
            IOptionsSnapshot<SiteSettings> siteOptions,
            ILogger<RegisterController> logger,
            IApplicationRoleManager roleManager)
        {
            _userManager = userManager;
            _userManager.CheckArgumentIsNull(nameof(_userManager));

            _passwordValidator = passwordValidator;
            _passwordValidator.CheckArgumentIsNull(nameof(_passwordValidator));

            _userValidator = userValidator;
            _userValidator.CheckArgumentIsNull(nameof(_userValidator));

            _emailSender = emailSender;
            _emailSender.CheckArgumentIsNull(nameof(_emailSender));

            _logger = logger;
            _logger.CheckArgumentIsNull(nameof(_logger));

            _siteOptions = siteOptions;
            _siteOptions.CheckArgumentIsNull(nameof(_siteOptions));

            _roleManager = roleManager;
            _roleManager.CheckArgumentIsNull(nameof(_roleManager));

        }
    

    /// <summary>
    /// For [Remote] validation
    /// </summary>
    [AjaxOnly, HttpPost, ValidateAntiForgeryToken]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    public async Task<IActionResult> ValidateUsernameForRegister(string username)
    {

        var all = await _userManager.GetAllUsersAsync();
        var result = (from p in all
                      where p.NormalizedUserName == username.ToUpper()
                      select p);
        return Json(result.Any() ? "این نام کاربری در سیستم کاتب ثبت شده است" : "true");
    }




    /// <summary>
    /// For [Remote] validation
    /// </summary>
    [AjaxOnly, HttpPost, ValidateAntiForgeryToken]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    [BreadCrumb(Title = "اعتبار سنجی نام کاربری", Order = 1)]
    [DisplayName("اعتبار سنجی نام کاربری")]
    public async Task<IActionResult> ValidateUsername(string username, string email)
    {
        var result = await _userValidator.ValidateAsync(
            (UserManager<User>)_userManager, new User { UserName = username, Email = email });
        return Json(result.Succeeded ? "true" : result.DumpErrors(useHtmlNewLine: true));
    }

    /// <summary>
    /// For [Remote] validation
    /// </summary>
    [AjaxOnly, HttpPost, ValidateAntiForgeryToken]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    [BreadCrumb(Title = "اعتبار سنجی پسورد", Order = 1)]
    [DisplayName("اعتبار سنجی پسورد")]

    public async Task<IActionResult> ValidatePassword(string password, string username)
    {
        var result = await _passwordValidator.ValidateAsync(
            (UserManager<User>)_userManager, new User { UserName = username }, password);
        return Json(result.Succeeded ? "true" : result.DumpErrors(useHtmlNewLine: true));
    }

    [BreadCrumb(Title = "تائید ایمیل", Order = 1)]
    [DisplayName("تائید ایمیل")]

    public async Task<IActionResult> ConfirmEmail(string userId, string code)
    {
        if (userId == null || code == null)
        {
            return View("Error");
        }

        var user = await _userManager.FindByIdAsync(userId);
        if (user == null)
        {
            return View("NotFound");
        }

        var result = await _userManager.ConfirmEmailAsync(user, code);
        return View(result.Succeeded ? nameof(ConfirmEmail) : "Error");
    }


        [BreadCrumb(Title = "ثبت نام با کد معرف", Order = 1)]
        [DisplayName("ثبت نام با کد معرف")]

        public async Task<IActionResult> Index(string UserName)
        {
          var referrer= await _userManager.FindByNameAsync(UserName);
            var DisplayName = referrer.DisplayName;
            ViewBag.NameOfUser = DisplayName;

            var regModel = new RegisterViewModel();
            regModel.Referrer = referrer.UserName;
            return View(regModel);
        }




        [BreadCrumb(Title = "تائیدیه ایمیل", Order = 1)]
    [DisplayName("تائیدیه ایمیل")]
    public IActionResult ConfirmedRegisteration()
    {
        return View();
    }
    [BreadCrumb(Title = "ایندکس", Order = 1)]
    [DisplayName("ایندکس")]

    [HttpPost]
    [ValidateAntiForgeryToken]
    [ValidateDNTCaptcha(CaptchaGeneratorLanguage = DNTCaptcha.Core.Providers.Language.Persian)]
    public async Task<IActionResult> Index(RegisterViewModel model)
    {
        var cuser = User.Identity.GetUserName();

        if (ModelState.IsValid)
        {
           // var cuserId = int.Parse(_userManager.GetCurrentUserId());
                var user = new User
            {
                UserName = model.Username,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                MeliCode = model.MeliCode
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                _logger.LogInformation(3, $"{user.UserName} created a new account with password.");

                if (_siteOptions.Value.EnableEmailConfirmation)
                {
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    //ControllerExtensions.ShortControllerName<RegisterController>(), //todo: use everywhere .................

                    await _emailSender.SendEmailAsync(
                       email: user.Email,
                       subject: "لطفا اکانت خود را تائید کنید",
                       viewNameOrPath: "~/Areas/Panel/Views/EmailTemplates/_RegisterEmailConfirmation.cshtml",
                       model: new RegisterEmailConfirmationViewModel
                       {
                           User = user,
                           EmailConfirmationToken = code,
                           EmailSignature = _siteOptions.Value.Smtp.FromName,
                           MessageDateTime = DateTime.UtcNow.ToLongPersianDateTimeString()
                       });

                    return RedirectToAction(nameof(ConfirmYourEmail));
                }
                return RedirectToAction(nameof(ConfirmedRegisteration));
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }
        return View(model);
    }

    [BreadCrumb(Title = "ایمیل خود را تائید کنید", Order = 1)]
    [DisplayName("ایمیل خود را تائید کنید")]

    public IActionResult ConfirmYourEmail()
    {
        return View();
    }
}
}