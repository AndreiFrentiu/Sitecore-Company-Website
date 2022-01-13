using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Mvc;
using Sitecore.Mvc.Presentation;
using SitecoreCompanyWebsite.Feature.PageContent.Models.Layout_Templates;
using System;
using System.Web.Mvc;

namespace SitecoreCompanyWebsite.Feature.PageContent.Controllers.Layout
{
    [Obsolete]
    public class SitecoreLayoutController : GlassController
    {
        public ActionResult GetHeader()
        {
            var model = NavigationHelper.GetHeaderModel();
            return View(model);
        }

        public ActionResult GetFooter()
        {
            var lists = NavigationHelper.GetBottomModel();        
            var context = new SitecoreContext();
            var dataSourceItem = Sitecore.Context.Database.GetItem(RenderingContext.CurrentOrNull.Rendering.DataSource);
            var model = context.Cast<IFooter>(dataSourceItem);
            model.Lists = lists;
            return View(model);
        }
    }
}