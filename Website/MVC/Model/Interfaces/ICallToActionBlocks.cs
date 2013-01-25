using System.Collections.Generic;
using Glass.Sitecore.Mapper.Configuration.Attributes;

namespace Website.MVC.Model.Interfaces
{
    [SitecoreClass]
    public interface ICallToActionBlocks
    {
        [SitecoreField(FieldName = "Call To Action Blocks")]
        IEnumerable<ICallToActionBlock> CallToActionBlocks { get; set; }
    }
}