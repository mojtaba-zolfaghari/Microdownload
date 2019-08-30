using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Microdownload.ViewModels
{
   public class PortalSettingViewModel
    {
        [DisplayName("آدرس سایت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]

        public string SiteUrl { get; set; }

        [DisplayName("نام سایت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string SiteName { get; set; }

        [DisplayName("کد درگاه پرداخت زرین پال")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]

        public string ZarinPalCode { get; set; }

        [DisplayName("هزینه اشتراک سالانه ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]

        public int SubscriptionFee { get; set; }


        [DisplayName("تعداد دوره ها در صفحه اصلی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]

        public string GetTopCourse { get; set; }


        [DisplayName("تعداد آموزشگاه ها در صفحه اصلی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]

        public string GetTopInstitute { get; set; }

        





        [DisplayName("مالیات ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int Tax { get; set; }


        [DisplayName("کلمات کلیدی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]

        [DataType(DataType.MultilineText)]
        public string SiteKeywords { get; set; }

        [DisplayName("توضیحات")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]

        [DataType(DataType.MultilineText)]
        public string SiteDescription { get; set; }

        [DisplayName("متن کپی رایت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]

        [DataType(DataType.MultilineText)]
        public string CopyRight { get; set; }


        [DisplayName("آدرس فیسبوک")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string facebook { get; set; }

        [DisplayName("آدرس توییتر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string twitter { get; set; }

        [DisplayName("آدرس گوگل پلاس")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string googleplus { get; set; }


        [DisplayName("آدرس یوتیوب")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string youtube { get; set; }


        [DisplayName("آدرس لینکدین")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string linkedin { get; set; }


        [DisplayName("آدرس آر اس اس")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string rss { get; set; }


        [DisplayName("آدرس اینستگرام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Instagram { get; set; }


        [DisplayName("آدرس تلگرام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Telegram { get; set; }

        [DisplayName("آدرس دفتر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string OfficeAddress { get; set; }


        [DisplayName("تلفن دفتر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string OfficePhone { get; set; }

        [DisplayName("ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Email { get; set; }

        [DisplayName("آدرس آپارات")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Aparat { get; set; }

        [DisplayName("متن بالای سایت")]
        public string Top { get; set; }

        [DisplayName("عنوان لینک یک فوتر")]
        public string FooterLinkTitle1 { get; set; }


        [DisplayName("عنوان لینک دو فوتر")]
        public string FooterLinkTitle2 { get; set; }


        [DisplayName("عنوان لینک سه فوتر")]
        public string FooterLinkTitle3 { get; set; }


        [DisplayName("عنوان لینک چهار فوتر")]
        public string FooterLinkTitle4 { get; set; }

        [DisplayName("عنوان لینک پنج فوتر")]
        public string FooterLinkTitle5 { get; set; }


        [DisplayName("عنوان لینک شش فوتر")]
        public string FooterLinkTitle6 { get; set; }


        [DisplayName("عنوان لینک هفت فوتر")]
        public string FooterLinkTitle7 { get; set; }


        [DisplayName("عنوان لینک هشت فوتر")]
        public string FooterLinkTitle8 { get; set; }

        [DisplayName("عنوان لینک نه فوتر")]
        public string FooterLinkTitle9 { get; set; }


        [DisplayName("عنوان لینک ده فوتر")]
        public string FooterLinkTitle10 { get; set; }


        [DisplayName("لینک یک فوتر")]
        public string FooterLink1 { get; set; }


        [DisplayName("لینک دو فوتر")]
        public string FooterLink2 { get; set; }


        [DisplayName("لینک سه فوتر")]
        public string FooterLink3 { get; set; }


        [DisplayName("لینک چهار فوتر")]
        public string FooterLink4 { get; set; }

        [DisplayName("لینک پنج فوتر")]
        public string FooterLink5 { get; set; }


        [DisplayName("لینک شش فوتر")]
        public string FooterLink6 { get; set; }


        [DisplayName("لینک هفت فوتر")]
        public string FooterLink7 { get; set; }


        [DisplayName("لینک هشت فوتر")]
        public string FooterLink8 { get; set; }

        [DisplayName("لینک نه فوتر")]
        public string FooterLink9 { get; set; }


        [DisplayName("لینک ده فوتر")]
        public string FooterLink10 { get; set; }

    }
}
