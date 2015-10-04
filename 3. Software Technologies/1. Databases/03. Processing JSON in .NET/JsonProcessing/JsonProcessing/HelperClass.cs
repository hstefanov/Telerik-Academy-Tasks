namespace JsonProcessing
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Collections.Generic;
    using System.Net;
    using System.Text;
    using System.Xml;
    using System.Linq;
    using System.IO;
    public static class HelperClass
    {
        public static void DownloadRss(string url, string fileName)
        {
            WebClient webClient = new WebClient { Encoding = Encoding.UTF8 };
            webClient.DownloadFile(url, fileName);
        }

        public static XmlDocument GetXml(string path)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(path);
            return xml;
        }

        public static JObject GetJsonObject(XmlDocument xmlDoc)
        {
            string jsonDoc = JsonConvert.SerializeXmlNode(xmlDoc);
            JObject jsonObj = JObject.Parse(jsonDoc);
            return jsonObj;
        }

        public static IEnumerable<JToken> GetVideosTitles(JObject jsonObj)
        {
            return jsonObj["feed"]["entry"].Select(entry => entry["title"]);
        }

        public static IEnumerable<Video> GetVideos(JObject jsonObj)
        {
            var videos = jsonObj["feed"]["entry"]
                .Select(entry => JsonConvert.DeserializeObject<Video>(entry.ToString()));

            return videos;
        }

        public static string GetHtmlString(IEnumerable<Video> videos)
        {
            StringBuilder htmlBuilder = new StringBuilder();

            htmlBuilder.Append("<!DOCTYPE html><html><body>");
            foreach (var video in videos)
            {
                htmlBuilder.AppendFormat("<div style=\"float:left;width: 420px; height: 450px; padding:10px;\"" +
                                          "margin:5px; background-color:grey; border-radius:10px\">" +
                                          "<iframe width=\"420\" height=\"345\" " +
                                          "src=\"http://www.youtube.com/embed/{1}?autoplay=0\" " +
                                          "frameborder=\"0\" allowfullscreen></iframe>" +
                                          "<h3>{2}</h3><a href=\"{0}\">Go to YouTube</a></div>",
                                          video.Link.Href,video.Id,video.Title);
            }
            htmlBuilder.Append("</body></html>");

            return htmlBuilder.ToString();
        }

        public static void SaveHtml(string html, string htmlName)
        {
            using (StreamWriter writer = new StreamWriter("../../" + htmlName, false, Encoding.UTF8))
            {
                writer.Write(html);
            }

            var currentDir = Directory.GetCurrentDirectory();
            var htmlDir = currentDir.Substring(0, currentDir.IndexOf("bin\\Debug")) + htmlName;

            System.Console.WriteLine("Html dir: {0}", htmlDir);
        }
    }
}
