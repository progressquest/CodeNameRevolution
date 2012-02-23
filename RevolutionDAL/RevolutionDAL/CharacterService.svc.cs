using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RevolutionDAL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class CharacterService : ICharacterService
    {
        public Character GetCharacter(int id)
        {
            using (var db = new RevolutionEntities1())
            {
                return db.Characters.FirstOrDefault(c => c.ID == id);
            }
        }

        public void SaveCharacter(Character character)
        {
            using (var db = new RevolutionEntities1())
            {
                db.Characters.AddObject(character);
                db.SaveChanges();
            }
        }

        public void RemoveCharacter(int id)
        {
            using (var db = new RevolutionEntities1())
            {
                var character = db.Characters.FirstOrDefault(c => c.ID == id);
                if (character == null) return;
                character.Deleted = true;
                db.SaveChanges();
            }
        }
    }
}
