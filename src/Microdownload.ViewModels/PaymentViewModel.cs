using Microdownload.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Microdownload.ViewModels
{
    public class PaymentViewModel
    {
        public PaymentViewModel()
        {
            InsertDatetime = System.DateTimeOffset.Now;
        }
        [Key]
        [Display(Name = "آی دی جدول")]
        public long PaymentId { get; set; }

        [Display(Name = "شماره پیگیری")]
        [MaxLength(100)]
        public string ReferenceNumber { get; set; }

        [Display(Name = "شماره پرداخت")]
        public long SaleReferenceId { get; set; }

        [Display(Name = "وضعیت پرداخت")]
        [MaxLength(100)]
        public string StatusPayment { get; set; }

        [Display(Name = "وضعیت پرداخت نهایی")]
        public bool PaymentFinished { get; set; }

        [Display(Name = "مبلغ")]
        public long Amount { get; set; }

        [Display(Name = "نام بانک")]
        [MaxLength(50)]
        public string BankName { get; set; }

        [Display(Name = "آی دی کاربر")]
        public int UserId { get; set; }

        [Display(Name = "نوع تراکنش")]

        public PaymentType PaymentType { get; set; }
        [Display(Name = "آی دی فاکتور")]

        public int FactorId { get; set; }

        [Display(Name = "تاریخ خرید")]
        public DateTimeOffset? InsertDatetime { get; set; }


    }
}
