using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microdownload.Services;
using Microsoft.AspNetCore.Mvc;

namespace Microdownload.Areas.Panel.ViewComponents
{
    public class HomePageCourseViewComponent : ViewComponent
    {
        private readonly IPortalSettingService _settingService;

        public HomePageCourseViewComponent(IPortalSettingService settingService)
        {
            _settingService = settingService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _settingService.GetSettingsForEdit().ConfigureAwait(false);
            return View(viewName: "~/Areas/Panel/Views/Shared/Components/HomePageCourse/Default.cshtml", model: model);
        }
    }
}
