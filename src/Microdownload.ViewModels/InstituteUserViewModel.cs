using System;
using System.Collections.Generic;
using System.Text;
using Microdownload.Entities.Identity;
using Microdownload.Entities;

namespace Microdownload.ViewModels
{
    public class InstituteUserViewModel
    {
        public int Id { get; set; }
        public  User User { get; set; }

        public  Institute Institute { get; set; }
    }
}
