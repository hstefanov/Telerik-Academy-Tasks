namespace XMLReaderExtractTitles
{
    using System;
    using System.IO;
    using System.Xml;
    class XMLReaderSolution
    {
        static void Main(string[] args)
        {
            try
            {
                using (XmlReader reader = new XmlTextReader("../../../catalogue.xml"))
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element 
                            && reader.Name == "title")
                        {
                            Console.WriteLine(reader.ReadElementContentAsString());
                        }
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
