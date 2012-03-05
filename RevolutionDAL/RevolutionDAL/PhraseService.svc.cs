using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RevolutionDAL
{
  public class PhraseService : IPhraseService
  {
    public Phrase GetPhrase(int id)
    {
      using (var db = new RevolutionEntities1())
      {
        var phrase = db.Phrases.Where(p => p.ID == id).FirstOrDefault();
        return new Phrase { ID = phrase.ID, Immediacy = phrase.Immediacy, IsQuestion = phrase.IsQuestion, IsSpontaneous = phrase.IsSpontaneous, PersonalityPhrases = phrase.PersonalityPhrases, Text = phrase.Text, Topic = phrase.Topic, TopicID = phrase.TopicID };
      }
    }

    public Phrase SavePhrase(Phrase phrase)
    {
      using (var db = new RevolutionEntities1())
      {
        db.Phrases.Add(phrase);
        db.SaveChanges();
        return phrase;
      }
    }

    public void RemovePhrase(int id)
    {
      using (var db = new RevolutionEntities1())
      {
        var phrase = db.Phrases.FirstOrDefault(c => c.ID == id);
        if (phrase == null) return;
        db.Phrases.Remove(phrase);
        db.SaveChanges();
      }
    }

    public List<Phrase> GetPhrasesByTopic(int topicId)
    {
      using (var db = new RevolutionEntities1())
      {
        return db.Phrases.Where(p => p.TopicID == topicId).Select(p => new Phrase
          { ID = p.ID,
            Immediacy = p.Immediacy,
            IsQuestion = p.IsQuestion,
            IsSpontaneous = p.IsSpontaneous,
            PersonalityPhrases = p.PersonalityPhrases,
            Text = p.Text, Topic = p.Topic,
            TopicID = p.TopicID 
          }).ToList();
      }
    }
  }
}
