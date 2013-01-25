using System.Collections.Generic;
using Glass.Sitecore.Mapper.Configuration.Attributes;

namespace Website.MVC.Model.Interfaces
{
    [SitecoreClass]
    public interface ICarrouselSlides
    {
        [SitecoreField(FieldName = "Carrousel Slides")]
        IEnumerable<ICarrouselSlide> CarrouselSlides { get; set; }
    }
}