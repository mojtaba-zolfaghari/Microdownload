using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microdownload.Entities.AuditableEntity;
using Microdownload.Entities.Identity;

namespace Microdownload.Entities
{
    public class Courses : IAuditableEntity
    {
        public Courses()
        {
            CreatedDate = DateTimeOffset.Now;
        }
        public int Id { get; set; }

        public string CourseName { get; set; }

        public DateTimeOffset? StartDate { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string ImageUrl { get; set; }


        public string Link { get; set; }

        public long Price { get; set; }

        public CourseStatus CourseStatus { get; set; }


        //آموزشگاه برگزار کننده دوره

        public virtual ICollection<InstituteCourse> InstituteCourse { get; set; }


        //مدرس برگزار کننده دوره
        public virtual ICollection<TeacherCourse> TeacherCourse { get; set; }


        //لیست دانش آموزان دوره
        public virtual ICollection<CoursesStudent> CoursesStudent { get; set; }




    }


    public enum CourseStatus
    {

        [Display(Name = "ثبت اولیه")]
        _FirstRegisteration = 1,
        [Display(Name = "حذف شده")]
        _Removed = 2,
        [Display(Name = "مشخص شدن زمان شروع")]
        _Started = 3,
        [Display(Name = "در حال برگزاری")]
        _Running = 4,
        [Display(Name = "به پایان رسیده")]
        _Completed = 5
    }
}
