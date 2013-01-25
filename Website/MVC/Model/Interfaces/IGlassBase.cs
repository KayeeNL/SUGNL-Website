using System;
using Glass.Sitecore.Mapper.Configuration;
using Glass.Sitecore.Mapper.Configuration.Attributes;
using Sitecore.Globalization;

namespace Website.MVC.Model.Interfaces
{
    [SitecoreClass]
    public interface IGlassBase
    {
        [SitecoreId]
        Guid Id { get; set; }

        [SitecoreInfo(SitecoreInfoType.Url)]
        string Url { get; set; }

        [SitecoreInfo(SitecoreInfoType.Name)]
        string Name { get; set; }

        [SitecoreInfo(SitecoreInfoType.DisplayName)]
        string DisplayName { get; set; }

        [SitecoreInfo(SitecoreInfoType.Path)]
        string Path { get; set; }

        [SitecoreInfo(SitecoreInfoType.FullPath)]
        string FullPath { get; set; }

        [SitecoreInfo(SitecoreInfoType.Language)]
        Language Language { get; set; }
    }
}