using Microdownload.Entities.Identity;

namespace Microdownload.ViewModels.Identity
{
    public class RoleAndUsersCountViewModel
    {
        public Role Role { set; get; }
        public int UsersCount { set; get; }
        public int Degree { get; set; }

    }
}