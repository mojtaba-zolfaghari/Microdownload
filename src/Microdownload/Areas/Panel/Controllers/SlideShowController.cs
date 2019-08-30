using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DNTBreadCrumb.Core;
using DNTCommon.Web.Core;
using Microdownload.DataLayer.Context;
using Microdownload.Entities;
using Microdownload.Services;
using Microdownload.Services.Identity;
using Microdownload.ViewModels;
using Microdownload.ViewModels.Identity.Settings;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microdownload.Common.GuardToolkit;
using Microdownload.ViewModels.Identity;

namespace Microdownload.Areas.Panel.Controllers
{
    [Authorize(Roles = ConstantRoles.Admin)]
    [Area(AreaConstants.PanelArea)]
    [BreadCrumb(Title = "مدیریت اسلاید شو", UseDefaultRouteUrl = true, Order = 0)]

    public class SlideShowController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IOptionsSnapshot<SiteSettings> _siteSettings;
        private readonly ISlideShowImageService _slideShowService;



        public SlideShowController(IUnitOfWork unitOfWork, ISlideShowImageService slideShowService, IMapper mapper, IOptionsSnapshot<SiteSettings> siteSettings, IHostingEnvironment hostingEnvironment)
        {

            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _slideShowService = slideShowService;
            _siteSettings = siteSettings;
            _hostingEnvironment = hostingEnvironment;
        }





        [BreadCrumb(Title = "ایندکس", Order = 1, GlyphIcon = "fa fa-hashtag")]
        public async Task<IActionResult> Index()
        {
            var d = _siteSettings.Value.SlideShowImageFolder;
            var model = await _slideShowService.GetSlideShowImages();
            return View(model);
        }


        [AjaxOnly]
        public async Task<IActionResult> RenderDeleteSlideshow([FromBody]ModelIdViewModel model)
        {
            if (string.IsNullOrWhiteSpace(model?.Id))
            {
                return PartialView("_Delete");
            }
            var id = int.Parse(model.Id);
            var slide = await _slideShowService.GetSlideShow(id).ConfigureAwait(false);
            if (slide == null)
            {
                //ModelState.AddModelError("", RoleNotFound);
                return PartialView("_Delete");
            }
            return PartialView("_Delete", model: slide);
        }

        [AjaxOnly]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(SlideShowViewModel model)
        {
            if (model.Id.HasValue)
            {
                var slide = await _slideShowService.GetSlideShow(model.Id.Value);

                var result = _slideShowService.DeleteSlide(model.Id.Value);

                if (result.Succeeded)
                {
                    var uploadsRootFolder = GetSlideShowImageFolderPath();
                    var photoFileName = slide.Image;
                    var filePath = Path.Combine(uploadsRootFolder, photoFileName);


                    if (System.IO.File.Exists(filePath))
                    {
                        System.IO.File.Delete(filePath);
                    }

                    await _unitOfWork.SaveChangesAsync();
                    return Json(new { success = true });
                }
            }

            return PartialView("_Delete", model: model);
        }




        [DisplayName("افزودن اسلاید")]
        [BreadCrumb(Order = 1)]

        public IActionResult AddSlide()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddSlide(SlideShowViewModel slideShowModel)
        {
            if (this.ModelState.IsValid)
            {
                var model = _mapper.Map<SlideShowViewModel, SlideShowImage>(slideShowModel);

                var otherSlideShows = new List<SlideShowImage>();

                _mapper.Map<IList<SlideShowViewModel>, IList<SlideShowImage>>(slideShowModel.SlideShowImages,
                    otherSlideShows);

                var photoFile = slideShowModel.Photo;
                if (photoFile != null && photoFile.Length > 0)
                {
                    if (!photoFile.IsValidImageFile(maxWidth: 1600, maxHeight: 800))
                    {
                        this.ModelState.AddModelError("",
                            $"حداکثر اندازه تصویر قابل ارسال {800} در {1600} پیکسل است");
                        return View(viewName: nameof(EditSlide), model: slideShowModel);
                    }

                    var uploadsRootFolder = GetSlideShowImageFolderPath();
                    var photoFileName = $"{Guid.NewGuid().ToString()}{Path.GetExtension(photoFile.FileName)}";
                    var filePath = Path.Combine(uploadsRootFolder, photoFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.CreateNew))
                    {
                        await photoFile.CopyToAsync(fileStream).ConfigureAwait(false);
                    }
                    model.Image = photoFileName;
                }

                _slideShowService.AddSlide(model, otherSlideShows);

                await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);


            }


            return RedirectToAction("Index");

        }

        public string GetSlideShowImageFolderPath()
        {
            var usersAvatarsFolder = _siteSettings.Value.SlideShowImageFolder;
            var uploadsRootFolder = Path.Combine(_hostingEnvironment.WebRootPath, usersAvatarsFolder);
            if (!Directory.Exists(uploadsRootFolder))
            {
                Directory.CreateDirectory(uploadsRootFolder);
            }
            return uploadsRootFolder;
        }






        [DisplayName("ویرایش اسلاید")]
        [BreadCrumb(Order = 1)]

        public async Task<IActionResult> EditSlide(int? Id)
        {
            if (Id.HasValue)
            {
                var slide = await _slideShowService.GetSlideShow(Id.Value);

                return View(slide);

            }
            else
            {
                return RedirectToAction("Index");

            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> EditSlide(SlideShowViewModel slideShowModel)
        {
            if (this.ModelState.IsValid)
            {


                var oldslide = await _slideShowService.GetSlideShow(slideShowModel.Id.Value);

                var model = _mapper.Map<SlideShowViewModel, SlideShowImage>(slideShowModel);

                var otherSlideShows = new List<SlideShowImage>();

                _mapper.Map<IList<SlideShowViewModel>, IList<SlideShowImage>>(slideShowModel.SlideShowImages,
                    otherSlideShows);

                var photoFile = slideShowModel.Photo;
                if (photoFile != null && photoFile.Length > 0)
                {

                    if (!photoFile.IsValidImageFile(maxWidth: 1600, maxHeight: 800))
                    {
                        this.ModelState.AddModelError("",
                            $"حداکثر اندازه تصویر قابل ارسال {800} در {1600} پیکسل است");

                        return View(viewName: nameof(EditSlide), model: slideShowModel);

                    }

                    var uploadsRootFolder = GetSlideShowImageFolderPath();
                    var photoFileName = $"{Guid.NewGuid().ToString()}{Path.GetExtension(photoFile.FileName)}";
                    var filePath = Path.Combine(uploadsRootFolder, photoFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.CreateNew))
                    {
                        await photoFile.CopyToAsync(fileStream).ConfigureAwait(false);
                    }


                    if (!string.IsNullOrEmpty(oldslide.Image))
                    {
                        var uploadsRootFolderD = GetSlideShowImageFolderPath();
                        var photoFileNameD = oldslide.Image;
                        var filePathD = Path.Combine(uploadsRootFolderD, photoFileNameD);
                        if (System.IO.File.Exists(filePathD))
                        {
                            System.IO.File.Delete(filePathD);
                        }


                    }



                    model.Image = photoFileName;
                }
                else
                {
                    model.Image = oldslide.Image;
                }


                _slideShowService.EditSlide(model, otherSlideShows);

                await _unitOfWork.SaveChangesAsync();


            }


            return RedirectToAction("Index");
        }

    }
}