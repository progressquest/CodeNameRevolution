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
					return new ContentManagerSetting { Value = setting.Value, Name = setting.Name, Description = setting.Description, ID = setting.ID };
				}
			}

			public ContentManagerSetting SaveSetting(ContentManagerSetting setting)
			{
				using (var db = new ContentManagerEntities())
				{
					db.ContentManagerSettings.AddObject(setting);
					db.SaveChanges();
					return setting;
				}
			}
    }
}
