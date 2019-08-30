using Microdownload.Entities.AuditableEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microdownload.Entities
{
   public class Pages : IAuditableEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public string PageDescription { get; set; }

        public string PageKeyword { get; set; }

    }
}
