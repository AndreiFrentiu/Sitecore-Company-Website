using System;
using System.Web.Mvc;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Mvc;
using Sitecore.Mvc.Presentation;
using SitecoreCompanyWebsite.Feature.PageContent.Models.Glass_Mapper.Global_Templates;
using SitecoreCompanyWebsite.Feature.PageContent.Models.Glass_Mapper.Page_Templates.Home_Page;

namespace WebApplication1.Controllers.Pages
{
    [Obsolete]
    public class SitecoreHomeController : GlassController
    {
        public ActionResult GetSlider()
        {
            var context = new SitecoreContext();
            var dataSourceItem = Sitecore.Context.Database.GetItem(RenderingContext.CurrentOrNull.Rendering.DataSource);
            return View(context.Cast<ISlider>(dataSourceItem));
        }

        public ActionResult GetCompanyInformation()
        {
            var context = new SitecoreContext();
            var dataSourceItem = Sitecore.Context.Database.GetItem(RenderingContext.CurrentOrNull.Rendering.DataSource);
            return View(context.Cast<ICompanyInformation>(dataSourceItem));
        }

        public ActionResult GetServices()
        {
            var context = new SitecoreContext();
            var dataSourceItem = Sitecore.Context.Database.GetItem(RenderingContext.CurrentOrNull.Rendering.DataSource);
            return View(context.Cast<IListOfServices>(dataSourceItem));
        }

        public ActionResult GetWorks()
        {
            var context = new SitecoreContext();
            var dataSourceItem = Sitecore.Context.Database.GetItem(RenderingContext.CurrentOrNull.Rendering.DataSource);
            return View(context.Cast<IListOfWorks>(dataSourceItem));
        }

        public ActionResult GetClients()
        {
            var context = new SitecoreContext();
            var dataSourceItem = Sitecore.Context.Database.GetItem(RenderingContext.CurrentOrNull.Rendering.DataSource);
            return View(context.Cast<IClientsInformation>(dataSourceItem));
        }
    }
}