using System;
using System.Collections.Generic;
using System.Text;

namespace Microdownload.Entities
{
    public class InstituteCourse
    {
        public int Id { get; set; }

        public int InstituteId { get; set; }
        public Institute Institute { get; set; }

        public int CoursesId { get; set; }
        public Courses Courses { get; set; }
    }
}
