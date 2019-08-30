using System.Collections.Generic;
using System.Threading.Tasks;
using Microdownload.Entities.Identity;
using System.Security.Claims;
using Microdownload.ViewModels.Identity;

namespace Microdownload.Services.Contracts.Identity
{
    public interface ISiteStatService
    {
        Task<List<User>> GetOnlineUsersListAsync(int numbersToTake, int minutesToTake);

        Task<List<User>> GetTodayBirthdayListAsync();

        Task UpdateUserLastVisitDateTimeAsync(ClaimsPrincipal claimsPrincipal);

        Task<AgeStatViewModel> GetUsersAverageAge();
    }
}