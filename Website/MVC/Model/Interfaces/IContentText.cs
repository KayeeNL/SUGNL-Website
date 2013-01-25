using Glass.Sitecore.Mapper.Configuration.Attributes;

namespace Website.MVC.Model.Interfaces
{
    [SitecoreClass]
    public interface IContentText
    {
        [SitecoreField(FieldName = "Content Text")]
        string ContentText { get; set; }
    }
}