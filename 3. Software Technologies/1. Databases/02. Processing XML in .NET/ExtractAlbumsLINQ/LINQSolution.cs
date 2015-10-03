namespace ExtractAlbumsLINQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;
    using System.IO;

    class LINQSolution
    {
        static void Main(string[] args)
        {
            try
            {
                var doc = XDocument.Load("../../../catalogue.xml");

                var albumNames = from album in doc.Descendants("album")
                                 where int.Parse(album.Element("year").Value) > 1996
                                 select album.Element("name").Value;

                Console.WriteLine(string.Join(Environment.NewLine, albumNames));
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
