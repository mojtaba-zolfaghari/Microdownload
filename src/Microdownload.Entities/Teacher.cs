using System.Collections.Generic;
using Microdownload.Entities.AuditableEntity;
using Microdownload.Entities.Identity;

namespace Microdownload.Entities
{
    public class Teacher : IAuditableEntity
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        //آموزشگاه
        public virtual ICollection<InstituteTeacher> InstituteTeacher { get; set; }

        //دوره های مدرس و دانش آموزان مدرس 
        public virtual ICollection<TeacherCourse> TeacherCourse { get; set; }

    }
}