using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace SitecoreCompanyWebsite.Feature.PageContent.Models.Glass_Mapper.Global_Templates.Glass_Mapper_Base
{
    public interface IGlassMapperBase
    {

        [SitecoreInfo(SitecoreInfoType.Name)]
        string ItemName { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateName)]
        string Template { get; set; }

    }
}
