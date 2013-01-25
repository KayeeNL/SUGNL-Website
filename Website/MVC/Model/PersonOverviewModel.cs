using System.Collections.Generic;
using Glass.Sitecore.Mapper.Configuration.Attributes;
using Website.MVC.Model.Base;
using Website.MVC.Model.Interfaces;

namespace Website.MVC.Model
{
    [SitecoreClass]
    public class PersonOverviewModel : BasePageModel
    {
        [SitecoreChildren]
        public virtual IEnumerable<PersonModel> ChildrenAsPersonItems { get; set; }
    }
}