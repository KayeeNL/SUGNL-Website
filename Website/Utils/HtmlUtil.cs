using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace Website.Utils
{
    public static class HtmlUtil
    {
        public static void RegisterMetaData(Page page, string name, string content)
        {
            if (string.IsNullOrEmpty(content)) return;
            var htmlMeta = new HtmlMeta {Name = name, Content = content};
            page.Header.Controls.Add(htmlMeta);
        }
    }
}