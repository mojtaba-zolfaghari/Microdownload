using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using DNTBreadCrumb.Core;
using Microdownload.DataLayer.Context;
using Microdownload.Services;
using Microdownload.Services.Contracts.Identity;
using Microdownload.Services.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Microdownload.Controllers
{
    [BreadCrumb(Title = "آموزشگاه ", UseDefaultRouteUrl = true, Order = 0)]
    [DisplayName("آموزشگاه")]
    public class InstituteCourseController : Controller
    {
        private readonly ICourseService _ICourseService;
        private readonly IInstituteService _IInstituteService;
        private readonly IUnitOfWork _uow;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IApplicationUserManager _userManager;

        public InstituteCourseController(IInstituteService IInstituteService, ICourseService CourseService, IUnitOfWork uow, IHostingEnvironment hostingEnvironment, IApplicationUserManager userManager)
        {
            _IInstituteService = IInstituteService;
            _ICourseService = CourseService;
            _uow = uow;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        [BreadCrumb(Title = "ایندکس آموزشگاه عمومی", Order = 1, GlyphIcon = "icon-home")]
        
        public async Task<IActionResult> Index(int Id)
        {
          var Institutemodel=await  _IInstituteService.GetInstituteByIdAsync(Id);
            ViewBag.ListInstitute = Institutemodel;

            var Coursemodel =await  _IInstituteService.GetCourseInstituteById(Institutemodel.Id);
            ViewBag.ListInstituteCourse = Coursemodel;

            return View();

        }
    }
}





