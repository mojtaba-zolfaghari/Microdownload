using Microdownload.Entities;
using Microdownload.Entities.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Microdownload.ViewModels
{
   public class WalletViewModel
    {
        public WalletViewModel()
        {
            Tdate = System.DateTimeOffset.Now;
        }
        [HiddenInput]
        public int? Id { get; set; }

        [DisplayName("مبلغ ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int Amount { get; set; }

        [DisplayName("نوع تراکنش")]
        public WalletTransactionType  TType { get; set; }



        [DisplayName("تاریخ تراکنش")]
        public DateTimeOffset? Tdate { get; set; }


        [DisplayName("توضیحات")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }


        [DisplayName("آی دی کاربر")]
        public int UserId { get; set; }

        [DisplayName("کاربر")]
        public User User { get; set; }
    }
}
