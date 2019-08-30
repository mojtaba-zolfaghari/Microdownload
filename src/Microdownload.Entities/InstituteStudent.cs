using Microdownload.Entities.AuditableEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Microdownload.Entities
{
    public class InstituteStudent : IAuditableEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int InstituteId { get; set; }
        public Institute Institute { get; set; }
        [Required]
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
