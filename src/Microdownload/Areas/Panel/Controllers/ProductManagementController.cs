﻿using System;
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
    [Authorize(Policy = ConstantPolicies.DynamicPermission)]
    [Area(AreaConstants.PanelArea)]
    [BreadCrumb(Title = "مدیریت محصولات", UseDefaultRouteUrl = true, Order = 0)]
    [DisplayName("مدیریت محصولات")]


    public class ProductManagementController : Controller
    {
        [BreadCrumb(Title = "ایندکس", Order = 1)]
        [DisplayName("ایندکس")]

        public IActionResult Index()
        {
            return View();
        }
    }
}