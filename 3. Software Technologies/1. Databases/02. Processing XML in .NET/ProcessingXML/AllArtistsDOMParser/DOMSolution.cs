namespace AllArtistsDOMParser
{
    using System;
    using System.Collections.Generic;
    using System.Xml;
    using System.IO;
    class DOMSolution
    {
        static void Main(string[] args)
        {
            var doc = new XmlDocument();
            try
            {
                doc.Load("../../../catalogue.xml");
                XmlElement root = doc.DocumentElement;

                Dictionary<string, int> artistAndAlbums = GetUniqueArtists(root);

                foreach (KeyValuePair<string,int> pair in artistAndAlbums)
                {
                    Console.WriteLine("{0} - {1} albums",pair.Key,pair.Value);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static Dictionary<string, int> GetUniqueArtists(XmlElement root)
        {
            var artistsAndAlbums = new Dictionary<string, int>();
            
            var artists = root.GetElementsByTagName("artist");

            foreach (XmlElement artist in artists)
            {
                var artistName = artist.InnerText;

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
