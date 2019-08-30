using cloudscribe.Web.Pagination;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microdownload.ViewModels
{
    public class PagingViewModel<T>
    {
        public PagingViewModel()
        {
            Paging = new PaginationSettings();
        }


        public List<T> List { get; set; }

        public PaginationSettings Paging { get; set; }
    }
}
