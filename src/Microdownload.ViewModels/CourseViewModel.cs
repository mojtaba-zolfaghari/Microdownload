using System;
using System.Collections.Generic;
using System.Text;
using Microdownload.Entities.Identity;
using Microdownload.Entities;
using Microdownload.Entities.AuditableEntity;
using System.ComponentModel.DataAnnotations;

namespace Microdownload.ViewModels
{
    public class CourseViewModel : IAuditableEntity
    {
        public CourseViewModel()
        {
            CreatedDate = DateTimeOffset.Now;
        }
        public int? Id { get; set; }

        [Required(ErrorMessage = "فید {0} مورد نیاز است")]
        [Display(Name ="نام دوره")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "فید {0} مورد نیاز است")]
        [Display(Name = "تصویر دوره (836*484)")]
        public string ImageUrl { get; set; }


        [Display(Name = "تاریخ شروع")]
        public DateTimeOffset? StartDate { get; set; }

        [Display(Name = "تاریخ ایجاد دوره")]
        public DateTimeOffset CreatedDate { get; set; }


        [Required(ErrorMessage = "فید {0} مورد نیاز است")]
        [Display(Name = "لینک دوره")]
        public string Link { get; set; }

        [Required(ErrorMessage = "فید {0} مورد نیاز است")]
        [Display(Name = "قیمت  دوره به ریال")]
        public long Price { get; set; }


        [Display(Name = "وضعیت دوره")]
        public CourseStatus CourseStatus { get; set; }



        public int[] TeacherCourseIdes { get; set; }

        //آموزشگاه برگزار کننده دوره

        public virtual ICollection<InstituteCourse> InstituteCourse { get; set; }


        //مدرس برگزار کننده دوره
        public virtual ICollection<TeacherCourseViewModel> TeacherCourse { get; set; }


        //لیست دانش آموزان دوره
        public virtual ICollection<CoursesStudent> CoursesStudent { get; set; }



    }
}