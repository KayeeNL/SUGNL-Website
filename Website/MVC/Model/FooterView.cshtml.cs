using Glass.Sitecore.Mapper;
using Glass.Sitecore.Mapper.Razor.Web.Ui;

namespace Website.MVC.Model
{
    public class FooterView : AbstractRazorControl<FooterFolderModel>
    {
        private ISitecoreContext _context;

        public override FooterFolderModel GetModel()
        {
            _context = new SitecoreContext();

            return _context.GetItem<FooterFolderModel>("/sitecore/content/Configuration/Footer");
        }
    }
}