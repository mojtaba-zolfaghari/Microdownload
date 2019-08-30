
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microdownload.Areas.Panel
{
    public static class AdminSetting
    {
        /// <summary>
        /// Base Address
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static string BaseAddress(Microsoft.AspNetCore.Http.HttpContext context)
        {
            var host = $"{context.Request.Scheme}://{context.Request.Host}";

            return host;
        }


    }
}
