using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microdownload.Services;
using Microdownload.Services.Contracts.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Microdownload.Areas.Panel.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly IPortalSettingService _settingService;

        public FooterViewComponent(IPortalSettingService settingService)
        {
            _settingService = settingService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _settingService.GetSettingsForEdit().ConfigureAwait(false);
            return View(viewName: "~/Areas/Panel/Views/Shared/Components/Footer/Default.cshtml", model: model);
        }
    }
}
