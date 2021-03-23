using Daniel_Hallneberg___Lab5_Scraper;
using System;
using System.Threading.Tasks;

namespace Tester
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Scraper scrape = new Scraper();

           await scrape.ScrapePicutes("www.gp.se");
        }
    }
}
