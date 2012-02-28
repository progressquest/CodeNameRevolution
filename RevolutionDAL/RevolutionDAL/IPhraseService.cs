using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RevolutionDAL
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPhraseService" in both code and config file together.
  [ServiceContract]
  public interface IPhraseService
  {
    [OperationContract]
    Phrase GetPhrase(int id);

    [OperationContract]
    Phrase SavePhrase(Phrase phrase);

    [OperationContract]
    void RemovePhrase(int id);

    [OperationContract]
    List<Phrase> GetPhrasesByTopic(int topicId);
  }
}
