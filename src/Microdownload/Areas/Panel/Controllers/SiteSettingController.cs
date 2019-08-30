using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNTBreadCrumb.Core;
using DNTCommon.Web.Core;
using Microdownload.Common.WebToolkit;
using Microdownload.DataLayer.Context;
using Microdownload.Services;
using Microdownload.Services.Identity;
using Microdownload.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Microdownload.Areas.Panel.Controllers
{
    [Authorize(Roles = ConstantRoles.Admin)]
    [Area(AreaConstants.PanelArea)]
    [BreadCrumb(Title = "تنطیمات سایت", UseDefaultRouteUrl = true, Order = 0)]

    public class SiteSettingController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPortalSettingService _settingService;

        public SiteSettingController(IUnitOfWork unitOfWork, IPortalSettingService settingService)
        {
            _unitOfWork = unitOfWork;
            _settingService = settingService;
        }

        [BreadCrumb(Title = "ایندکس", Order = 1, GlyphIcon = "fa fa-hashtag")]
        public async Task<IActionResult> Index()
        {
            var model = await _settingService.GetSettingsForEdit();

            if (!string.IsNullOrWhiteSpace(model.CopyRight))
            {
                model.CopyRight = model.CopyRight.Replace("<br/>", Environment.NewLine);
            }
            return View(model);
        }


        [DNTCommon.Web.Core.AjaxOnly, HttpPost, ValidateAntiForgeryToken]
        public virtual async Task<IActionResult> Index(PortalSettingViewModel settingModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(error: "خطایی رخ داده است");
            }

            if (!string.IsNullOrWhiteSpace(settingModel.SiteDescription))
            {
                settingModel.SiteDescription = SeoHelpers.GenerateMetaDescription(settingModel.SiteDescription);
            }

            var result = await _settingService.UpdateSettingsAsync(settingModel);


            if (result.Succeeded)
            {
                await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
                return Json(new { success = true });

            }

            return View(viewName: nameof(Index), model: settingModel);
        }


    }
}