using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microdownload.Entities.AuditableEntity;
using Microdownload.Entities.Identity;

namespace Microdownload.Entities
{
    public class TeacherRequest: IAuditableEntity
    {
        public int Id { get; set; }

        public  RequestResponseStatus RequestResponseStatus { get; set; }

        public string Description { get; set; }

        public string ResumeFile { get; set; }

        public string RequestedLesson { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }


    }


    public enum RequestResponseStatus
    {
        [Display(Name = "رد شده")]
        _RequestDenied = 1,
        [Display(Name = "پذیرفته شده")]
        _RequestAccepted = 2,
        [Display(Name = "در حال انتظار برای بررسی")]
        _Requested = 3,
    }

}
