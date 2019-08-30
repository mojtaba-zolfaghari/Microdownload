using DNTBreadCrumb.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microdownload.Common.IdentityToolkit;
using System.Collections.Generic;
using HtmlAgilityPack;
using System.ComponentModel;
using System.Net;
using System;
using Microdownload.Services.Identity;
using Microdownload.Services;
using Microsoft.AspNetCore.Hosting;
using Microdownload.Services.Contracts.Identity;
using Microdownload.DataLayer.Context;
using System.Threading.Tasks;
using Microdownload.ViewModels;

namespace Microdownload.Controllers
{
    [BreadCrumb(Title = "خانه", UseDefaultRouteUrl = true, Order = 0)]
    [DisplayName("خانه")]
    public class HomeController : Controller
    {
        private readonly ICourseService _ICourseService;
        private readonly IInstituteService _IInstituteService;
        private readonly IUnitOfWork _uow;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IApplicationUserManager _userManager;
        private readonly IPortalSettingService _settingService;


        public HomeController(IPortalSettingService settingService,IInstituteService IInstituteService, ICourseService CourseService, IUnitOfWork uow, IHostingEnvironment hostingEnvironment, IApplicationUserManager userManager)
        {
            _IInstituteService = IInstituteService;
            _ICourseService = CourseService;
            _uow = uow;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
            _settingService = settingService;
        }

        [BreadCrumb(Title = "ایندکس صفحه اصلی", Order = 1, GlyphIcon = "icon-home")]
        public async Task<IActionResult> Index()
        {
            var setting = await _settingService.GetSettingsForEdit().ConfigureAwait(false);


            var model =await _IInstituteService.GetTopInstituteListAsync(int.Parse(setting.GetTopInstitute));
            ViewBag.ListInstitute = model;

            var Top10 = await _ICourseService.GetTopCourseListAsync(int.Parse(setting.GetTopCourse));
            ViewBag.ListCourse = Top10;
            return View();

        }





        [BreadCrumb(Title = "خطا", Order = 1)]
        public IActionResult Error()
        {
            return View();
        }

        /// <summary>
        /// To test automatic challenge after redirecting from another site
        /// Sample URL: http://localhost:5000/Home/CallBackResult?token=1&status=2&orderId=3&terminalNo=4&rrn=5
        /// </summary>
        [Authorize]
        public IActionResult CallBackResult(long token, string status, string orderId, string terminalNo, string rrn)
        {
            var userId = User.Identity.GetUserId();
            return Json(new { userId, token, status, orderId, terminalNo, rrn });
        }
    }
}