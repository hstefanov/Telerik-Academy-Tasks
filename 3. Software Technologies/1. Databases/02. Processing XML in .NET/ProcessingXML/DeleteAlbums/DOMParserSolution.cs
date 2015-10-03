namespace DeleteAlbums
{
    using System;
    using System.IO;
    using System.Xml;

    class DOMParserSolution
    {
        static void Main(string[] args)
        {
            var doc = new XmlDocument();
            try
            {
                doc.Load("../../../catalogue.xml");
                var root = doc.DocumentElement;
                DeleteAlbumsWithPrice(root, 20.0);
                doc.Save("../../../catalogueRemovedPrice.xml");
                Console.WriteLine("New catalogue saved as catalogueRemovedPrice.xml");
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void DeleteAlbumsWithPrice(XmlElement root,double maxPrice)
        {
            foreach (XmlElement album in root.ChildNodes)
            {
                string xmlPrice = album["price"].InnerText;
                double price = double.Parse(xmlPrice.Replace('.', ','));
                
                if (price > maxPrice)
                {
                    root.RemoveChild(album);
                }
            }
        }
    }
}
