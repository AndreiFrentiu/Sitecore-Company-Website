using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Mvc.Presentation;
using Sitecore.Web.UI.WebControls;
using System.Collections.Generic;

namespace SitecoreCompanyWebsite.Feature.PageContent.Models.Layout_Templates 
{ 

    public class FooterHelper
    {
        public List<NavigationHelper> Pages { get; set; } = new List<NavigationHelper>();
        public List<NavigationHelper> Links { get; set; } = new List<NavigationHelper>();

    } 

    public class NavigationHelper
    {
        public string Name { get; set; }
        public string Url { get; set; }

        public static List<NavigationHelper> GetHeaderModel()
        {
            var dataSourceId = RenderingContext.CurrentOrNull.Rendering.DataSource;
            var dataSource = Sitecore.Context.Database.GetItem(dataSourceId);

            Sitecore.Data.Fields.MultilistField multiselectField = dataSource.Fields["Items"];
            Sitecore.Data.Items.Item[] items = multiselectField.GetItems();

            List<NavigationHelper> model = new List<NavigationHelper>();

            foreach (var item in items)
            {
                model.Add(new NavigationHelper()
                {
                    Name = item.Name,
                    Url = Sitecore.Links.LinkManager.GetItemUrl(item)
                });
            }
            return model;
        }

        public static FooterHelper GetBottomModel()
        {
            var dataSourceId = RenderingContext.CurrentOrNull.Rendering.DataSource;
            var dataSource = Sitecore.Context.Database.GetItem(dataSourceId);

            Sitecore.Data.Fields.MultilistField multiselectField = dataSource.Fields["Items"];
            Sitecore.Data.Items.Item[] pages = multiselectField.GetItems();

            Sitecore.Data.Fields.MultilistField multiselectFieldForLinks = dataSource.Fields["Links"];
            Sitecore.Data.Items.Item[] links = multiselectFieldForLinks.GetItems();

            FooterHelper model = new FooterHelper();

            var pagesToGo = new List<NavigationHelper>();
            foreach (var page in pages)
            {
                pagesToGo.Add(new NavigationHelper()
                {
                    Name = page.Name,
                    Url = Sitecore.Links.LinkManager.GetItemUrl(page)
                });
            }

            model.Pages = pagesToGo;
            var pagesToGo2 = new List<NavigationHelper>();

            if (links != null && links.Length > 0)
            {
                for (int i = 0; i < links.Length; i++)
                {
                    NavigationHelper link = new NavigationHelper();
                    Sitecore.Data.Items.Item serviceItem = links[i];

                    link.Name = FieldRenderer.Render(serviceItem, "Name");
                    link.Url = FieldRenderer.Render(serviceItem, "Link");
                    pagesToGo2.Add(link);
                }
            }
            model.Links = pagesToGo2;

            return model;
        }
    }
}