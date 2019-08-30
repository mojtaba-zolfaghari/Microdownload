using System;
using System.Collections.Generic;
using System.Text;
using Microdownload.Entities;
using Microdownload.Entities.Identity;

namespace Microdownload.ViewModels
{
    public class UserCourseViewModel
    {
        public int Id { get; set; }
        public  User User { get; set; }

        public  Courses Courses { get; set; }
    }
}
