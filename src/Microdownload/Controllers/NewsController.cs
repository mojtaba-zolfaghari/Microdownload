using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNTBreadCrumb.Core;
using HtmlAgilityPack;
using Microdownload.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Microdownload.Controllers
{
    [BreadCrumb(Title = "اخبار بیمه ملت", UseDefaultRouteUrl = true, Order = 0)]

    public class NewsController : Controller
    {
        [BreadCrumb(Title = "ایندکس", Order = 1)]

        public IActionResult Index(int pageNumber = 1, int count = 5)
        {
            string CountPage="0";
            try
            {
                var urlmelat = "http://www.melat.ir/mellat?start=0";
                var webmelat = new HtmlWeb();
                var docmelat = webmelat.Load(urlmelat);
                var PCounter = docmelat.DocumentNode.SelectSingleNode("//p[contains(@class,'counter')]");

                CountPage = PCounter.InnerText.Replace("صفحه1 از", "").Trim();


            }
            catch
            { }

            string start = ((pageNumber - 1) * count).ToString();
            var model = new List<MelatNewsViewModel>();
            try
            {
                var urlmelatnews = "http://www.melat.ir/mellat?start=" + start;
                var webmelatnews = new HtmlWeb();
                var docmelatnews = webmelatnews.Load(urlmelatnews);
                var Posts = docmelatnews.DocumentNode.SelectNodes("//article[contains(@itemprop,'blogPost')]");
                foreach (var item in Posts)
                {
                    MelatNewsViewModel melatNewsViewModel = new MelatNewsViewModel();
                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(item.InnerHtml);


                    melatNewsViewModel.Title = doc.DocumentNode.SelectSingleNode("//h2").InnerText.Trim();
                    melatNewsViewModel.Link = "http://www.melat.ir" + doc.DocumentNode.SelectSingleNode("//h2//a").Attributes["href"].Value.Trim();
                    melatNewsViewModel.Published = doc.DocumentNode.SelectSingleNode("//dd[contains(@class,'published')]").InnerText.Trim();

                    try
                    {
                        var AllText = doc.DocumentNode.SelectNodes("//p");
                        foreach (var p in AllText)
                        {
                            melatNewsViewModel.Text += p.InnerText.Trim() + "\n";
                        }
                    }
                    catch
                    {
                        melatNewsViewModel.Text = "";
                    }

                    if (string.IsNullOrEmpty(melatNewsViewModel.Text.Trim()))
                    {
                        melatNewsViewModel.Text = melatNewsViewModel.Title;
                    }




                    try
                    {
                        melatNewsViewModel.ImgUrl = "http://www.melat.ir" + doc.DocumentNode.SelectSingleNode("//img").Attributes["src"].Value.Trim();
                    }
                    catch
                    {
                        melatNewsViewModel.ImgUrl = "";


                    }


                    model.Add(melatNewsViewModel);
                }



            }
            catch
            { }
            int pc = int.Parse(CountPage);
            PagingViewModel<MelatNewsViewModel> retmodel = new PagingViewModel<MelatNewsViewModel>();
            retmodel.List = model;
            retmodel.Paging.CurrentPage = pageNumber;
            retmodel.Paging.ItemsPerPage = count;
            retmodel.Paging.TotalItems = pc * count;

            return View(retmodel);
        }
    }
}