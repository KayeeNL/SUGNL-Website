using Glass.Sitecore.Mapper.Configuration.Attributes;
using Glass.Sitecore.Mapper.FieldTypes;

namespace Website.MVC.Model.Interfaces
{
    [SitecoreClass]
    public interface IMeetingDownloads
    {
        [SitecoreField(FieldName = "Downloads Folder")]
        Link DownloadsFolder { get; set; }

        [SitecoreField(FieldName = "Videos Folder")]
        Link VideosFolder { get; set; }

        [SitecoreField(FieldName = "Photos Folder")]
        Link PhotosFolder { get; set; }
    }
}