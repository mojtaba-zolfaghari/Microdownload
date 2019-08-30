using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Microdownload.ViewModels
{
   public class WalletChargeViewModel
    {
        [HiddenInput]
        public string Id { set; get; }

        [DisplayName("مبلغ درخواستی به تومان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "لطفا تنها از اعداد استفاده نمائید")]
        [StringLength(7, ErrorMessage = "{0} باید بیشتر از یک هزار تومان و کمتر از ده میلیون تومان باشند.", MinimumLength = 4)]

        public string Amount { get; set; }

    }
}
