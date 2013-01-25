using Glass.Sitecore.Mapper.Configuration.Attributes;
using Glass.Sitecore.Mapper.FieldTypes;

namespace Website.MVC.Model.Interfaces
{
    [SitecoreClass]
    public interface IFooterMenuLink
    {
        [SitecoreField(FieldName = "Link Title")]
        string LinkTitle { get; set; }

        [SitecoreField(FieldName = "Link Url")]
        Link LinkUrl { get; set; }

        [SitecoreField(FieldName = "Link CssClass")]
        string LinkCssClass { get; set; }
    }
}