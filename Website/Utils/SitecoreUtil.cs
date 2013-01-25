using System;
using System.Collections.Generic;
using System.Linq;
using Glass.Sitecore.Mapper;
using Sitecore.Data;
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
            AgendaOverviewModel archiveItem = context.GetItem<AgendaOverviewModel>(new Guid("{BA01B6B5-BF68-46DE-900F-BCE1227E72B0}"));
            return archiveItem.ChildrenAsAgendaItems.Where(agendaModel => agendaModel.Speakers.Any(personModel => personModel.Id.ToString() == model.Id.ToString())).ToList();
        }
    }
}