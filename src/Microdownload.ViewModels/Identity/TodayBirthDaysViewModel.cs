using System.Collections.Generic;
using Microdownload.Entities.Identity;

namespace Microdownload.ViewModels.Identity
{
    public class TodayBirthDaysViewModel
    {
        public List<User> Users { set; get; }

        public AgeStatViewModel AgeStat { set; get; }
    }
}