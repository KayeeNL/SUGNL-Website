using System.Collections.Generic;
using Glass.Sitecore.Mapper.Configuration;
using Glass.Sitecore.Mapper.Configuration.Attributes;

namespace Website.MVC.Model.Interfaces
{
    [SitecoreClass]
    public interface IFooterMenu
    {
        [SitecoreField(FieldName = "CssClass Children")]
        string CssClassChildren { get; set; }

        [SitecoreChildren]
        IEnumerable<IFooterMenuLink> FooterMenuLinks { get; set; }

        [SitecoreInfo(SitecoreInfoType.Name)]
        string Name { get; set; }
    }
}