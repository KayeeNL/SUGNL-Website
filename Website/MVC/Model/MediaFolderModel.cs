using System;
using System.Collections.Generic;
using Glass.Sitecore.Mapper.Configuration.Attributes;
using Sitecore.Globalization;
using Website.MVC.Model.Interfaces;

namespace Website.MVC.Model
{
    [SitecoreClass]
    public class MediaFolderModel : IMediaFolder
    {
        #region IMediaFolder Members

        public virtual Guid Id { get; set; }
        public virtual string Url { get; set; }
        public virtual string Name { get; set; }
        public virtual string DisplayName { get; set; }
        public virtual string Path { get; set; }
        public virtual string FullPath { get; set; }
        public virtual Language Language { get; set; }
        public virtual IEnumerable<MediaFileModel> Files { get; set; }

        #endregion
    }
}