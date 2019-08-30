using System;
using System.Collections.Generic;
using System.Text;
using Microdownload.Entities;

namespace Microdownload.ViewModels
{
    public class InstituteCourseViewModel
    {
        public int Id { get; set; }

        public int InstituteId { get; set; }
        public Institute Institute { get; set; }

        public int CoursesId { get; set; }
        public Courses Courses { get; set; }
    }
}
