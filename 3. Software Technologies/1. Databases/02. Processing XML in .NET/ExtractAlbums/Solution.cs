namespace ExtractAlbums
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml;

    class Solution
    {
        static void Main(string[] args)
        {
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter("../../../albums.xml", Encoding.UTF8))
                {
                    writer.Formatting = Formatting.Indented;
                    writer.IndentChar = ' ';
                    writer.Indentation = 2;

                    writer.WriteStartDocument();
                    writer.WriteStartElement("albums");

                    using (XmlReader reader = XmlReader.Create("../../../catalogue.xml"))
                    {
                        while (reader.Read())
                        {
                            if (reader.NodeType == XmlNodeType.Element)
                            {
                                if (reader.Name == "name")
                                {
                                    writer.WriteStartElement("album");
                                    writer.WriteElementString("name", reader.ReadElementContentAsString());
                                }
                                else if (reader.Name == "artist")
                                {
                                    writer.WriteElementString("artists",reader.ReadElementContentAsString());
                                    writer.WriteEndElement();
                                }
                            }
                        }
                    }

                    writer.WriteEndDocument();
                    Console.WriteLine("albums saved as albums.xml");
                } 
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
