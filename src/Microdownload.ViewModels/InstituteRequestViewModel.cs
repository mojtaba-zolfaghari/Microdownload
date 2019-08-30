using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microdownload.Entities;
using Microdownload.Entities.AuditableEntity;
using Microdownload.Entities.Identity;

namespace Microdownload.ViewModels
{
    public class InstituteRequestViewModel : IAuditableEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="فیلد {0} مورد نیاز است")]
        [Display(Name ="نوع درخواست")]
        public RequestStatus RequestStatus { get; set; }

        [Display(Name = "جزئیات")]
        public string Description { get; set; }


        [Display(Name = "فایل پروانه فعالیت/درخواست")]
        public string RegisterdFile { get; set; }


        [Required(ErrorMessage = "فیلد {0} مورد نیاز است")]
        [Display(Name = "دروس درخواستی برای آموزش")]
        public string RequestedCourse { get; set; }


        public int UserId { get; set; }

        public virtual User User { get; set; }
    
    }
}
