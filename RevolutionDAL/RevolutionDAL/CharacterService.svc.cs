﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.EntityModel;
using System.Xml.Linq;
using ExpressionSerialization;

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
				return ch;
      }
    }

		public List<Character> GetAllCharacters()
		{
			using (var db = new RevolutionEntities1())
			{
				var chars = db.Characters.Select(ch => ch as Character).ToList();

				return chars;
			}
		}

    public Character SaveCharacter(Character character)
    {
			using (var db = new RevolutionEntities1())
			{
				Character ch = db.Characters.Where(c => c.ID == character.ID).FirstOrDefault();

				if (ch != default(Character))
				{
					db.Entry(ch).CurrentValues.SetValues(character);
				}
				else
				{
					db.Characters.Add(character);
				}
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

    public List<Character> GetCharacters(XElement query)
    {
      var serializer = new ExpressionSerializer();
      var expression = serializer.Deserialize<Func<Character, bool>>(query);
      if (expression == null)
        return null;
      
      using (var db = new RevolutionEntities1())
      {
        return db.Characters.Where(expression).ToList();
      }
    }

  }
}
