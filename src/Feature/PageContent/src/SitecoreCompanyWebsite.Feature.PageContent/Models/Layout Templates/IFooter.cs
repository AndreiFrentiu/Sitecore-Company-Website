using Glass.Mapper.Sc.Configuration.Attributes;

namespace SitecoreCompanyWebsite.Feature.PageContent.Models.Layout_Templates
{
    [SitecoreType(TemplateId = "{E0236891-7EC5-433D-B2CB-091B55BF9BF6}", AutoMap = true)]
    public interface IFooter
    {
        FooterHelper Lists { get; set; }

        [SitecoreField]
        string Adress { get; set; }

        [SitecoreField]
        string Email { get; set; }

        [SitecoreField]
        string Website { get; set; }

        [SitecoreField]
        string Telephone { get; set; }

        [SitecoreField]
        string Company { get; set; }

        [SitecoreField]
        string Year { get; set; }

        [SitecoreField]
        string CompanyLink { get; set; }
    }
}
