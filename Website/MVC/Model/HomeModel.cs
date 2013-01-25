using System.Collections.Generic;
using Glass.Sitecore.Mapper.Configuration.Attributes;
using Website.MVC.Model.Base;
using Website.MVC.Model.Interfaces;

namespace Website.MVC.Model
{
    [SitecoreClass]
    public class HomeModel : BasePageModel, ICarrouselSlides, ICallToActionBlocks
    {
        #region ICallToActionBlocks Members

        public virtual IEnumerable<ICallToActionBlock> CallToActionBlocks { get; set; }

        #endregion

        #region ICarrouselSlides Members

        public virtual IEnumerable<ICarrouselSlide> CarrouselSlides { get; set; }

        #endregion
    }
}