using Glass.Mapper.Sc.Configuration.Attributes;


namespace SitecoreCompanyWebsite.Feature.PageContent.Models.Glass_Mapper.Page_Templates.Home_Page
{
    [SitecoreType(TemplateId = "{DB599D77-31E0-402B-A49F-E47D34F702AF}", AutoMap = true)]
    public interface ICompanyInformation
    {
        [SitecoreField]
        string Title { get; set; }

        [SitecoreField]
        string FirstDescription { get; set; }

        [SitecoreField]
        string SecondDescription { get; set; }

    }
}
