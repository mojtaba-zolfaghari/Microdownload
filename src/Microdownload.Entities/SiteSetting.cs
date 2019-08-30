using Microdownload.Entities.Identity;
using Microdownload.Entities.AuditableEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microdownload.Entities
{
    public class SiteSetting : IAuditableEntity
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
