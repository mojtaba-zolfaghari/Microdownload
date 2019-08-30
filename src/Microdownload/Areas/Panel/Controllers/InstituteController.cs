using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DNTBreadCrumb.Core;
using DNTCommon.Web.Core;
using Microdownload.Common.IdentityToolkit;
using Microdownload.DataLayer.Context;
using Microdownload.Services;
using Microdownload.Services.Contracts.Identity;
using Microdownload.Services.Identity;
using Microdownload.ViewModels;
using Microdownload.ViewModels.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Microdownload.Areas.Panel.Controllers
{
    [Area(AreaConstants.PanelArea)]
    [Authorize(Policy = ConstantPolicies.DynamicPermission)]
    [BreadCrumb(Title = "آموزشگاه ", UseDefaultRouteUrl = true, Order = 0)]
    [DisplayName("آموزشگاه")]
    public class InstituteController : Controller
    {
        private readonly ICourseService _ICourseService;
        private readonly IInstituteService _IInstituteService;
        private readonly IUnitOfWork _uow;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IApplicationUserManager _userManager;

        public InstituteController(IInstituteService IInstituteService, ICourseService CourseService, IUnitOfWork uow, IHostingEnvironment hostingEnvironment, IApplicationUserManager userManager)
        {
            _IInstituteService = IInstituteService;
            _ICourseService = CourseService;
            _uow = uow;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        #region آموزشگاه
        [BreadCrumb(Title = "ایندکس آموزشگاه", Order = 1)]
        [DisplayName("ایندکس آموزشگاه")]
        public async Task<IActionResult> Index(int? page = 1, int? rows = 10)
        {
            var cuser = int.Parse(User.Identity.GetUserId());

            var model = await _IInstituteService.GetInstituteListAsync();
            ViewBag.TotalRows = model.Paging.TotalItems;
            ViewBag.CurrentPage = page;
            return View(model: model.List);
        }



        [DisplayName("حذف آموزشگاه")]
        [AjaxOnly]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteInstitute(int Id)
        {
            var model = await _IInstituteService.GetInstituteByIdAsync(Id);
            var result = await _IInstituteService.DeleteInstituteByIdAsync(Id).ConfigureAwait(false);

            if (result.Succeeded)
            {
                await _uow.SaveChangesAsync().ConfigureAwait(false);

                return Json(new { success = true });
            }

            return PartialView("_DeleteInstitute", model: model);
        }


        [AjaxOnly]
        [HttpPost]
        [ValidateAntiForgeryToken]
        [DisplayName("افزودن یا ویرایش آموزشگاه")]
        public virtual async Task<ActionResult> AddEditInstitute(InstituteViewModel model)
        {
            var cuser = int.Parse(User.Identity.GetUserId());
            model.InstituteType = Entities.InstituteType._FirstRegistration;

            if (!ModelState.IsValid)
            {
                return View();
            }
            IdentityResult result;
            if (model.Id.HasValue)
            {
                result = _IInstituteService.EditInstitute(model);

                if (result.Succeeded)
                {
                    await _uow.SaveChangesAsync().ConfigureAwait(false);

                    return Json(new { success = true });
                }
            }
            else
            {
                result = _IInstituteService.AddInstitute(model);
                if (result.Succeeded)
                {
                    await _uow.SaveChangesAsync().ConfigureAwait(false);

                    return Json(new { success = true });
                }



            }
            return PartialView("_CreateInstitute", model: model);
        }




        [DisplayName("رندر حذف آموزشگاه")]
        [AjaxOnly]
        public async Task<IActionResult> RenderDeleteInstitute([FromBody]ModelIdViewModel model)
        {
            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                return PartialView("_DeleteInstitute");
            }
            var id = int.Parse(model.Id);
            var wage = await _IInstituteService.GetInstituteByIdAsync(id).ConfigureAwait(false);
            if (wage == null)
            {
                ModelState.AddModelError("", "کارمزد مورد نظر یافت نشد");
                return PartialView("_DeleteInstitute");
            }
            return PartialView("_DeleteInstitute", model: wage);
        }



        [DisplayName("رندر افزودن و ویرایش  آموزشگاه")]
        [AjaxOnly]
        public async Task<IActionResult> RenderInstitute([FromBody]ModelIdViewModel model)
        {


            var query = await _userManager.GetAllUsersAsync();
            ViewData["ListUser"] = query;

            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                return PartialView("_CreateInstitute");
            }
            var id = int.Parse(model.Id);
            var Cou = await _ICourseService.GetCourseByIdAsync(id).ConfigureAwait(false);
            if (Cou == null)
            {
                ModelState.AddModelError("", "اطلاعات مورد نظر یافت نشد");
                return PartialView("_CreateInstitute");
            }
            return PartialView("_CreateInstitute", model: Cou);
        }




        #endregion


        #region مدرس ها
        [BreadCrumb(Title = "ایندکس مدرس ها", Order = 1)]
        [DisplayName("ایندکس مدرس ها")]
        public async Task<IActionResult> Teacher(int page = 1, int rows = 10)
        {
            var cuser = int.Parse(User.Identity.GetUserId());

            var model = await _IInstituteService.GetTeachersListAsync(cuser, page, rows);
            ViewBag.TotalRows = model.Paging.TotalItems;
            ViewBag.CurrentPage = page;
            return View(model: model.List);
        }

        [AjaxOnly]
        [HttpPost]
        [ValidateAntiForgeryToken]
        [DisplayName("افزودن یا ویرایش مدرس")]

        public virtual async Task<ActionResult> AddEditTeacher(TeacherViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            IdentityResult result;

            if (model.Id.HasValue)
            {
                result = _IInstituteService.EditTeacher(model);

                if (result.Succeeded)
                {
                    await _uow.SaveChangesAsync().ConfigureAwait(false);
                    foreach (var item in model.TeacherCourseIdes)
                    {
                        var teacher = _IInstituteService.AddCourseToTeacherById(model.UserId, item);
                    }

                    return Json(new { success = true });
                }
            }
            else
            {
                result = _IInstituteService.AddTeacher(model);
                if (result.Succeeded)
                {
                    _uow.SaveChanges();
                    var TeacherModel1 = _IInstituteService.GetTeachersListForViewBagAsync().Result.Where(c => c.UserId == model.UserId).Single();

                    foreach (var item in model.InstituteTeacherIdes)
                    {
                        var teacher = _IInstituteService.AddInstituteToTeacherById(TeacherModel1.Id.Value, item);
                        if (teacher.Succeeded)
                        {
                            await _uow.SaveChangesAsync().ConfigureAwait(false);

                        }
                    }

                    return Json(new { success = true });
                }



            }
            return PartialView("_CreateTeacher", model: model);
        }



        [DisplayName("رندر افزودن و ویرایش مدرس")]
        [AjaxOnly]
        public async Task<IActionResult> RenderTeacher([FromBody]ModelIdViewModel model, int page = 1, int rows = 10)
        {
            var cuser = int.Parse(User.Identity.GetUserId());

            var ulist = await _userManager.GetAllUsersAsync();
            var subselect = (from b in ulist select b.Id).ToList();


            var query2 = await _IInstituteService.GetInstituteListForAddAsync();


            ViewData["ListUser"] = ulist;
            ViewData["ListInstitute"] = query2;

            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                return PartialView("_CreateTeacher");
            }
            var id = int.Parse(model.Id);
            var Cou = await _ICourseService.GetCourseByIdAsync(id).ConfigureAwait(false);
            if (Cou == null)
            {
                ModelState.AddModelError("", "اطلاعات مورد نظر یافت نشد");
                return PartialView("_CreateTeacher");
            }
            return PartialView("_CreateTeacher", model: Cou);
        }

        #endregion


        #region درخواست ها ی آموزشگاه یا نماینده

        [BreadCrumb(Title = "درخواست آموزشگاه یا نمایندگی", Order = 1)]
        [DisplayName("درخواست آموزشگاه یا نمایندگی")]
        [HttpPost]
        public async Task<IActionResult> CreateInstituteRequest([FromForm]InstituteRequestViewModel model, IFormFile ResumeUrlFile)
        {
            var cuser = int.Parse(User.Identity.GetUserId());
            model.RequestStatus = Entities.RequestStatus._Requested;
            model.UserId = cuser;
            IdentityResult result;
            if (ResumeUrlFile != null)
            {
                var fileName = Path.Combine(_hostingEnvironment.WebRootPath + "/Upload/InstituteRequest/", Path.GetFileName(ResumeUrlFile.FileName));
                ResumeUrlFile.CopyTo(new FileStream(ResumeUrlFile.FileName, FileMode.Create));
                model.RegisterdFile = "/Upload/InstituteRequest/" + Path.GetFileName(ResumeUrlFile.FileName);
            }

            if (!ModelState.IsValid)
            {
                return View();
            }
            result = _IInstituteService.AddInstituteRequest(model);
            if (result.Succeeded)
            {
                await _uow.SaveChangesAsync().ConfigureAwait(false);
                RedirectToAction("CreateInstituteRequest");
            }
          return   RedirectToAction("CreateInstituteRequest");
        }


        [BreadCrumb(Title = "درخواست آموزشگاه یا نمایندگی", Order = 1)]
        [DisplayName("درخواست آموزشگاه یا نمایندگی")]
        [HttpGet]
        public IActionResult CreateInstituteRequest()
        {
            return View();
        }





        [BreadCrumb(Title = "ایندکس درخواست ثبت آموزشگاه یا نمایندگی", Order = 1)]
        [DisplayName("ایندکس آموزشگاه یا نمایندگی")]
        public async Task<IActionResult> InstituteRequest(int? page = 1, int? rows = 10)
        {
            var cuser = int.Parse(User.Identity.GetUserId());

            var model = await _IInstituteService.GetInstituteRequestListAsync(cuser, page, rows);
            ViewBag.TotalRows = model.Paging.TotalItems;
            ViewBag.CurrentPage = page;
            return View(model: model.List);
        }


        [DisplayName("رندر افزودن و ویرایش مدرس")]
        [AjaxOnly]
        public async Task<IActionResult> RenderTeacherRequest([FromBody]ModelIdViewModel model, int RequestId, int page = 1, int rows = 10)
        {
            var cuser = int.Parse(User.Identity.GetUserId());


            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                return PartialView();
            }


            var id = int.Parse(model.Id);
            var instituteRequest = await _IInstituteService.GetInstituteRequesByIdAsync(RequestId);
            if (instituteRequest == null)
            {
                ModelState.AddModelError("", "اطلاعات مورد نظر یافت نشد");
                return View();
            }
            return View(model: instituteRequest);



        }

        #endregion


        #region درخواست ها ی مدرس ها
        [BreadCrumb(Title = "ایندکس درخواست های مربیگری", Order = 1)]
        [DisplayName("درخواست های مربیگری")]
        public async Task<IActionResult> TeacherRequest(int? page = 1, int? rows = 10)
        {
            var cuser = int.Parse(User.Identity.GetUserId());

            var model = await _IInstituteService.GetTeacherRequestListAsync(cuser, page, rows);
            ViewBag.TotalRows = model.Paging.TotalItems;
            ViewBag.CurrentPage = page;
            return View(model: model.List);
        }
        [BreadCrumb(Title = "ایندکس درخواست مربیگری", Order = 1)]
        [DisplayName("درخواست مربیگری")]
        [HttpPost]
        public async Task<IActionResult> CreateTeacherRequest([FromForm]TeacherRequestViewModel model, IFormFile ResumeUrlFile)
        {
            var cuser = int.Parse(User.Identity.GetUserId());
            model.RequestResponseStatus = Entities.RequestResponseStatus._Requested;
            model.UserId = cuser;
            IdentityResult result;
            if (ResumeUrlFile != null)
            {
                var fileName = Path.Combine(_hostingEnvironment.WebRootPath + "/Upload/Resume/", Path.GetFileName(ResumeUrlFile.FileName));
                ResumeUrlFile.CopyTo(new FileStream(ResumeUrlFile.FileName, FileMode.Create));
                model.ResumeFile = "/Upload/Resume/" + Path.GetFileName(ResumeUrlFile.FileName);
            }

            if (!ModelState.IsValid)
            {
                return View();
            }
            result = _IInstituteService.AddTeacherReuest(model);
            if (result.Succeeded)
            {
                await _uow.SaveChangesAsync().ConfigureAwait(false);

                return Json(new { success = true });
            }
            return View();

        }
        #endregion


    }
}