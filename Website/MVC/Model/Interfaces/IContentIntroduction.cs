using Glass.Sitecore.Mapper.Configuration.Attributes;

namespace Website.MVC.Model.Interfaces
{
    [SitecoreClass]
    public interface IContentIntroduction
    {
        [SitecoreField("Content Introduction")]
        string ContentIntroduction { get; set; }
    }
}