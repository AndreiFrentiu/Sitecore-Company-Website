using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using SitecoreCompanyWebsite.Feature.PageContent.Models.Glass_Mapper.Global_Templates.Glass_Mapper_Base;
using System.Collections.Generic;

namespace SitecoreCompanyWebsite.Feature.PageContent.Models.Glass_Mapper.Global_Templates
{
    [SitecoreType(TemplateId = "{E6DB2183-3932-4486-9B14-CCF7386F3E0B}", AutoMap = true)]
    public interface IListOfWorks : IGlassMapperBase, ISamplePart
    {
        [SitecoreField]
        IEnumerable<IWork> Items { get; set; }
    }

    [SitecoreType(TemplateId = "{3E4771C3-A4E0-45DB-A90B-C94292300F32}", AutoMap = true)]
    public interface IWork : IGlassMapperBase
    {
        [SitecoreField]
        string Title { get; set; }

        [SitecoreField]
        Image Image { get; set; }

        [SitecoreField]
        string Link { get; set; }

        [SitecoreField]
        string Description { get; set; }
    }

}
