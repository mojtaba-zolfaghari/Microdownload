using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using DNTBreadCrumb.Core;
using Microdownload.Services.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Microdownload.Areas.Panel.Controllers
{
    [Area(AreaConstants.PanelArea)]
    [Authorize(Policy = ConstantPolicies.DynamicPermission)]
    [BreadCrumb(Title = "نمایندگان برتر", UseDefaultRouteUrl = true, Order = 0)]
    [DisplayName("نمایندگان برتر")]

    public class TopUsersController : Controller
    {
        [BreadCrumb(Title = "ایندکس", Order = 1)]
        [DisplayName("ایندکس")]

        public IActionResult Index()
        {
            return View();
        }
    }
}