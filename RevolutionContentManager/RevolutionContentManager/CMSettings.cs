using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RevolutionContentManager.ContentManagerSettingService;
using SafeService;

namespace RevolutionContentManager
{
    internal static class CMSettings
    {
        internal static ContentManagerSetting GetContentManagerSetting(int id)
        {
            ContentManagerSetting setting = null;

            Service<IContentManagerSettingService>.Use(client =>
            {
                setting = client.GetSetting(id);
            });

            return setting;
        }

        internal static ContentManagerSetting SaveContentManagerSetting(ContentManagerSetting setting)
        {
            Service<IContentManagerSettingService>.Use(client =>
            {
                setting = client.SaveSetting(setting);
            });

            return setting;
        }
    }
}
