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
        var ch = db.Characters.Where(c => c.ID == id && !c.Deleted).FirstOrDefault();
        return new Character { Deleted = ch.Deleted, FirstName = ch.FirstName, Gender = ch.Gender, ID = ch.ID, LastName = ch.LastName }; 
      }
    }

		public List<Character> GetAllCharacters()
		{
			using (var db = new RevolutionEntities1())
			{
				var chars = db.Characters;
				List<Character> charactersList = new List<Character>();

				foreach (Character character in chars)
				{
					charactersList.Add(new Character { 
						Deleted = character.Deleted, 
						FirstName = character.FirstName, 
						Gender = character.Gender, 
						ID = character.ID, 
						LastName = character.LastName });
				}

				return charactersList;
			}
		}

    public Character SaveCharacter(Character character)
    {
      using (var db = new RevolutionEntities1())
      {
        db.Characters.AddObject(character);
        db.SaveChanges();
        return character;
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
