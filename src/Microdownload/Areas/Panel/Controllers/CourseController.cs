using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DNTBreadCrumb.Core;
using DNTCommon.Web.Core;
using Microdownload.Common.IdentityToolkit;
using Microdownload.DataLayer.Context;
using Microdownload.Services;
using Microdownload.Services.Identity;
using Microdownload.ViewModels;
using Microdownload.ViewModels.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace Microdownload.Areas.Panel.Controllers
{
    [Area(AreaConstants.PanelArea)]
    [Authorize(Policy = ConstantPolicies.DynamicPermission)]
    [BreadCrumb(Title = "دوره ها", UseDefaultRouteUrl = true, Order = 0)]
    [DisplayName("دوره ها")]
    public class CoursesController : Controller
    {
        private const string CourseNotFound = "اطلاعات درخواستی یافت نشد.";

        private readonly ICourseService _ICourseService;
        private readonly IInstituteService _IInstituteService;

        private readonly IToastNotification _toastNotification;
        private readonly IUnitOfWork _uow;
        private readonly IHostingEnvironment _hostingEnvironment;
        

        public CoursesController(IInstituteService instituteService, IToastNotification toastNotification, ICourseService CourseService, IUnitOfWork uow, IHostingEnvironment hostingEnvironment)
        {
            _toastNotification = toastNotification;
            _ICourseService = CourseService;
            _uow = uow;
            _hostingEnvironment = hostingEnvironment;
            _IInstituteService = instituteService;
        }

        [BreadCrumb(Title = "ایندکس دوره ها", Order = 1)]
        [DisplayName("ایندکس دوره ها")]
        public async Task<IActionResult> Index(Int32? page = 1, Int32? rows = 10)
        {
            var cuser = int.Parse(User.Identity.GetUserId());

            var model = await _ICourseService.GetCourseListAsync(cuser, page.Value, rows.Value);
            ViewBag.TotalRows = model.Paging.TotalItems;
            ViewBag.CurrentPage = page;
            return View(model: model.List);
        }



        [DisplayName("رندر افزودن و ویرایش")]
        [AjaxOnly]
        public async Task<IActionResult> RenderCourse([FromBody]ModelIdViewModel model, IFormFile ImageUrlFile)
        {
            //if (string.IsNullOrWhiteSpace(model?.Id))
            //{
            //    return PartialView("_Create");
            //}

            //var Course = await _ICourseService.GetCourseByIdAsync(int.Parse(model.Id));
            //if (Course == null)
            //{
            //    ModelState.AddModelError("", CourseNotFound);
            //    return PartialView("_Create");
            //}
            //return PartialView("_Create", model: new CourseViewModel { Id = Course.Id, CourseName = Course.CourseName,CreatedDate= Course.CreatedDate,Price= Course.Price,Link=Course.Link });











            var query = await _IInstituteService.GetTeachersListForViewBagAsync();
            ViewData["ListTeacher"] = query;

            var query2 = await _IInstituteService.GetInstituteListForAddAsync();
            ViewData["ListInstitute"] = query2;
            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                return PartialView("_Create");
            }
            var id = int.Parse(model.Id);
            var Cou = await _ICourseService.GetCourseByIdAsync(id).ConfigureAwait(false);
            if (Cou == null)
            {
                ModelState.AddModelError("", "اطلاعات مورد نظر یافت نشد");
                return PartialView("_Create");
            }
            return PartialView("_Create", model: Cou);






        }




        [AjaxOnly]
        [HttpPost]
        [ValidateAntiForgeryToken]
        [DisplayName("افزودن یا ویرایش دوره")]
        
        public virtual async Task<ActionResult> AddCourse(CourseViewModel model, IFormFile ImageUrlFile,int page = 1, int rows = 10)
        {
            var cuser = int.Parse(User.Identity.GetUserId());

            if (!ModelState.IsValid)
            {
                return View();
            }
            IdentityResult result;

                model.CourseStatus = Entities.CourseStatus._FirstRegisteration;

            if (ImageUrlFile != null)
            {
                var fileName = Path.Combine(_hostingEnvironment.WebRootPath + "/images/userpic/", Path.GetFileName(ImageUrlFile.FileName));
                ImageUrlFile.CopyTo(new FileStream(fileName, FileMode.Create));
                model.ImageUrl = "/images/userpic/" + Path.GetFileName(ImageUrlFile.FileName);
            }

                result = _ICourseService.AddCourse(model);
                if (result.Succeeded)
                {
                    await _uow.SaveChangesAsync().ConfigureAwait(false);
                var institutemodel=   await _IInstituteService.GetInstituteByUserIdAsync(cuser);
                InstituteCourseViewModel InstituteCourseVM = new InstituteCourseViewModel();
                InstituteCourseVM.CoursesId = model.Id.Value;
                InstituteCourseVM.InstituteId = institutemodel.Id.Value;
                await _IInstituteService.AddInstituteCourse(model: InstituteCourseVM);

                var CourseModel1 = _ICourseService.GetCourseListAsync(cuser,page,rows).Result.List.Where(c=>c.CourseName==model.CourseName).Single().Id;

                foreach (var item in model.TeacherCourseIdes)
                {
                    var teacher = _IInstituteService.AddCourseToTeacherById(item, CourseModel1.Value);
                    if (teacher.Succeeded)
                    {
                        await _uow.SaveChangesAsync().ConfigureAwait(false);

                    }
                }

                return Json(new { success = true });
                }

            return PartialView("_Create", model: model);
        }


        [DisplayName("ویرایش دوره")]
        
        public virtual async Task<ActionResult> EditCourse(int Id)
        {
              var  Course =await _ICourseService.GetCourseByIdAsync(Id);

            var query = await _IInstituteService.GetTeachersListForViewBagAsync();
            ViewData["ListTeacher"] = query;


            return View(Course);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [DisplayName("افزودن یا ویرایش دوره")]

        public virtual async Task<ActionResult> EditCourse(CourseViewModel model, IFormFile ImageUrlFile, int page = 1, int rows = 10)
        {
            var cuser = int.Parse(User.Identity.GetUserId());

            if (!ModelState.IsValid)
            {
                return View();
            }
            IdentityResult result;

            if (ImageUrlFile != null)
            {
                var fileName = Path.Combine(_hostingEnvironment.WebRootPath + "/images/userpic/", Path.GetFileName(ImageUrlFile.FileName));
                ImageUrlFile.CopyTo(new FileStream(fileName, FileMode.Create));
                model.ImageUrl = "/images/userpic/" + Path.GetFileName(ImageUrlFile.FileName);
            }

            result = _ICourseService.EditCourse(model);

                if (result.Succeeded)
                {
                    await _uow.SaveChangesAsync().ConfigureAwait(false);


                var CourseModel1 = _ICourseService.GetCourseListAsync(cuser, page, rows).Result.List.Where(c => c.CourseName == model.CourseName).Single().Id;

                foreach (var item in model.TeacherCourseIdes)
                {
                    var teacher = _IInstituteService.AddCourseToTeacherById(item, CourseModel1.Value);
                    if (teacher.Succeeded)
                    {
                        await _uow.SaveChangesAsync().ConfigureAwait(false);

                    }
                }



                _toastNotification.AddInfoToastMessage("ویرایش شد", new NotyOptions()
                    {
                        Layout = "center"
                    });
                    return View(model);
                }
                return View();
            
        }







        }
}