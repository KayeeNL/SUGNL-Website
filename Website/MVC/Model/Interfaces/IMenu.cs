using System;
using Glass.Sitecore.Mapper.Configuration.Attributes;

namespace Website.MVC.Model.Interfaces
{
    [SitecoreClass]
    public interface IMenu
    {
        [SitecoreField(FieldName = "Menu Title")]
        string MenuTitle { get; set; }

        [SitecoreField(FieldName = "Hide In Menu")]
        Boolean HideInMenu { get; set; }
    }
}