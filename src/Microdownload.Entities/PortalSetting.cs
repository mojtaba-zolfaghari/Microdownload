using Microdownload.Entities.AuditableEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microdownload.Entities
{
    public class PortalSetting : IAuditableEntity
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
