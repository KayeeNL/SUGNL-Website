using System;
using Glass.Sitecore.Mapper.Configuration.Attributes;

namespace Website.MVC.Model.Interfaces
{
    [SitecoreClass]
    public interface IDate
    {
        [SitecoreField("Date")]
        DateTime Date { get; set; }
    }
}