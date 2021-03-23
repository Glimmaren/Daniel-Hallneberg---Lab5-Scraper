using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daniel_Hallneberg___Lab5_Scraper
{
    class Scraper
    {
        public List<string> PicturesURL = new List<string>();
        private string _uRL;
        public string URL 
        { 
            get 
            { 
                return _uRL; 
            } 
            
            set 
            {
                if (!value.Contains("www."))
                {
                    _uRL = "http://www." + value;
                }
                else if (!value.Contains("http://"))
                {
                    _uRL = "http://" + value;
                }
            }
        }
        public async Task<string> GetHtmlStringAsync(string path)
        {
            this.URL = path;
            string responseBody = "";
            HttpClient client = new HttpClient();

            try
            {
                responseBody = await client.GetStringAsync(path);
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show("Invalid Address!");
            }
            
            return responseBody;
        }
        public void GetImagesInHTMLString(string htmlString)
        {
            PicturesURL.Clear();
            string pattern = @"<(img)\b[^>]*>";

            Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(htmlString);

            for (int i = 0, l = matches.Count; i < l; i++)
            {
                var tempHtml = Regex.Match(matches[i].ToString(), "<img.+?src=[\"'](.+?)[\"'].+?>", RegexOptions.IgnoreCase).Groups[1].Value;

                if (!tempHtml.Equals(""))
                {
                    if (tempHtml.Contains("http"))
                    {
                        PicturesURL.Add(tempHtml);
                    }
                    else
                    {
                        PicturesURL.Add(this.URL + tempHtml);
                    }
                }                    
            }
        }
        public async Task SaveImageAsync(string path, string url)
        {
            using (WebClient client = new WebClient())
            {

                var image = await client.DownloadDataTaskAsync(url);

                if (url.Contains("png"))
                {
                    File.WriteAllBytes(path + ".png", image);
                }
                else if (url.Contains("jpg"))
                {
                    File.WriteAllBytes(path + ".jpg", image);
                }
                else if (url.Contains("svg"))
                {
                    File.WriteAllBytes(path + ".svg", image);
                }
                else if (url.Contains("gif"))
                {
                    File.WriteAllBytes(path + ".gif", image);
                }
                else if (url.Contains("bmp"))
                {
                    File.WriteAllBytes(path + ".bmp", image);
                }
            }
        }
        public async Task QueSavesAsync(string imgPath, List<string> imgURL)
        {
            List<Task> saveImageTasks = new List<Task>();

            for (int i = 0; i < imgURL.Count; i++)
            {
                saveImageTasks.Add(this.SaveImageAsync(imgPath + "\\image" + i.ToString(), imgURL[i]));               
            }

            await Task.WhenAny(saveImageTasks);

        }// Inte helt övertygad om det va det här du menade med "WhenAny" i beskrivningen men det funkar i alla fall=)
    }
}
