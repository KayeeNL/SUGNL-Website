// /*===========================================================
//    Copyright 2013 Robbert Hock
//  
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//  
// ============================================================*/

using System;
using System.Text;
using System.Web.UI;
using Glass.Sitecore.Mapper;
using Website.MVC.Model.Base;
using Website.Utils;
using Settings = Sitecore.Configuration.Settings;

namespace Website.MVC.Layouts
{
    public partial class Default : Page
    {
        protected BasePageModel BasePageModel { get; set; }

        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            ISitecoreContext context = new SitecoreContext();
            BasePageModel = context.GetCurrentItem<BasePageModel>();

            LoadMetaData();
            RegisterGoogleAnalyticsScript();
        }

        /// <summary>
        /// Registers the google analytics script.
        /// </summary>
        private void RegisterGoogleAnalyticsScript()
        {
            if (!ClientScript.IsClientScriptBlockRegistered(GetType(), "GoogleAnalytics"))
            {
                string trackerCode = Settings.GetSetting("GoogleAnalytics.TrackerCode");

                var builder = new StringBuilder();
                builder.AppendLine(@"<script type=""text/javascript"">");
                builder.AppendLine(@"  var _gaq = _gaq || [];");
                builder.AppendFormat(@"  _gaq.push(['_setAccount', '{0}']);", trackerCode);
                builder.AppendLine(@"  _gaq.push(['_trackPageview']);");
                builder.AppendLine(@"");
                builder.AppendLine(@"  (function() {");
                builder.AppendLine(@"    var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;");
                builder.AppendLine(@"    ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';");
                builder.AppendLine(@"    var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);");
                builder.AppendLine(@"  })();");
                builder.AppendLine(@"</script>");
                ClientScript.RegisterClientScriptBlock(GetType(), "GoogleAnalytics", builder.ToString(), false);
            }
        }

        /// <summary>
        /// Loads the meta data.
        /// </summary>
        private void LoadMetaData()
        {
            HtmlUtil.RegisterMetaData(this, "description", BasePageModel.MetaDescription);
            HtmlUtil.RegisterMetaData(this, "keywords", BasePageModel.MetaKeywords);
        }
    }
}