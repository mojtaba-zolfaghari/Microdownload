using Microdownload.Entities.AuditableEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microdownload.Entities
{
   public class SlideShowImage: IAuditableEntity
    {
        public SlideShowImage()
        {
            CreatedDate = DateTimeOffset.Now; ;
        }
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
        public int Order { get; set; }
        public DateTimeOffset CreatedDate { get; set; }

    }
}
