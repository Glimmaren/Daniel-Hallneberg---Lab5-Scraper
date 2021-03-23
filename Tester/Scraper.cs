using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Daniel_Hallneberg___Lab5_Scraper
{
    class Scraper
    {
        public List<string> Pictures { get; set; }
        
        public async Task<string> ScrapePicutes(string path)
        {
            HttpClient client = new HttpClient();
            string resposeBody = await client.GetStringAsync(path);

            return resposeBody;
        }
    }
}
