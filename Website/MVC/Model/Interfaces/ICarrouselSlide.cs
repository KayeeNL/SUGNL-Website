using System;
using Glass.Sitecore.Mapper.Configuration.Attributes;
using Glass.Sitecore.Mapper.FieldTypes;

namespace Website.MVC.Model.Interfaces
{
    [SitecoreClass]
    public interface ICarrouselSlide
    {
        [SitecoreId]    
        Guid Id { get; set; }

        [SitecoreField("Slide Image")]
        Image SlideImage { get; set; }

        [SitecoreField(FieldName = "Slide Link")]
        Link SlideLink { get; set; }
    }
}