using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RevolutionContentManagerDAL
{
    public class ContentManagerClient
    {
			public ContentManagerSetting GetSetting(int id)
			{
				using (var db = new ContentManagerEntities())
				{
					var setting = db.ContentManagerSettings.Where(c => c.ID == id).FirstOrDefault();
                    return setting;
				}
			}

			public ContentManagerSetting SaveSetting(ContentManagerSetting setting)
			{
				using (var db = new ContentManagerEntities())
				{
					db.ContentManagerSettings.Attach(setting);
                    db.ObjectStateManager.ChangeObjectState(setting, System.Data.EntityState.Modified);
					db.SaveChanges();
					return setting;
				}
			}
    }
}
