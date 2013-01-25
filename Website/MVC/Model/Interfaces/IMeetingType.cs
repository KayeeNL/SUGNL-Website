using Glass.Sitecore.Mapper.Configuration.Attributes;

namespace Website.MVC.Model.Interfaces
{
    [SitecoreClass]
    public interface IMeetingType
    {
        [SitecoreField(FieldName = "Meeting Type")]
        IGlassBase MeetingType { get; set; }
    }
}