using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microdownload.Entities;
using Microdownload.Entities.Identity;

namespace Microdownload.ViewModels
{
    public class InstituteViewModel
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "فید {0} مورد نیاز است")]
        [Display(Name = "نام آموزشگاه")]
        public string InstituteName { get; set; }

        [Required(ErrorMessage = "فید {0} مورد نیاز است")]
        [Display(Name = "تلفن آموزشگاه")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "فید {0} مورد نیاز است")]
        [Display(Name = "آدرس آموزشگاه")]
        public string Address { get; set; }

        public InstituteType InstituteType { get; set; }

        [Required(ErrorMessage = "فید {0} مورد نیاز است")]
        [Display(Name = "توضیح  مختصر")]
        public string Description { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        //لیست دوره های آموزشگاه
        public virtual ICollection<InstituteCourse> InstituteCourse { get; set; }

        //لیست دانش آموزان آموزشگاه
        public virtual ICollection<InstituteStudent> InstituteStudent { get; set; }

        //لیست مدرسان آموزشگاه
        public virtual ICollection<InstituteTeacher> InstituteTeacher { get; set; }
    }
}

