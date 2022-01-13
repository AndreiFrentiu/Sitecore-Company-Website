using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Mvc;
using Sitecore.Mvc.Presentation;
using SitecoreCompanyWebsite.Feature.PageContent.Models.Glass_Mapper.Global_Templates;
using SitecoreCompanyWebsite.Feature.PageContent.Models.Glass_Mapper.Page_Templates.AboutUs_Page;
using System;
using System.Web.Mvc;

namespace SitecoreCompanyWebsite.Feature.PageContent.Controllers.Pages
{
    [Obsolete]
    public class SitecoreAboutUsController : GlassController
    {
        public ActionResult GetMainPage()
        {
            return View();
        }

        public ActionResult GetStatistics()
        {
            return View();
        }

        public ActionResult GetDetail()
        {
            var context = new SitecoreContext();
            var dataSourceItem = Sitecore.Context.Database.GetItem(RenderingContext.CurrentOrNull.Rendering.DataSource);
            return View(context.Cast<ISamplePart>(dataSourceItem));
        }

        public ActionResult GetDetailList()
        {
            var context = new SitecoreContext();
            var dataSourceItem = Sitecore.Context.Database.GetItem(RenderingContext.CurrentOrNull.Rendering.DataSource);
            return View(context.Cast<IListOfSamplePart>(dataSourceItem));
        }

        public ActionResult GetEmployees()
        {
            var context = new SitecoreContext();
            var dataSourceItem = Sitecore.Context.Database.GetItem(RenderingContext.CurrentOrNull.Rendering.DataSource);
            return View(context.Cast<IListOfEmployees>(dataSourceItem));
        }
    }
}