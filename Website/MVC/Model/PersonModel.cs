using Glass.Sitecore.Mapper.FieldTypes;
using Website.MVC.Model.Base;
using Website.MVC.Model.Interfaces;

namespace Website.MVC.Model
{
    public class PersonModel : BasePageModel, IPerson
    {
        #region IPerson Members

        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Email { get; set; }
        public virtual Image PersonImage { get; set; }
        public virtual string CompanyName { get; set; }
        public virtual string CompanyUrl { get; set; }
        public virtual string LinkedInUrl { get; set; }
        public virtual string TwitterUrl { get; set; }
        public virtual string FacebookUrl { get; set; }
        public virtual string BlogUrl { get; set; }

        #endregion
    }
}