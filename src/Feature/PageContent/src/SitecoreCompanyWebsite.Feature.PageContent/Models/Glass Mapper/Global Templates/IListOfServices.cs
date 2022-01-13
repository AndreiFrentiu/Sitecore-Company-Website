using Glass.Mapper.Sc.Configuration.Attributes;
using SitecoreCompanyWebsite.Feature.PageContent.Models.Glass_Mapper.Global_Templates.Glass_Mapper_Base;
using System.Collections.Generic;

namespace SitecoreCompanyWebsite.Feature.PageContent.Models.Glass_Mapper.Global_Templates
{
    [SitecoreType(TemplateId = "{4C22061E-94C4-4057-A0A3-519D5E990833}", AutoMap = true)]
    public interface IListOfServices : IGlassMapperBase, ISamplePart
    {
        [SitecoreField]
        IEnumerable<IService> Items { get; set; }
    }

    [SitecoreType(TemplateId = "{0D478841-9BCE-4E31-B17B-5F491E44DB00}", AutoMap = true)]
    public interface IService : IGlassMapperBase, ISamplePart
    {
        [SitecoreField]
        string ImageClass { get; set; }
    }
}
