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
using System.Collections.Generic;
using Glass.Sitecore.Mapper.FieldTypes;
using Website.MVC.Model.Base;
using Website.MVC.Model.Interfaces;

namespace Website.MVC.Model
{
    public class AgendaModel : BasePageModel, IMeetingDetails, IMeetingDownloads, IMeetingType, IDate, ITime
    {
        #region IDate Members

        public virtual DateTime Date { get; set; }

        #endregion

        #region IMeetingDetails Members

        public virtual string Location { get; set; }
        public virtual string Topics { get; set; }
        public virtual IEnumerable<PersonModel> Speakers { get; set; }
        public virtual Image OrganizerLogo { get; set; }
        public virtual string AttendingTitle { get; set; }
        public virtual string AttendingIntro { get; set; }
        public virtual Link AttendingUrl { get; set; }

        #endregion

        #region IMeetingDownloads Members

        public virtual Link DownloadsFolder { get; set; }
        public virtual Link VideosFolder { get; set; }
        public virtual Link PhotosFolder { get; set; }

        #endregion

        #region IMeetingType Members

        public virtual IGlassBase MeetingType { get; set; }

        #endregion

        #region ITime Members

        public virtual string StartTime { get; set; }
        public virtual string EndTime { get; set; }

        #endregion
    }
}