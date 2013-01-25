using System.Collections.Generic;
using Glass.Sitecore.Mapper.Configuration.Attributes;
using Website.MVC.Model.Interfaces;

namespace Website.MVC.Model
{
    [SitecoreClass]
    public class FooterFolderModel
    {
        [SitecoreChildren]
        public virtual IEnumerable<IFooterMenu> FooterMenus { get; set; }
    }
}