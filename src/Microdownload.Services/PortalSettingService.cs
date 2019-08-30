using Microdownload.DataLayer.Context;
using Microdownload.Entities;
using Microdownload.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Microdownload.Services
{
    public interface IPortalSettingService
    {
        Task<IdentityResult> UpdateSettingsAsync(PortalSettingViewModel settingsModel);

        Task<IdentityResult> InsertSettingsAsync();

        Task<PortalSettingViewModel> GetSettingsForEdit();
        Task<string> GetSiteName();
        Task<string> GetContactInfo();
        Task<SiteMetaTags> GetSiteMetaTags();
        PortalSettingViewModel GetSettings();


    }

    public class SiteFooterInfo
    {
        public string ContactInfo { get; set; }
    }

    public class SiteMetaTags
    {
        public string Keywords { get; set; }
        public string Description { get; set; }
    }


    public class PortalSettingService : IPortalSettingService
    {
        private readonly IUnitOfWork _UnitOfWork;
        private readonly DbSet<PortalSetting> _SiteOptions;

        public PortalSettingService(IUnitOfWork unitOfWork)
        {
            _UnitOfWork = unitOfWork;
            _SiteOptions = unitOfWork.Set<PortalSetting>();
        }

        public async Task<string> GetSiteName()
        {
            return (await GetSettingsForEdit()).SiteName;
        }

        public async Task<string> GetContactInfo()
        {
            return (await GetSettingsForEdit()).CopyRight;
        }

        public async Task<SiteMetaTags> GetSiteMetaTags()
        {
            return new SiteMetaTags
            {
                Keywords = (await GetSettingsForEdit()).CopyRight,
                Description = (await GetSettingsForEdit()).CopyRight
            };
        }

        public PortalSettingViewModel GetSettings()
        {
            throw new NotImplementedException();
        }

        public async Task<PortalSettingViewModel> GetSettingsForEdit()
        {
            var settings = await _SiteOptions.AsNoTracking().ToListAsync();

            var settingsViewModel = new PortalSettingViewModel
            {
                SiteUrl = settings.Find(option => option.Key == "SiteUrl")?.Value,
                SiteName = settings.Find(option => option.Key == "SiteName")?.Value,
                SiteKeywords = settings.Find(option => option.Key == "SiteKeywords")?.Value,
                SiteDescription = settings.Find(option => option.Key == "SiteDescription")?.Value,
                CopyRight = settings.Find(option => option.Key == "CopyRight")?.Value,
                SubscriptionFee = int.Parse(settings.Find(option => option.Key == "SubscriptionFee")?.Value),
                ZarinPalCode = settings.Find(option => option.Key == "ZarinPalCode")?.Value,
                GetTopCourse = settings.Find(option => option.Key == "GetTopCourse")?.Value,
                GetTopInstitute = settings.Find(option => option.Key == "GetTopInstitute")?.Value,


                Tax = int.Parse(settings.Find(option => option.Key == "Tax")?.Value),
                Aparat = settings.Find(option => option.Key == "Aparat")?.Value,
                Email = settings.Find(option => option.Key == "Email")?.Value,
                facebook = settings.Find(option => option.Key == "facebook")?.Value,
                googleplus = settings.Find(option => option.Key == "googleplus")?.Value,
                Instagram = settings.Find(option => option.Key == "Instagram")?.Value,
                linkedin = settings.Find(option => option.Key == "linkedin")?.Value,
                OfficeAddress = settings.Find(option => option.Key == "OfficeAddress")?.Value,
                OfficePhone = settings.Find(option => option.Key == "OfficePhone")?.Value,
                rss = settings.Find(option => option.Key == "rss")?.Value,
                Telegram = settings.Find(option => option.Key == "Telegram")?.Value,
                twitter = settings.Find(option => option.Key == "twitter")?.Value,
                youtube = settings.Find(option => option.Key == "youtube")?.Value,
                Top = settings.Find(option => option.Key == "Top")?.Value,
                FooterLink1 = settings.Find(option => option.Key == "FooterLink1")?.Value,
                FooterLink2 = settings.Find(option => option.Key == "FooterLink2")?.Value,
                FooterLink3 = settings.Find(option => option.Key == "FooterLink3")?.Value,
                FooterLink4 = settings.Find(option => option.Key == "FooterLink4")?.Value,
                FooterLink5 = settings.Find(option => option.Key == "FooterLink5")?.Value,
                FooterLink6 = settings.Find(option => option.Key == "FooterLink6")?.Value,
                FooterLink7 = settings.Find(option => option.Key == "FooterLink7")?.Value,
                FooterLink8 = settings.Find(option => option.Key == "FooterLink8")?.Value,
                FooterLink9 = settings.Find(option => option.Key == "FooterLink9")?.Value,
                FooterLink10 = settings.Find(option => option.Key == "FooterLink10")?.Value,
                FooterLinkTitle1 = settings.Find(option => option.Key == "FooterLinkTitle1")?.Value,
                FooterLinkTitle2 = settings.Find(option => option.Key == "FooterLinkTitle2")?.Value,
                FooterLinkTitle3 = settings.Find(option => option.Key == "FooterLinkTitle3")?.Value,
                FooterLinkTitle4 = settings.Find(option => option.Key == "FooterLinkTitle4")?.Value,
                FooterLinkTitle5 = settings.Find(option => option.Key == "FooterLinkTitle5")?.Value,
                FooterLinkTitle6 = settings.Find(option => option.Key == "FooterLinkTitle6")?.Value,
                FooterLinkTitle7 = settings.Find(option => option.Key == "FooterLinkTitle7")?.Value,
                FooterLinkTitle8 = settings.Find(option => option.Key == "FooterLinkTitle8")?.Value,
                FooterLinkTitle9 = settings.Find(option => option.Key == "FooterLinkTitle9")?.Value,
                FooterLinkTitle10 = settings.Find(option => option.Key == "FooterLinkTitle10")?.Value,
            };

            return settingsViewModel;
        }



        public async Task<IdentityResult> UpdateSettingsAsync(PortalSettingViewModel settingsModel)
        {
            var currentSettings = await _SiteOptions.ToListAsync();

            currentSettings.Find(s => s.Key == "SiteUrl").Value = settingsModel.SiteUrl;
            currentSettings.Find(s => s.Key == "SiteName").Value = settingsModel.SiteName;
            currentSettings.Find(s => s.Key == "SiteKeywords").Value = settingsModel.SiteKeywords;
            currentSettings.Find(s => s.Key == "SiteDescription").Value = settingsModel.SiteDescription;
            currentSettings.Find(s => s.Key == "ZarinPalCode").Value = settingsModel.ZarinPalCode;
            currentSettings.Find(s => s.Key == "SubscriptionFee").Value = settingsModel.SubscriptionFee.ToString();






            currentSettings.Find(s => s.Key == "Tax").Value = settingsModel.Tax.ToString();
            currentSettings.Find(s => s.Key == "Aparat").Value = settingsModel.Aparat;
            currentSettings.Find(s => s.Key == "Email").Value = settingsModel.Email;
            currentSettings.Find(s => s.Key == "facebook").Value = settingsModel.facebook;
            currentSettings.Find(s => s.Key == "googleplus").Value = settingsModel.googleplus;
            currentSettings.Find(s => s.Key == "Instagram").Value = settingsModel.Instagram;
            currentSettings.Find(s => s.Key == "linkedin").Value = settingsModel.linkedin;
            currentSettings.Find(s => s.Key == "OfficeAddress").Value = settingsModel.OfficeAddress;
            currentSettings.Find(s => s.Key == "OfficePhone").Value = settingsModel.OfficePhone;
            currentSettings.Find(s => s.Key == "rss").Value = settingsModel.rss;
            currentSettings.Find(s => s.Key == "Telegram").Value = settingsModel.Telegram;
            currentSettings.Find(s => s.Key == "twitter").Value = settingsModel.twitter;
            currentSettings.Find(s => s.Key == "youtube").Value = settingsModel.youtube;
            currentSettings.Find(s => s.Key == "Top").Value = settingsModel.Top;
            currentSettings.Find(s => s.Key == "GetTopCourse").Value = settingsModel.GetTopCourse;
            currentSettings.Find(s => s.Key == "GetTopInstitute").Value = settingsModel.GetTopInstitute;

            





            currentSettings.Find(s => s.Key == "FooterLink1").Value = settingsModel.FooterLink1;
            currentSettings.Find(s => s.Key == "FooterLink2").Value = settingsModel.FooterLink2;
            currentSettings.Find(s => s.Key == "FooterLink3").Value = settingsModel.FooterLink3;
            currentSettings.Find(s => s.Key == "FooterLink4").Value = settingsModel.FooterLink4;
            currentSettings.Find(s => s.Key == "FooterLink5").Value = settingsModel.FooterLink5;
            currentSettings.Find(s => s.Key == "FooterLink6").Value = settingsModel.FooterLink6;
            currentSettings.Find(s => s.Key == "FooterLink7").Value = settingsModel.FooterLink7;
            currentSettings.Find(s => s.Key == "FooterLink8").Value = settingsModel.FooterLink8;
            currentSettings.Find(s => s.Key == "FooterLink9").Value = settingsModel.FooterLink9;
            currentSettings.Find(s => s.Key == "FooterLink10").Value = settingsModel.FooterLink10;
            currentSettings.Find(s => s.Key == "FooterLinkTitle1").Value = settingsModel.FooterLinkTitle1;
            currentSettings.Find(s => s.Key == "FooterLinkTitle2").Value = settingsModel.FooterLinkTitle2;
            currentSettings.Find(s => s.Key == "FooterLinkTitle3").Value = settingsModel.FooterLinkTitle3;
            currentSettings.Find(s => s.Key == "FooterLinkTitle4").Value = settingsModel.FooterLinkTitle4;
            currentSettings.Find(s => s.Key == "FooterLinkTitle5").Value = settingsModel.FooterLinkTitle5;
            currentSettings.Find(s => s.Key == "FooterLinkTitle6").Value = settingsModel.FooterLinkTitle6;
            currentSettings.Find(s => s.Key == "FooterLinkTitle7").Value = settingsModel.FooterLinkTitle7;
            currentSettings.Find(s => s.Key == "FooterLinkTitle8").Value = settingsModel.FooterLinkTitle8;
            currentSettings.Find(s => s.Key == "FooterLinkTitle9").Value = settingsModel.FooterLinkTitle9;
            currentSettings.Find(s => s.Key == "FooterLinkTitle10").Value = settingsModel.FooterLinkTitle10;


            if (!string.IsNullOrWhiteSpace(settingsModel.CopyRight))
            {
                currentSettings.Find(s => s.Key == "CopyRight").Value = settingsModel.CopyRight.Replace(Environment.NewLine, "<br/>");
            }
            return IdentityResult.Success;
        }

        public async Task<IdentityResult> InsertSettingsAsync()
        {
            List<PortalSetting> PortalSetting = new List<PortalSetting>();
            PortalSetting.Add(new Entities.PortalSetting { Key = "SiteUrl", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "SiteName", Value = "سیستم آموزشگاه آنلاین" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "SiteKeywords", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "SiteKeywords", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "ZarinPalCode", Value = "1111" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "SubscriptionFee", Value = "1" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "C1", Value = "1" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "Aparat", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "Email", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "facebook", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "googleplus", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "Instagram", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "linkedin", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "OfficeAddress", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "OfficePhone", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "rss", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "Telegram", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "twitter", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "youtube", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "Top", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "FooterLink1", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "FooterLink2", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "FooterLink3", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "FooterLink4", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "FooterLink5", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "FooterLink6", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "FooterLink7", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "FooterLink8", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "FooterLink9", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "FooterLink10", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "FooterLinkTitle1", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "FooterLinkTitle2", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "FooterLinkTitle3", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "FooterLinkTitle4", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "FooterLinkTitle5", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "FooterLinkTitle6", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "FooterLinkTitle7", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "FooterLinkTitle8", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "FooterLinkTitle9", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "FooterLinkTitle10", Value = "Microdownload.ir" });
            PortalSetting.Add(new Entities.PortalSetting { Key = "CopyRight", Value = "Microdownload.ir" });

            await _SiteOptions.AddRangeAsync(PortalSetting);
            _UnitOfWork.SaveChanges();
            return IdentityResult.Success;

        }
    }

}
