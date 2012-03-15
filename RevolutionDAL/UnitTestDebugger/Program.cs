using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitTests;

namespace UnitTestDebugger
{
  class Program
  {
    static void Main(string[] args)
    {
      #region TestCharacterService

      var tester = new TestCharacterService();
      bool success = false;
      try
      {
        tester.TestFixtureSetUp();

        tester.TestGetCharacter();
        Console.WriteLine("TestGetCharacer passed.");
        tester.TestGetAllCharacters();
        Console.WriteLine("TestGetAllCharacer passed.");
        tester.TestGetCharacterByExpression();
        Console.WriteLine("TestGetCharacterByExpression passed.");
        // add tests here
      }
      catch (Exception ex)
      {
        Console.WriteLine("================================= FAILED !!!! ================================");
        Console.WriteLine(ex.Message);
      }
      finally
      {
        tester.TestFixtureTearDown();
        if (success)
          Console.WriteLine("**************************** SUCCESS !!!!!! ********************************");
      }

      #endregion


      Console.WriteLine("Done");
      Console.ReadKey();
    }
  }
}
