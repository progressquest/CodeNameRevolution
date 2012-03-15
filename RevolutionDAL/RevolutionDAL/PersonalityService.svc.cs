using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using System.Data.EntityModel;

namespace RevolutionDAL
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Personality" in code, svc and config file together.
  public class PersonalityService : IPersonalityService
  {
    public PersonalityType GetPersonalityType(int id)
    {
      using (var db = new RevolutionEntities1())
      {
        return db.PersonalityTypes.FirstOrDefault(pt => pt.ID == id);
      }
    }

    public List<PersonalityType> GetAllPersonalityTypes()
    {
      using (var db = new RevolutionEntities1())
      {
        return db.PersonalityTypes.ToList();
      }
    }
  }
}
