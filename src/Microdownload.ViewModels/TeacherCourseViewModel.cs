using System;
using System.Collections.Generic;
using System.Text;
using Microdownload.Entities;
using Microdownload.Entities.AuditableEntity;

namespace Microdownload.ViewModels
{
    public class TeacherCourseViewModel : IAuditableEntity
    {
        public int Id { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public int CoursesId { get; set; }
        public Courses Courses { get; set; }
    }
}