using Microdownload.Entities.AuditableEntity;
using Microdownload.Entities.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Microdownload.Entities
{
    public class Wallet : IAuditableEntity
    {
        public Wallet()
        {
            Tdate = System.DateTimeOffset.Now;
        }
        public int Id { get; set; }

        public int Amount { get; set; }

        public WalletTransactionType TType { get; set; }

        public DateTimeOffset Tdate { get; set; }

        public string Description { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }


        


    }
    public enum WalletTransactionType
    {
        [Display(Name = "واریز به کیف پول")]
        Deposit = 1,
        [Display(Name = "برداشت از کیف پول")]
        Removal = 2,
        [Display(Name = " در انتظار تایید درخواست")]
        Waiting = 3,
        [Display(Name = "درخواست رد شده")]
        Rejected = 4,
        [Display(Name = "درخواست تایید شده و به حساب واریز گردید")]
        Approved = 5
    }
}
