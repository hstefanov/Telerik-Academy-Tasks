namespace JsonProcessing
{
    using Newtonsoft.Json.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.Xml;

    class Solution
    {
        private const string RssLink = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
        private const string XmlPath = "videos.xml";
        private const string HtmlName = "index.html";
        static void Main(string[] args)
        {
            HelperClass.DownloadRss(RssLink,XmlPath);
            XmlDocument xmlDocument = HelperClass.GetXml(XmlPath);
            JObject jsonObj = HelperClass.GetJsonObject(xmlDocument);
            IEnumerable<JToken> titles = HelperClass.GetVideosTitles(jsonObj);
            foreach (var title in titles)
            {
                System.Console.WriteLine(title);
            }
            IEnumerable<Video> videos = HelperClass.GetVideos(jsonObj);
            string html = HelperClass.GetHtmlString(videos);
            HelperClass.SaveHtml(html, HtmlName);
        }
    }
}
