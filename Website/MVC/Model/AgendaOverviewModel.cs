using System.Collections.Generic;
using Glass.Sitecore.Mapper.Configuration.Attributes;
using Website.MVC.Model.Base;

namespace Website.MVC.Model
{
    [SitecoreClass]
    public class AgendaOverviewModel : BasePageModel
    {
        [SitecoreChildren]
        public virtual IEnumerable<AgendaModel> ChildrenAsAgendaItems { get; set; }
    }
}