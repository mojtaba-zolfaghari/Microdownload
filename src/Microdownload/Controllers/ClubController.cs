using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNTBreadCrumb.Core;
using Microsoft.AspNetCore.Mvc;

namespace Microdownload.Controllers
{
    [BreadCrumb(Title = "باشگاه مشتریان", UseDefaultRouteUrl = true, Order = 0, GlyphIcon = "icon-home")]
    public class ClubController : Controller
    {
        [BreadCrumb(Title = "ایندکس", Order = 1, GlyphIcon = "icon-home")]
        public IActionResult Index()
        {
            return View();
        }
    }
}