using Glass.Sitecore.Mapper;
using Glass.Sitecore.Mapper.Razor.Web.Ui;
using Website.MVC.Model.Interfaces;

namespace Website.MVC.Views.Codebehind
{
    public class CallToActionBlocksView : AbstractRazorControl<ICallToActionBlocks>
    {
        private ISitecoreContext _context;

        public override ICallToActionBlocks GetModel()
        {
            _context = new SitecoreContext();

            return _context.GetCurrentItem<ICallToActionBlocks>();
        }
    }
}