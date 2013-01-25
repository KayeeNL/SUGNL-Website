// /*===========================================================
//    Copyright 2013 Robbert Hock
//  
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//  
// ============================================================*/

using System;
using System.IO;
using Glass.Sitecore.Mapper.Configuration.Attributes;
using Sitecore;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Globalization;
using Sitecore.Resources.Media;
using Website.MVC.Model.Interfaces;

namespace Website.MVC.Model
{
    [SitecoreClass]
    public class MediaFileModel : IGlassBase
    {
        public string MediaPath
        {
            get
            {
                Item item = Context.Database.GetItem(new ID(Id));
                return StringUtil.EnsurePrefix('/', MediaManager.GetMediaUrl(item));
            }
        }

        public string MediaThumbPath
        {
            get
            {
                Item item = Context.Database.GetItem(new ID(Id));
                var options = new MediaUrlOptions(250, 250, true);
                return StringUtil.EnsurePrefix('/', MediaManager.GetMediaUrl(item, options));
            }
        }

        [SitecoreField("Attachment")]
        public virtual Stream File { get; set; }

        [SitecoreField("File Path")]
        public virtual string FilePath { get; set; }

        [SitecoreField("MimeType")]
        public virtual string MimeType { get; set; }

        [SitecoreField("Title")]
        public virtual string Title { get; set; }

        [SitecoreField("Format")]
        public virtual string Format { get; set; }

        [SitecoreField("Description")]
        public virtual string Description { get; set; }

        [SitecoreField("Keywords")]
        public virtual string Keywords { get; set; }

        [SitecoreField("Size")]
        public virtual string Size { get; set; }

        [SitecoreField("Extension")]
        public virtual string Extension { get; set; }

        #region IGlassBase Members

        public virtual Guid Id { get; set; }
        public virtual string Url { get; set; }
        public virtual string Name { get; set; }
        public virtual string DisplayName { get; set; }
        public virtual string Path { get; set; }
        public virtual string FullPath { get; set; }
        public virtual Language Language { get; set; }

        #endregion
    }
}