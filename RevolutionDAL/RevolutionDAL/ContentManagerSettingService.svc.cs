using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RevolutionDAL
{
	public class ContentManagerSettingService : IContentManagerSettingService
	{
		public ContentManagerSetting GetSetting(int id)
		{
			using (var db = new RevolutionEntities1())
			{
				var setting = db.ContentManagerSettings.Where(c => c.ID == id).FirstOrDefault();
				return new ContentManagerSetting { Value = setting.Value, Name = setting.Name, Description = setting.Description, ID = setting.ID };
			}
		}

		public ContentManagerSetting SaveSetting(ContentManagerSetting setting)
		{
			using (var db = new RevolutionEntities1())
			{
				db.ContentManagerSettings.AddObject(setting);
				db.SaveChanges();
				return setting;
			}
		}
	}
}
