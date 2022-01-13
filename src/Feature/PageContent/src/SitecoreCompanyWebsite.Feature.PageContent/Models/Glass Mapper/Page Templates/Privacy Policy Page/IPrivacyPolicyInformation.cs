using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreCompanyWebsite.Feature.PageContent.Models.Glass_Mapper.Page_Templates.Privacy_Policy_Page
{
    [SitecoreType(TemplateId = "{C3969500-D2BB-4917-95BC-47F450A68A86}", AutoMap = true)]
    public interface IPrivacyPolicyInformation
    {
        [SitecoreField]
        string Title { get; set; }

        [SitecoreField]
        string PrivacyInformation { get; set; }
    }
}
