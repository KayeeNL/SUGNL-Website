using Glass.Sitecore.Mapper.Configuration.Attributes;

namespace Website.MVC.Model.Interfaces
{
    [SitecoreClass]
    public interface ITime
    {
        [SitecoreField("Start Time")]
        string StartTime { get; set; }

        [SitecoreField("End Time")]
        string EndTime { get; set; }
    }
}