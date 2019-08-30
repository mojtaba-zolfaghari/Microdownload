using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNTBreadCrumb.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Microdownload.Areas.Panel.Controllers
{
    [Area(AreaConstants.PanelArea)]
    [AllowAnonymous]
    [BreadCrumb(Title = "استعلام نرخ بیمه", UseDefaultRouteUrl = true, Order = 0)]

    public class RateInquiryController : Controller
    {
        public IActionResult Index(string type)
        {
            switch (type)
            {
                case "زندگی":
                    {
                        return Redirect("http://apps.mellatinsurance.com/ulcustomer/(S(rwcvhxy4gzahkmqefk1uz1r0))/Policy/ULCalculator.aspx");
                    }
                case "سپرده":
                    {
                        return Redirect("http://apps.mellatinsurance.com/depositelifecustomer/Policy/InsuranceInquiry.aspx");
                    }
                case "مستمری_زنان":
                    {
                        return Redirect("http://apps.mellatinsurance.com/hwannuitycustomer/Policy/InsuranceInquiry.aspx");
                    }
                case "تحصیل_فرزندان":
                    {
                        return Redirect("http://apps.mellatinsurance.com/EducationCustomer/Policy/InsuranceInquiry.aspx");
                    }
                case "ثالث":
                    {
                        return Redirect("http://apps.mellatinsurance.com/Automobile2010/Forms/estelam_sales.aspx");
                    }
                default:
                    return RedirectToAction("Index","Home");
            }
        }
    }
}