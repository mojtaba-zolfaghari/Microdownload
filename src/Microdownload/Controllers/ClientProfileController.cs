using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using DNTBreadCrumb.Core;
using Microdownload.DataLayer.Context;
using Microdownload.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microdownload.Common.IdentityToolkit;
using NToastNotify;
using Microdownload.Services.Contracts.Identity;

namespace Microdownload.Controllers
{
    public class ClientProfileController : Controller
    {
        private readonly ICourseService _ICourseService;
        private readonly IInstituteService _IInstituteService;

        private readonly IToastNotification _toastNotification;
        private readonly IUnitOfWork _uow;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IApplicationUserManager _userManager;


        public ClientProfileController(IApplicationUserManager userManager, IInstituteService instituteService, IToastNotification toastNotification, ICourseService CourseService, IUnitOfWork uow, IHostingEnvironment hostingEnvironment)
        {
            _userManager = userManager;
            _toastNotification = toastNotification;
            _ICourseService = CourseService;
            _uow = uow;
            _hostingEnvironment = hostingEnvironment;
            _IInstituteService = instituteService;
        }


        [BreadCrumb(Title = "پروفایل کاربر", UseDefaultRouteUrl = true, Order = 0)]
        [DisplayName("پروفایل کاربر")]
        public async Task<IActionResult> Index(Int32? page = 1, Int32? rows = 10)
        {
            var cuser = int.Parse(User.Identity.GetUserId());
            var UserDatail =await _userManager.FindByIdAsync(cuser.ToString());
            ViewBag.UserDetail = UserDatail;

            var model = await _ICourseService.GetCourseListAsync(cuser, page.Value, rows.Value);
            ViewBag.TotalRows = model.Paging.TotalItems;
            ViewBag.CurrentPage = page;
            ViewBag.ListCourse = model;

            return View();
        }
    }
}