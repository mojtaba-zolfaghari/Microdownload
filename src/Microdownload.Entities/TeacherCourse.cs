using System.Collections.Generic;
using Microdownload.Entities.AuditableEntity;
using Microdownload.Entities.Identity;

namespace Microdownload.Entities
{
    public class TeacherCourse : IAuditableEntity
    {
        public int Id { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public int CoursesId { get; set; }
        public Courses Courses { get; set; }



    }
}