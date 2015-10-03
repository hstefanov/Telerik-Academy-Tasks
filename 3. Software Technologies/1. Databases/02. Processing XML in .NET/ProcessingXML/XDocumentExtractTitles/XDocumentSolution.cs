namespace XDocumentExtractTitles
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Xml.Linq;

    class XDocumentSolution
    {
        static void Main(string[] args)
        {
            try
            {

                var doc = XDocument.Load("../../../catalogue.xml");

                var albums = doc.Element("catalogue")
                    .Elements("album");

                var titles = from title in albums.Descendants("title") select title.Value;

                foreach (var title in titles)
                {
                    Console.WriteLine(title);
                }

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
