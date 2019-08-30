using Microdownload.Entities.AuditableEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microdownload.Entities
{
    public class Cards : IAuditableEntity
    {
        public int Id { get; set; }

        public string ActiveCode { get; set; }

        public int? UserId { get; set; }

        public DateTimeOffset? DateStartUse { get; set; }


    }
}
