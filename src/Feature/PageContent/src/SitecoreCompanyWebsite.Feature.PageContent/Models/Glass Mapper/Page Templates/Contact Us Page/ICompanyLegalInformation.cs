using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreCompanyWebsite.Feature.PageContent.Models.Glass_Mapper.Page_Templates.Contact_Us_Page
{
    [SitecoreType(TemplateId = "{C062055E-16FC-4D10-90DF-15E0BA679724}", AutoMap = true)]
    public interface ICompanyLegalInformation
    {
        [SitecoreField]
        string Title { get; set; }

        [SitecoreField]
        string Description { get; set; }

        [SitecoreField]
        string Adress { get; set; }

        [SitecoreField]
        string CompanyEmail { get; set; }

        [SitecoreField]
        string CompanyLink { get; set; }

        [SitecoreField]
        string Telephone { get; set; }

        [SitecoreField]
        string Domain { get; set; }

        [SitecoreField]
        string DomainLink { get; set; }
    }
}
