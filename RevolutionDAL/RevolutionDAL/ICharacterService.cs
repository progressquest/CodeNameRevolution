using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RevolutionDAL
{
  [ServiceContract]
  public interface ICharacterService
  {
    [OperationContract]
    Character GetCharacter(int id);

    [OperationContract]
    Character SaveCharacter(Character character);

    [OperationContract]
    void RemoveCharacter(int id);
  }
}
