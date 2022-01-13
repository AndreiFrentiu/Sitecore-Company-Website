using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using SitecoreCompanyWebsite.Feature.PageContent.Models.Glass_Mapper.Global_Templates;
using SitecoreCompanyWebsite.Feature.PageContent.Models.Glass_Mapper.Global_Templates.Glass_Mapper_Base;
using System.Collections.Generic;

namespace SitecoreCompanyWebsite.Feature.PageContent.Models.Glass_Mapper.Page_Templates.Home_Page
{
    [SitecoreType(TemplateId = "{12DA263B-1F1E-4662-BC77-5E010371E367}", AutoMap = true)]
    public interface IClientsInformation : ISamplePart, IGlassMapperBase
    {
        [SitecoreField]
        IEnumerable<IClient> Items { get; set; }
    }

    [SitecoreType(TemplateId = "{025D4024-5577-4701-922A-8D6132A186E8}", AutoMap = true)]
    public interface IClient
    {
        [SitecoreField]
        string Link { get; set; }

        [SitecoreField]
        Image Image { get; set; }
    }
}
