using Glass.Sitecore.Mapper.Configuration.Attributes;
using Website.MVC.Model.Base;
using Website.MVC.Model.Interfaces;

namespace Website.MVC.Model
{
    [SitecoreClass]
    public class ContentModel : BasePageModel, IContentText
    {
        #region IContentText Members

        public virtual string ContentText { get; set; }

        #endregion
    }
}