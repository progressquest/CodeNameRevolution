using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RevolutionDAL
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPersonality" in both code and config file together.
  [ServiceContract]
  public interface IPersonalityService
  {
    [OperationContract]
    PersonalityType GetPersonalityType(int id);

    [OperationContract]
    List<PersonalityType> GetAllPersonalityTypes();
  }
}
