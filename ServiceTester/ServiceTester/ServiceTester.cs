using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceTester.CharacterService;
using SafeService;
using System.Configuration;
using System.IO;

namespace ServiceTester
{
    public class Program
    {
        static void Main(string[] args)
        {
            //List<Character> myObject = new List<Character>();
            //System.Xml.Serialization.XmlSerializer serializer =
            //   new System.Xml.Serialization.XmlSerializer(myObject.GetType());
            //serializer.Serialize(new MemoryStream(), myObject);
            
            //CharacterServiceClient client = new CharacterServiceClient();

            //List<Character> chars = client.GetAllCharacters();

            Service<ICharacterService>.Use(client =>
            {
                List<Character> chars = client.GetAllCharacters();
                foreach (Character character in chars)
                {
                    Console.WriteLine(string.Format("FirstName: {0}, LastName: {1}, Gender: {2}, Deleted: {3}", character.FirstName, character.LastName, character.Gender ? "Male" : "Female", character.Deleted ? "True" : "False"));
                }
                Console.ReadKey();
            });

            //Console.WriteLine(typeof(ICharacterService).ToString());
            //Console.ReadKey();

            //client.Close();
        }
    }
}
