using Microdownload.Entities.AuditableEntity;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace Microdownload.Entities.Identity
{
    /// <summary>
    /// More info: http://www.dotnettips.info/post/2577
    /// and http://www.dotnettips.info/post/2578
    /// plus http://www.dotnettips.info/post/2559
    /// </summary>
    public class User : IdentityUser<int>, IAuditableEntity
    {
        public User()
        {
            UserUsedPasswords = new HashSet<UserUsedPassword>();
            UserTokens = new HashSet<UserToken>();
        }

        [StringLength(450)]
        public string FirstName { get; set; }

        [StringLength(450)]
        public string LastName { get; set; }

        [NotMapped]
        public string DisplayName
        {
            get
            {
                var displayName = $"{FirstName} {LastName}";
                return string.IsNullOrWhiteSpace(displayName) ? UserName : displayName;
            }
        }
        public int RegistrarId { get; set; }

        [StringLength(450)]
        public string PhotoFileName { get; set; }

        public DateTimeOffset? BirthDate { get; set; }

        public DateTimeOffset? CreatedDateTime { get; set; }

        public DateTimeOffset? LastVisitDateTime { get; set; }

        public bool IsEmailPublic { get; set; }

        public string Location { set; get; }

        public bool IsActive { get; set; } = true;

        public string BankCardNumber { set; get; }

        public string BankAccountNumber { set; get; }

        public string ShabaNumber { set; get; }

        public string PostalCode { set; get; }
        public string MeliCode { set; get; }

        public string Referrer { get; set; }

        public DateTimeOffset? StartCharge { get; set; }

        public DateTimeOffset? EndCharge { get; set; }

        public virtual ICollection<UserUsedPassword> UserUsedPasswords { get; set; }

        public virtual ICollection<UserToken> UserTokens { get; set; }

        public virtual ICollection<UserRole> Roles { get; set; }

        public virtual ICollection<UserLogin> Logins { get; set; }

        public virtual ICollection<UserClaim> Claims { get; set; }

       // public virtual ICollection<Payment> Payments { get; set; }

       // public virtual ICollection<Wallet> Wallet { get; set; }
       // public virtual Institute Institute { get; set; }
       // public virtual ICollection<Courses> Courses { get; set; }
       // public virtual ICollection<Teacher> Teachers { get; set; }


    }
}