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