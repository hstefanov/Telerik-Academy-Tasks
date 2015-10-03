namespace AllArtistsXPath
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml;
    class XPathSolution
    {
        static void Main(string[] args)
        {
            var doc = new XmlDocument();
            try
            {
                doc.Load("../../../catalogue.xml");


                foreach (KeyValuePair<string, int> pair in GetUniqueArtists(doc))
                {
                    Console.WriteLine("{0} - {1} album(s) ",pair.Key,pair.Value);
                }
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static Dictionary<string, int> GetUniqueArtists(XmlDocument doc)
        {
            var artistsAndAlbums = new Dictionary<string, int>();
            string xPathQuery = "/catalogue/album/artist";
            XmlNamespaceManager xmlnsManager = new XmlNamespaceManager(doc.NameTable);
            xmlnsManager.AddNamespace("", "urn:cool-music:bg");
            var artists = doc.SelectNodes(xPathQuery, xmlnsManager); // XPath

            foreach(XmlNode node in artists)
            {
                var artistName = node.InnerText;

                if (artistsAndAlbums.ContainsKey(artistName))
                {
                    artistsAndAlbums[artistName]++;
                }
                else
                {
                    artistsAndAlbums.Add(artistName, 1);
                }
            }

            return artistsAndAlbums;
        }
    }
}
