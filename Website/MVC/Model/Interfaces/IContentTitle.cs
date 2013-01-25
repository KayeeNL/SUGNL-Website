using Glass.Sitecore.Mapper.Configuration.Attributes;

namespace Website.MVC.Model.Interfaces
{
    [SitecoreClass]
    public interface IContentTitle
    {
        [SitecoreField("Content Title")]
        string ContentTitle { get; set; }

        [SitecoreField("Content SubTitle")]
        string ContentSubTitle { get; set; }
    }
}