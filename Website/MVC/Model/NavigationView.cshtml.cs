using Glass.Sitecore.Mapper;
using Glass.Sitecore.Mapper.Razor.Web.Ui;

namespace Website.MVC.Model
{
    public class NavigationView : AbstractRazorControl<HomeModel>
    {
        private ISitecoreContext _context;

        public override HomeModel GetModel()
        {
            _context = new SitecoreContext();
            return _context.GetHomeItem<HomeModel>();
        }
    }
}