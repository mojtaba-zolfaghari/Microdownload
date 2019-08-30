using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microdownload.Entities.AuditableEntity;
using Microdownload.Entities.Identity;

namespace Microdownload.Entities
{
    public class InstituteRequest : IAuditableEntity
    {
        public int Id { get; set; }

        public  RequestStatus RequestStatus { get; set; }

        public string Description { get; set; }

        public string RegisterdFile { get; set; }

        public string RequestedCourse { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }


    }


    public enum RequestStatus
    {
        [Display(Name = "رد شده")]
        _RequestDenied = 1,
        [Display(Name = "پذیرفته شده")]
        _RequestAccepted = 2,
        [Display(Name = "در حال انتظار برای بررسی")]
        _Requested = 3,
    }

}
