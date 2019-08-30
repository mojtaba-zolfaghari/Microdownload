using System.Threading.Tasks;
using Microdownload.Common.GuardToolkit;
using Microdownload.Common.IdentityToolkit;
using Microdownload.Services.Contracts.Identity;
using Microdownload.Services.Identity;
using Microdownload.ViewModels.Identity;
using DNTBreadCrumb.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microdownload.Areas.Panel;

namespace Microdownload.Areas.Panel.Controllers
{
    [AllowAnonymous]
    [Area(AreaConstants.PanelArea)]
    [BreadCrumb(Title = "برگه‌ی کاربری", UseDefaultRouteUrl = true, Order = 0)]
    public class UserCardController : Controller
    {
        private readonly IApplicationUserManager _userManager;
        private readonly IApplicationRoleManager _roleManager;

        public UserCardController(
            IApplicationUserManager userManager,
            IApplicationRoleManager roleManager)
        {
            _userManager = userManager;
            _userManager.CheckArgumentIsNull(nameof(_userManager));

            _roleManager = roleManager;
            _roleManager.CheckArgumentIsNull(nameof(_roleManager));
        }

        [BreadCrumb(Title = "ایندکس", Order = 1)]
        public async Task<IActionResult> Index(int? id)
        {
            if (!id.HasValue && User.Identity.IsAuthenticated)
            {
                id = User.Identity.GetUserId<int>();
            }

            if (!id.HasValue)
            {
                return View("Error");
            }
            var cuRole = _roleManager.GetRolesForCurrentUser();
            var d = 0;
            foreach (var item in cuRole)
            {
                if (item.Degree > d)
                {
                    d = item.Degree;
                }
            }
            if (User.IsInRole(ConstantRoles.Admin))
            {
                d = 0;
            }
            ViewData["d"] = d;

            var user = await _userManager.FindByIdIncludeUserRolesAsync(id.Value);
            if (user == null)
            {
                return View("NotFound");
            }
            var md = _roleManager.GetRolesForUser(id.Value);
            var model= new UserCardItemViewModel
            {
                User = user,
                ShowAdminParts = User.IsInRole(ConstantRoles.Admin),
                Roles = await _roleManager.GetAllCustomRolesAsync(),
                ActiveTab = UserCardItemActiveTab.UserInfo
            };
            return View(model);
        }

        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> EmailToImage(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }

            var fileContents = await _userManager.GetEmailImageAsync(id);
            return new FileContentResult(fileContents, "image/png");
        }

        [BreadCrumb(Title = "لیست نمایندگان آنلاین", Order = 1)]
        public IActionResult OnlineUsers()
        {
            return View();
        }
    }
}