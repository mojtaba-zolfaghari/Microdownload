using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Microdownload.ViewModels.Identity
{
    public class RoleViewModel
    {
        [HiddenInput]
        public string Id { set; get; }

        [Required(ErrorMessage = "(*)")]
        [Display(Name = "نام نقش")]
        public string Name { set; get; }
        [Required(ErrorMessage = "(*)")]
        [Display(Name = "درجه")]

        public int Degree { get; set; }
    }
}