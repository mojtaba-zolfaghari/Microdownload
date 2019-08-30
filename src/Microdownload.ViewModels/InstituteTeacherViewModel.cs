using System;
using System.Collections.Generic;
using System.Text;
using Microdownload.Entities;

namespace Microdownload.ViewModels
{
    public class InstituteTeacherViewModel
    {
        public int? Id { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }


        public int InstituteId { get; set; }
        public Institute Institute { get; set; }
    }
}
