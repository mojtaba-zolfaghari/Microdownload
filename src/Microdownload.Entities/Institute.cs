using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microdownload.Entities.Identity;

namespace Microdownload.Entities
{
    public class Institute
    {
        public int Id { get; set; }

        public string InstituteName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public InstituteType InstituteType { get; set; }
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
    public enum InstituteType
    {

        [Display(Name = "ثبت اولیه")]
        _FirstRegistration = 1,
        [Display(Name = "حذف شده")]
        _Removed = 2,
        [Display(Name = "فعال")]
        _Actived = 3,
    }
}