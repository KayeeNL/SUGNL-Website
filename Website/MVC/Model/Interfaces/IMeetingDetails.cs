using System.Collections.Generic;
using Glass.Sitecore.Mapper.Configuration.Attributes;
using Glass.Sitecore.Mapper.FieldTypes;

namespace Website.MVC.Model.Interfaces
{
    [SitecoreClass]
    public interface IMeetingDetails
    {
        [SitecoreField(FieldName = "Location")]
        string Location { get; set; }

        [SitecoreField(FieldName = "Topics")]
        string Topics { get; set; }

        [SitecoreField(FieldName = "Speakers")]
        IEnumerable<PersonModel> Speakers { get; set; }

        [SitecoreField(FieldName = "Organizer Logo")]
        Image OrganizerLogo { get; set; }

        [SitecoreField(FieldName = "Attending Title")]
        string AttendingTitle { get; set; }

        [SitecoreField(FieldName = "Attending Intro")]
        string AttendingIntro { get; set; }

        [SitecoreField(FieldName = "Attending Url")]
        Link AttendingUrl { get; set; }
    }
}