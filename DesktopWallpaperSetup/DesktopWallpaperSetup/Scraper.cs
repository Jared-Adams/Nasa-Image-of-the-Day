using System;
using System.Net;
using HtmlAgilityPack;
namespace DesktopWallpaperSetup
{
    public static class Scraper
    {
        internal static string GetDomainNode(string domain, string xPath)
        {
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(domain);
            var returnString = htmlDoc.DocumentNode.SelectSingleNode(xPath).GetAttributeValue("href", "Node not found.");

            return "https://apod.nasa.gov/apod/" + returnString.ToString();
        }

        internal static void DownloadImageNode(string domain, string xPath, string storagePath)
        {
            using (WebClient client = new WebClient())
            {
                client.DownloadFileAsync(new Uri(GetDomainNode(domain, xPath)), storagePath);
            }
        }
    }
}
