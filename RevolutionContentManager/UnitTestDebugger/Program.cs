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

            var tester = new Class1();
            try
            {
                tester.TestFixtureSetUp();

                // add tests here
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                tester.TestFixtureTearDown();
            }

            #endregion


            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
