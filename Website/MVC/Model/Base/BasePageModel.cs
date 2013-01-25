using System;
using System.Collections.Generic;
using Glass.Sitecore.Mapper.Configuration.Attributes;
using Sitecore.Globalization;
using Website.MVC.Model.Interfaces;

namespace Website.MVC.Model.Base
{
    [SitecoreClass]
    public class BasePageModel : IGlassBase, IBrowser, IMetaData, IContentTitle, IContentIntroduction, IMenu
    {
        [SitecoreChildren]
        public virtual IEnumerable<BasePageModel> Children { get; set; }

        [SitecoreParent]
        public virtual BasePageModel Parent { get; set; }

        #region IBrowser Members

        public virtual string BrowserTitle { get; set; }

        #endregion

        #region IContentIntroduction Members

        public virtual string ContentIntroduction { get; set; }

        #endregion

        #region IContentTitle Members

        public virtual string ContentTitle { get; set; }
        public virtual string ContentSubTitle { get; set; }

        #endregion

        #region IGlassBase Members

        public virtual Guid Id { get; set; }
        public virtual string Url { get; set; }
        public virtual string Name { get; set; }
        public virtual string DisplayName { get; set; }
        public virtual string Path { get; set; }
        public virtual string FullPath { get; set; }
        public virtual Language Language { get; set; }

        #endregion

        #region IMenu Members

        public virtual string MenuTitle { get; set; }
        public virtual bool HideInMenu { get; set; }

        #endregion

        #region IMetaData Members

        public virtual string MetaDescription { get; set; }
        public virtual string MetaKeywords { get; set; }

        #endregion
    }
}