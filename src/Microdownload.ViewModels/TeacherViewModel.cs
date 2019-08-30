using System;
using System.Collections.Generic;
using System.Text;
using Microdownload.Entities;
using Microdownload.Entities.Identity;

namespace Microdownload.ViewModels
{
    public class TeacherViewModel
    {
        public int? Id { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }



        //آموزشگاه
        public virtual ICollection<InstituteTeacher> InstituteTeacher { get; set; }
        public int[] InstituteTeacherIdes { get; set; }



        //دوره های مدرس و دانش آموزان مدرس 
        public virtual ICollection<TeacherCourseViewModel> TeacherCourse { get; set; }
        public int[] TeacherCourseIdes { get; set; }

    }
}
