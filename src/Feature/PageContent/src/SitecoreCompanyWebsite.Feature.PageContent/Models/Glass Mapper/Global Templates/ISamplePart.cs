using Glass.Mapper.Sc.Configuration.Attributes;
using System.Collections.Generic;

namespace SitecoreCompanyWebsite.Feature.PageContent.Models.Glass_Mapper.Global_Templates
{
    [SitecoreType(TemplateId = "{5F75446B-D30E-44F9-B79F-2723C31CCF5F}", AutoMap = true)]
    public interface ISamplePart
    {
        [SitecoreField]
        string Title { get; set; }

        [SitecoreField]
        string Description { get; set; }
    }

    [SitecoreType(TemplateId = "{A510CD9F-D92B-4668-922D-CA8B1ACD699E}", AutoMap = true)]
    public interface IListOfSamplePart
    {
        [SitecoreField]
        IEnumerable<ISamplePart> Items { get; set; }

    }
}
