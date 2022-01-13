using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Mvc;
using Sitecore.Mvc.Presentation;
using SitecoreCompanyWebsite.Feature.PageContent.Models.Glass_Mapper.Page_Templates.Contact_Us_Page;
using System;
using System.Web.Mvc;

namespace SitecoreCompanyWebsite.Feature.PageContent.Controllers.Pages
{
    [Obsolete]
    public class SitecoreContactUsController : GlassController
    {
        public ActionResult GetCompanyLegalInformation()
        {
            var context = new SitecoreContext();
            var dataSourceItem = Sitecore.Context.Database.GetItem(RenderingContext.CurrentOrNull.Rendering.DataSource);
            return View(context.Cast<ICompanyLegalInformation>(dataSourceItem));
        }
    }
}