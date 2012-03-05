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
		[ServiceKnownType(typeof(List<Character>))]

    [OperationContract]
    [ApplyDataContractResolver]
    Character GetCharacter(int id);

    [OperationContract]
    [ApplyDataContractResolver]
    Character SaveCharacter(Character character);

    [OperationContract]
    [ApplyDataContractResolver]
    void RemoveCharacter(int id);

		[OperationContract]
    [ApplyDataContractResolver]
		List<Character> GetAllCharacters();
  }
}
