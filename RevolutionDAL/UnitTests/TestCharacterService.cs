using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using SafeService;
using UnitTests.CharacterService;

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
  }
}
