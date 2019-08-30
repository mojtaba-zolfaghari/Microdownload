using System;
using AutoMapper;
using DNTCaptcha.Core;
using DNTCommon.Web.Core;
using Microdownload.Areas.Panel;
using Microdownload.DataLayer.Context;
using Microdownload.IocConfig;
using Microdownload.Services.Identity.Logger;
using Microdownload.ViewModels.Identity.Settings;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NonFactors.Mvc.Grid;
using NToastNotify;


namespace Microdownload
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<SiteSettings>(options => Configuration.Bind(options));

            // Adds all of the ASP.NET Core Identity related services and configurations at once.
            services.AddCustomIdentityServices();

            var siteSettings = services.GetSiteSettings();
            services.AddRequiredEfInternalServices(siteSettings); // It's added to access services from the dbcontext, remove it if you are using the normal `AddDbContext` and normal constructor dependency injection.
            services.AddDbContextPool<ApplicationDbContext>((serviceProvider, optionsBuilder) =>
            {
                optionsBuilder.SetDbContextOptions(siteSettings);
                optionsBuilder.UseInternalServiceProvider(serviceProvider); // It's added to access services from the dbcontext, remove it if you are using the normal `AddDbContext` and normal constructor dependency injection.
            });
            services.AddMvc(options =>
            {
                options.UseYeKeModelBinder();
                options.AllowEmptyInputInBodyModelBinding = true;
                // options.Filters.Add(new NoBrowserCacheAttribute());
            }).AddJsonOptions(jsonOptions =>
            {
                jsonOptions.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            }).AddNToastNotifyNoty(new NotyOptions
            {
                ProgressBar = true,
                Timeout = 5000
            })
            .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDNTCommonWeb();
            services.AddDNTCaptcha();
            services.AddCloudscribePagination();

            services.AddMvcGrid(filters => filters.Register(typeof(Int32), "contains", typeof(NumberContainsFilter)));
            services.AddHttpContextAccessor();

            services.AddAutoMapper();

        }

        public void Configure(
            ILoggerFactory loggerFactory,
            IApplicationBuilder app,
            IHostingEnvironment env)
        {
            loggerFactory.AddDbLogger(serviceProvider: app.ApplicationServices, minLevel: LogLevel.Warning);

            if (!env.IsDevelopment())
            {
                app.UseHsts();
            }

            app.UseExceptionHandler("/error/index/500");
            app.UseStatusCodePagesWithReExecute("/error/index/{0}");

            app.UseStaticHttpContext();
            app.UseHttpsRedirection();

            app.UseNToastNotify();
            // Serve wwwroot as root
            app.UseFileServer(new FileServerOptions
            {
                // Don't expose file system
                EnableDirectoryBrowsing = false
            });

            // Adds all of the ASP.NET Core Identity related initializations at once.
            app.UseCustomIdentityServices();
            app.UseCookiePolicy();

            // app.UseNoBrowserCache();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "RateInquiryR",
                    template: "{area:exists}/RateInquiry/{type}",
                    defaults: new { area = AreaConstants.PanelArea, controller = "RateInquiry", action = "Index" });

                routes.MapRoute(
                    name: "Link",
                    template: "Link/{type}",
                    defaults: new { controller = "Home", action = "Link" });

                routes.MapRoute(
                    name: "areas",
                    template: "{area:exists}/{controller=Account}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "Wage",
                    template: "{area:exists}/{controller=Wage}/{action=Wage}/{Id}/{UserId?}/{year}/{month}/{page?}/{rows?}");
                routes.MapRoute(
                    name: "WageDetail",
                    template: "{area:exists}/{controller=Financial}/{action=WageDetail}/{SumMellatInsWageId}/{Username?}/{page?}/{rows?}");

                routes.MapRoute(
                                    name: "RouteReferrer",
                                    template: "ref/{UserName?}",
                                    defaults: new { area = "", controller = "Register", action = "Index" }
                                );

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}