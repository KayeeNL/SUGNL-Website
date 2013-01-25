using Glass.Sitecore.Mapper.Configuration.Attributes;

namespace Website.MVC.Model.Interfaces
{
    [SitecoreClass]
    public interface IBrowser
    {
        [SitecoreField(FieldName = "Browser Title")]
        string BrowserTitle { get; set; }
    }
}