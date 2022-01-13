using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System.Collections.Generic;

namespace SitecoreCompanyWebsite.Feature.PageContent.Models.Glass_Mapper.Page_Templates.AboutUs_Page
{
    [SitecoreType(TemplateId = "{805B4A34-FB40-4A55-B5D5-532E2EE70576}", AutoMap = true)]
    public interface IListOfEmployees
    {
        [SitecoreField]
        IEnumerable<IEmployee> Items { get; set; }
    }

    [SitecoreType(TemplateId = "{343C1EF7-B34A-4D0F-BA62-A8018F58A033}", AutoMap = true)]
    public interface IEmployee
    {
        [SitecoreField]
        string Name { get; set; }

        [SitecoreField]
        string Description { get; set; }

        [SitecoreField]
        Image Image { get; set; }

        [SitecoreField]
        string Facebook { get; set; }

        [SitecoreField]
        string Google { get; set; }

        [SitecoreField]
        string LinkedIn { get; set; }

        [SitecoreField]
        string Twitter { get; set; }
    }
}
