using Glass.Sitecore.Mapper;
using Glass.Sitecore.Mapper.Razor.Web.Ui;
using Website.MVC.Model;

namespace Website.MVC.Views.Codebehind
{
    public class AgendaDetailView : AbstractRazorControl<AgendaModel>
    {
        private ISitecoreContext _context;

        public override AgendaModel GetModel()
        {
            _context = new SitecoreContext();
            return _context.GetCurrentItem<AgendaModel>();
        }
    }
}