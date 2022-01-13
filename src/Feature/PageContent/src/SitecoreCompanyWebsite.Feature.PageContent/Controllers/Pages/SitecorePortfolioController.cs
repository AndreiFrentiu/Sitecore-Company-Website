using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Mvc;
using Sitecore.Mvc.Presentation;
using SitecoreCompanyWebsite.Feature.PageContent.Models.Glass_Mapper.Global_Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitecoreCompanyWebsite.Feature.PageContent.Controllers.Pages
{
    [Obsolete]
    public class SitecorePortfolioController : GlassController
    {
        public ActionResult GetMainPage()
        {
            return View();
        }

        public ActionResult GetPortfolio()
        {
            var context = new SitecoreContext();
            var dataSourceItem = Sitecore.Context.Database.GetItem(RenderingContext.CurrentOrNull.Rendering.DataSource);
            return View(context.Cast<IListOfWorks>(dataSourceItem));
        }
    }
}