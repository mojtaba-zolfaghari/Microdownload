using System.ComponentModel.DataAnnotations;
using DNTCommon.Web.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microdownload.ViewModels.Identity
{
    public class UserProfileViewModel
    {
        public const string AllowedImages = ".png,.jpg,.jpeg,.gif";

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "کد کاربری")]
        //[Remote("ValidateUsernameForRegister", "Register",
        //    AdditionalFields = nameof(UserName) + "," + ViewModelConstants.AntiForgeryToken, HttpMethod = "POST")]

        public string UserName { get; set; }

        [Display(Name = "نام")]
        [Required(ErrorMessage = "(*)")]
        [StringLength(450)]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "(*)")]
        [StringLength(450)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        //[Remote("ValidateUsername", "UserProfile",
        //    AdditionalFields = nameof(UserName) + "," + ViewModelConstants.AntiForgeryToken + "," + nameof(Pid),
        //    HttpMethod = "POST")]
        [EmailAddress(ErrorMessage = "لطفا آدرس ایمیل معتبری را وارد نمائید.")]
        [Display(Name = "ایمیل")]
        public string Email { get; set; }

        [Display(Name = "تصویر")]
        [StringLength(maximumLength: 1000, ErrorMessage = "حداکثر طول آدرس تصویر 1000 حرف است.")]
        public string PhotoFileName { set; get; }

        [UploadFileExtensions(AllowedImages,
            ErrorMessage = "لطفا تنها یک تصویر " + AllowedImages + " را ارسال نمائید.")]
        [DataType(DataType.Upload)]
        public IFormFile Photo { get; set; }

        public int? DateOfBirthYear { set; get; }
        public int? DateOfBirthMonth { set; get; }
        public int? DateOfBirthDay { set; get; }

        [Display(Name = "آدرس")]
        public string Location { set; get; }

        [Display(Name = "نمایش عمومی ایمیل")]
        public bool IsEmailPublic { set; get; }

        [Display(Name = "فعال‌سازی اعتبار سنجی دو مرحله‌ای")]
        public bool TwoFactorEnabled { set; get; }

        public bool IsPasswordTooOld { set; get; }

        [HiddenInput]
        public string Pid { set; get; }

        [HiddenInput]
        public bool IsAdminEdit { set; get; }

        [Display(Name = "شماره کارت بانکی")]
        [StringLength(450)]
        public string BankCardNumber { set; get; }


        [Display(Name = "شماره حساب")]
        [StringLength(450)]
        public string BankAccountNumber { set; get; }


        [Display(Name = "شماره شبا حساب")]
        [StringLength(450)]
        public string ShabaNumber { set; get; }

        [Display(Name = "کد پستی")]
        [StringLength(450)]
        public string PostalCode { set; get; }


        [Display(Name = "شماره موبایل")]
        [StringLength(450)]
        public string PhoneNumber { set; get; }

        [Display(Name = "کد کاربری معرف")]
        [Required(ErrorMessage = " لطفا {0} را وارد کنید و در صورت عدم وجود معرف کد user5006 را بنویسید")]

        [StringLength(450)]
        public string Referrer { get; set; }
        [Display(Name = "آی دی ثبت نام کننده")]
        [Required(ErrorMessage = "(*)")]

        public int RegistrarId { get; set; }


    }
}