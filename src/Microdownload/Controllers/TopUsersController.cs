using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNTBreadCrumb.Core;
using Microsoft.AspNetCore.Mvc;

namespace Microdownload.Controllers
{
    [BreadCrumb(Title = "نمایندگان برتر بیمه های زندگی", UseDefaultRouteUrl = true, Order = 0, GlyphIcon = "icon-home")]

    public class TopUsersController : Controller
    {
        [BreadCrumb(Title = "ایندکس", Order = 1, GlyphIcon = "icon-home")]

        public IActionResult Index()
        {
            return View();
        }
    }
}