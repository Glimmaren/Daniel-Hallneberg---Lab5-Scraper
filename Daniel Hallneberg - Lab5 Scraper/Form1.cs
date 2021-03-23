using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daniel_Hallneberg___Lab5_Scraper
{
    public partial class Form1 : Form
    {
        Scraper scraper = new Scraper();
        public Form1()
        {
            InitializeComponent();           
        }

        private async void btn_Scrape_Click(object sender, EventArgs e)
        {       
            string url;
            chkbox_CheckAll.Checked = false;

            chkBox_ScrapedImages.Items.Clear();
            url = txtBox_URL.Text;
             
            scraper.URL = url;

            var htmlString = await scraper.GetHtmlStringAsync(scraper.URL);

            scraper.GetImagesInHTMLString(htmlString);

            foreach (var item in scraper.PicturesURL)
            {
                chkBox_ScrapedImages.Items.Add(item);
            }

            lbl_ImageCount.Text = scraper.PicturesURL.Count().ToString();

        }
        private void txtBox_URL_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                btn_Scrape_Click(this, new EventArgs());
            }
        }
        private void btn_SaveImg_Click(object sender, EventArgs e)
        {
            var imgURL = new List<string>();

            for (int i = 0; i < chkBox_ScrapedImages.Items.Count; i++)
            {
                if (chkBox_ScrapedImages.GetItemChecked(i))
                {
                    imgURL.Add(chkBox_ScrapedImages.Items[i].ToString());
                }
            }

            using (var dialog = new FolderBrowserDialog())
            {
                string saveImgpath;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    saveImgpath = dialog.SelectedPath;
                    Task.Run(async () => await scraper.QueSavesAsync(saveImgpath, imgURL));
                }
            }
        }
        private void chkbox_CheckAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_CheckAll.Checked)
            {
                for (int i = 0; i < chkBox_ScrapedImages.Items.Count; i++)
                {
                    chkBox_ScrapedImages.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < chkBox_ScrapedImages.Items.Count; i++)
                {
                    chkBox_ScrapedImages.SetItemChecked(i, false);
                }
            }
        }
    }
}
