using Glass.Sitecore.Mapper.Configuration.Attributes;

namespace Website.MVC.Model.Interfaces
{
    [SitecoreClass]
    public interface IMetaData
    {
        [SitecoreField(FieldName = "Meta Description")]
        string MetaDescription { get; set; }

        [SitecoreField(FieldName = "Meta Keywords")]
        string MetaKeywords { get; set; }
    }
}