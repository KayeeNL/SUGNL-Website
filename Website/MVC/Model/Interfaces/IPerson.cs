using Glass.Sitecore.Mapper.Configuration.Attributes;
using Glass.Sitecore.Mapper.FieldTypes;

namespace Website.MVC.Model.Interfaces
{
    [SitecoreClass]
    public interface IPerson
    {
        [SitecoreField(FieldName = "Firstname")]
        string FirstName { get; set; }

        [SitecoreField(FieldName = "Lastname")]
        string LastName { get; set; }

        [SitecoreField(FieldName = "Email")]
        string Email { get; set; }

        [SitecoreField(FieldName = "Person Image")]
        Image PersonImage { get; set; }

        [SitecoreField(FieldName = "Company Name")]
        string CompanyName { get; set; }

        [SitecoreField(FieldName = "Company Url")]
        string CompanyUrl { get; set; }

        [SitecoreField(FieldName = "LinkedIn Url")]
        string LinkedInUrl { get; set; }

        [SitecoreField(FieldName = "Twitter Url")]
        string TwitterUrl { get; set; }

        [SitecoreField(FieldName = "Facebook Url")]
        string FacebookUrl { get; set; }

        [SitecoreField(FieldName = "Blog Url")]
        string BlogUrl { get; set; }
    }
}