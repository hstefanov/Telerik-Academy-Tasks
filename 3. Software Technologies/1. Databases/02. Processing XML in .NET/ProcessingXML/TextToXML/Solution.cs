namespace TextToXML
{
    using System;
    using System.IO;
    using System.Xml.Linq;
    class Solution
    {
        static void Main(string[] args)
        {
            var person = new Person();

            try
            {
                using (StreamReader reader = new StreamReader("../../../person.txt"))
                {
                    person.Name = reader.ReadLine();
                    person.Phone = reader.ReadLine();
                    person.Adress = reader.ReadLine();
                }

                var personElement = new XElement("person",
                    new XElement("name", person.Name),
                    new XElement("phone", person.Phone),
                    new XElement("adress", person.Adress));

                Console.WriteLine("Person saved as person.xml");
                personElement.Save("../../../person.xml");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
