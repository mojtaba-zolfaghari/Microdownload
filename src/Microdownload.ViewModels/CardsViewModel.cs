using cloudscribe.Web.Pagination;
using Microdownload.ViewModels.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Microdownload.ViewModels
{
    public class CardsViewModel
    {


        public int? Id { get; set; }
        [StringLength(100, ErrorMessage = "{0} باید حداقل {2} و حداکثر {1} حرف باشند.", MinimumLength = 6)]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [RegularExpression("^[0-9a-zA-Z_]*$", ErrorMessage = "لطفا تنها از حروف انگلیسی و یا اعداد استفاده نمائید")]
        [DisplayName("کد فعالسازی")]
        public string ActiveCode { get; set; }


        public int? UserId { get; set; }

        public DateTimeOffset? DateStartUse { get; set; }

    }
}
