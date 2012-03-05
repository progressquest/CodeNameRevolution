using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RevolutionDAL
{
	[ServiceContract]
	public interface IContentManagerSettingService
	{
		[OperationContract]
		ContentManagerSetting GetSetting(int id);

		[OperationContract]
		ContentManagerSetting SaveSetting(ContentManagerSetting setting);
	}
}
