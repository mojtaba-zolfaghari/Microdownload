using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNTBreadCrumb.Core;
using Microsoft.AspNetCore.Mvc;

namespace Microdownload.Controllers
{
    [BreadCrumb(Title = "درخواست همکاری", UseDefaultRouteUrl = true, Order = 0)]
    public class CooperationController : Controller
    {
        [BreadCrumb(Title = "ایندکس", Order = 1)]
        public IActionResult Index()
        {
            return View();
        }
    }
}