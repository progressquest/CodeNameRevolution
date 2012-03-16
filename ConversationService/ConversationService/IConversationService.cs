using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RevolutionConversationService
{
	[ServiceContract]
	public interface IConversationService
	{

		[OperationContract]
		string GetData(int value);

	}
}
