using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesktopWallpaperSetup
{
    class Program
    {
        public string StoragePath { get; set; }
        static void Main(string[] args)
        {                                                             //  | Sept 14 | Sept 11 | Nov 23
                                                                      //  V 190914/ 190911/ 191123 - last 2 year, month, day
            Scraper.DownloadImageNode(@"https://apod.nasa.gov/apod/ap" + DateTime.Now.ToString("yyMMdd") + ".html", //link of today
                                        "//html/body/center[1]/p[2]/a/@href", //node
                                        $@"../../Images/Image " +  // storage
                                        DateTime.Now.ToString("dd-MM-yyyy") + ".png"); //file name coordinated with image date 
            Thread.Sleep(1000); //prevents image corruption            
        }
    }
}
