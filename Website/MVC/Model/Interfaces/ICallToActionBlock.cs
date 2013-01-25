using System;
using Glass.Sitecore.Mapper.Configuration.Attributes;
using Glass.Sitecore.Mapper.FieldTypes;

namespace Website.MVC.Model.Interfaces
{
    [SitecoreClass]
    public interface ICallToActionBlock
    {
        [SitecoreId]
        Guid Id { get; set; }

        [SitecoreField(FieldName = "Call To Action Title")]
        string CallToActionTitle { get; set; }

        [SitecoreField(FieldName = "Call To Action Image")]
        Image CallToActionImage { get; set; }

        [SitecoreField(FieldName = "Call To Action Link")]
        Link CallToActionLink { get; set; }
    }
}