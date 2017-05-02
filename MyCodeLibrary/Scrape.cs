using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyScrape
{
    public class Scrape
    {   
        public void ScrapeWebPage(string address)
        {
            WebClient client = new WebClient();
            string html =client.DownloadString(address);
            Console.WriteLine(html);
            Console.ReadLine();
        }
    }
}
 