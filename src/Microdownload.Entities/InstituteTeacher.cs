using System;
using System.Collections.Generic;
using System.Text;
using Microdownload.Entities.AuditableEntity;
using Microdownload.Entities.Identity;

namespace Microdownload.Entities
{
    public class InstituteTeacher : IAuditableEntity
    {
        public int Id { get; set; }

        public int InstituteId { get; set; }
        public Institute Institute { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

    }
}
