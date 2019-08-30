using Microdownload.Entities.AuditableEntity;
using Microdownload.Entities.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Microdownload.Entities
{
    public class Student : IAuditableEntity
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public string MeliCode { get; set; }
        public string ReffrerrId { get; set; }

        public GradeType GradeType { get; set; }
        public string MajorName { get; set; }
        //لیست دوره های دانش آموز
        public virtual ICollection<CoursesStudent> CoursesStudent { get; set; }

        //لیست آموزشگاه هایی که دانش آموز در آنها دوره برداشته است
        public virtual ICollection<InstituteStudent> InstituteStudent { get; set; }


    }
    public enum GradeType
    {

        [Display(Name = "دبستان")]
        _School = 1,
        [Display(Name = "دبیرستان")]
        _HighSchool = 2,
        [Display(Name = "کنکور")]
        _Konkoor = 3,
        [Display(Name = "کاردانی")]
        _FirstGraduate = 4,
        [Display(Name = "کارشناسی")]
        _UnderGraduate = 5,
        [Display(Name = "کارشناسی ارشد")]
        _Graduate = 6,
        [Display(Name = "دکترا")]
        _PHD = 7,
        [Display(Name = "شاغل")]
        _Employed = 7,
    }

}
