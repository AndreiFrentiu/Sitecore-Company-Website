using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System.Collections.Generic;

namespace SitecoreCompanyWebsite.Feature.PageContent.Models.Glass_Mapper.Page_Templates.Home_Page
{
    [SitecoreType(TemplateId = "{3AC07782-7896-45A1-81FA-AA82E5CA7407}", AutoMap = true)]
    public interface ISlider
    {
        [SitecoreField]
        IEnumerable<ISliderItem> Items { get; set; }
    }

    [SitecoreType(TemplateId = "{C4C065C4-ACBD-49CC-9D02-F0092B79232B}", AutoMap = true)]
    public interface ISliderItem
    {
        [SitecoreField]
        string Title { get; set; }

        [SitecoreField]
        string Description { get; set; }

        [SitecoreField]
        Image Image { get; set; }

        [SitecoreField]
        string Style { get; set; }
    }
}
