namespace ExtractAlbumsXPath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;
    using System.Xml;
    class XPathSolution
    {
        static void Main(string[] args)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("../../../catalogue.xml");
                var query = "/catalogue/album/[year>1996]/name";

                var albumNames = doc.SelectNodes(query);

                foreach (XmlNode name in albumNames)
                {
                    Console.WriteLine(name.InnerText);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
