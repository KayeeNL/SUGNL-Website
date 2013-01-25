using System.Collections.Generic;
using Glass.Sitecore.Mapper.Configuration.Attributes;
using Glass.Sitecore.Mapper.FieldTypes;

namespace Website.MVC.Model.Interfaces
{
    [SitecoreClass]
    public interface IMediaFolder : IGlassBase
    {
        [SitecoreChildren]
        IEnumerable<MediaFileModel> Files { get; set; }
    }
}