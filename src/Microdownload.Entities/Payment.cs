using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Microdownload.Entities
{
    public class Payment
    {
        public Payment()
        {
            InsertDatetime = System.DateTimeOffset.Now;
        }
        public long PaymentId { get; set; }

        public string ReferenceNumber { get; set; }

        public long SaleReferenceId { get; set; }

        public string StatusPayment { get; set; }

        public bool PaymentFinished { get; set; }

        public long Amount { get; set; }

        public string BankName { get; set; }

        public int UserId { get; set; }

        public PaymentType PaymentType { get; set; }

        public int FactorId { get; set; }

        public DateTimeOffset? InsertDatetime { get; set; }
    }

    public enum PaymentType
    {

        [Display(Name = "اشتراک سالانه")]
        Annualcredit = 1,
        [Display(Name = "خرید کوپن تخفیف")]
        DiscountFactor = 2,

        [Display(Name = "خرید محصول")]
        ProductFactor = 3,
        [Display(Name = "شارژ کیف پول")]
        WalletCharge = 4
    }


}
