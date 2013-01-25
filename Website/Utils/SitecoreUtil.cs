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
using System.Collections.Generic;
using System.Linq;
using Glass.Sitecore.Mapper;
using Sitecore.Data.Items;
using Website.MVC.Model;
using Website.MVC.Model.Base;
using Context = Sitecore.Context;

namespace Website.Utils
{
    public static class SitecoreUtil
    {
        public static bool IsPageEditor()
        {
            return Context.PageMode.IsPageEditor;
        }

        private static string GetStartItemGuid()
        {
            Item startItem = Context.Database.GetItem(Context.Site.StartPath);
            return startItem.ID.ToGuid().ToString();
        }

        public static bool IsStartItem(this BasePageModel item)
        {
            return item.Id.ToString() == GetStartItemGuid();
        }

        public static MediaFolderModel GetTypedMediaFolderModel(Guid mediaFolderGuid)
        {
            ISitecoreContext context = new SitecoreContext();
            return context.GetItem<MediaFolderModel>(mediaFolderGuid);
        }

        public static IEnumerable<AgendaModel> GetPastAgendaItemsForPerson(PersonModel model)
        {
            ISitecoreContext context = new SitecoreContext();
            var archiveItem = context.GetItem<AgendaOverviewModel>(new Guid("{BA01B6B5-BF68-46DE-900F-BCE1227E72B0}"));
            return archiveItem.ChildrenAsAgendaItems.Where(agendaModel => agendaModel.Speakers.Any(personModel => personModel.Id.ToString() == model.Id.ToString())).ToList();
        }
    }
}