using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Mvc;
using Sitecore.Mvc.Presentation;
using SitecoreCompanyWebsite.Feature.PageContent.Models.Glass_Mapper.Page_Templates.Privacy_Policy_Page;
using System;
using System.Web.Mvc;

namespace SitecoreCompanyWebsite.Feature.PageContent.Controllers.Pages
{
    [Obsolete]
    public class SitecoreAdditionalPageController : GlassController
    {
        public ActionResult Error404()
        {
            return View();
        }

        public ActionResult PrivacyPolicy()
        {
            var context = new SitecoreContext();
            var dataSourceItem = Sitecore.Context.Database.GetItem(RenderingContext.CurrentOrNull.Rendering.DataSource);
            return View(context.Cast<IPrivacyPolicyInformation>(dataSourceItem));
        }
    }
}