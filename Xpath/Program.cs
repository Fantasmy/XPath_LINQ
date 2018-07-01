using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Xpath
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read XML file
            XmlDocument doc = new XmlDocument();
            doc.Load("dogs.xml");

            // string variables taken from the xml nodes
            string race = doc.DocumentElement.SelectSingleNode("/dog/race").InnerText;
            string age = doc.DocumentElement.SelectSingleNode("/dog/age").InnerText;
            string name = doc.DocumentElement.SelectSingleNode("/dog/name").InnerText;

            // intantiation from xml data
            Assembly myAssembly = typeof(Program).Assembly;

            // obtention of type dog using reflection
            Type dogType = myAssembly.GetType("Xpath.Dog");

            if (dogType != null) // will continue only if dog type is found
            {
                object dog = Activator.CreateInstance(dogType, race, age, name);

                Dog dogAux = (Dog)dog; // dogAux variable of type Dog taken from the object dog
                Console.WriteLine(dogAux.Name);
            }

        }
    }
}
