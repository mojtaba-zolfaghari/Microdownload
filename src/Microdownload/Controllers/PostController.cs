using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNTBreadCrumb.Core;
using Microsoft.AspNetCore.Mvc;

namespace Microdownload.Controllers
{
    [BreadCrumb(Title = "نمایش پست", UseDefaultRouteUrl = true, Order = 0)]

    public class PostController : Controller
    {
        [BreadCrumb(Title = "ایندکس", Order = 1)]

        public IActionResult Index()
        {
            return View();
        }
    }
}