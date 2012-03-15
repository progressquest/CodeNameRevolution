using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using SafeService;
using UnitTests.CharacterService;
using ExpressionSerialization;

namespace UnitTests
{
  [TestFixture]
  public class TestCharacterService
  {
    private Character Character { get; set; }

    [TestFixtureSetUp]
    public void TestFixtureSetUp()
    {
      // Create a test character
      this.Character = new Character{FirstName = "progress", LastName = "quest", Gender = true };
      Service<ICharacterService>.Use(client => this.Character = client.SaveCharacter(this.Character));

      
    }

    [TestFixtureTearDown]
    public void TestFixtureTearDown()
    {
      if (this.Character != null)
      {
        Service<ICharacterService>.Use(client => client.RemoveCharacter(this.Character.ID));
      }


    }

    [Test]
    public void TestGetCharacter()
    {
      Character character = null;
      Service<ICharacterService>.Use(client => character = client.GetCharacter(this.Character.ID));
      Assert.AreEqual(this.Character.FirstName, character.FirstName);
      Assert.AreEqual(this.Character.LastName, character.LastName);
    }

    [Test]
    public void TestGetAllCharacters()
    {
      List<Character> characters = null;
      Service<ICharacterService>.Use(client => characters = client.GetAllCharacters());
      Assert.IsNotNull(characters);
      Assert.IsNotEmpty(characters);
    }

    [Test]
    public void TestGetCharacterByExpression()
    {
      // First, create the expression that we want the service to call.  In this case, we want to get any character with a first name of "progress"
      // Note: This expression MUST be of the type System.Linq.Expressions.Expression<Func<RevolutionDAL.Character, bool>> to succeed.
      System.Linq.Expressions.Expression<Func<RevolutionDAL.Character, bool>> exp = (c) => c.FirstName == "progress";
      // Next, create an ExpressionSerializer object
      var serializer = new ExpressionSerializer();
      // Now, serialize the expression...
      var query = serializer.Serialize(exp);
      // Now, we can send this to the DAL to be executed...
      List<Character> characters = null;
      Service<ICharacterService>.Use(client => characters = client.GetCharacters(query));
      Assert.IsNotNull(characters);
      Assert.IsNotEmpty(characters);
    }

  }
}
