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

using Glass.Sitecore.Mapper;
using Website.MVC.Model.Interfaces;

namespace Website.MVC.Model.Base
{

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TGlassItem">The type of the glass item.</typeparam>
    public abstract class BaseWebViewPage<TGlassItem> : System.Web.Mvc.WebViewPage<Sitecore.Mvc.Presentation.RenderingModel> where TGlassItem : class, IGlassBase
    {
        /// <summary>
        /// A strongly typed Sitecore Item taken from the RenderingModel's Item property - Will map to the Item referenced in
        /// the Rendering's DataSource property, or the Context Item if no DataSource is set.
        /// </summary>
        public TGlassItem GlassItem
        {
            get { return Model.Item.GlassCast<TGlassItem>(); }
        }
    }
}