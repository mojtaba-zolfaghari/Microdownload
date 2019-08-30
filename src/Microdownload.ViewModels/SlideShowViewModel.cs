using DNTCommon.Web.Core;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Microdownload.ViewModels
{
   public class SlideShowViewModel
    {
        public const string AllowedImages = ".png,.jpg,.jpeg,.gif";

        public SlideShowViewModel()
        {
            Order = 0;
        }

        public int? Id { get; set; }
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]

        public string Title { get; set; }

        [Display(Name = "توضیحات")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "تصویر")]
        public string Image { get; set; }

        [UploadFileExtensions(AllowedImages,
                                      ErrorMessage = "لطفا تنها یک تصویر " + AllowedImages + " را ارسال نمائید.")]
        [DataType(DataType.Upload)]
        public IFormFile Photo { get; set; }

        [Display(Name = "لینک")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]

        public string Link { get; set; }

        [Display(Name = "ترتیب")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]

        public int Order { get; set; }
        public IList<SlideShowViewModel> SlideShowImages { get; set; }

    }
}
