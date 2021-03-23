
namespace Daniel_Hallneberg___Lab5_Scraper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBox_URL = new System.Windows.Forms.TextBox();
            this.btn_Scrape = new System.Windows.Forms.Button();
            this.chkBox_ScrapedImages = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ImageCount = new System.Windows.Forms.Label();
            this.btn_SaveImg = new System.Windows.Forms.Button();
            this.chkbox_CheckAll = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtBox_URL
            // 
            this.txtBox_URL.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtBox_URL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_URL.Location = new System.Drawing.Point(0, 0);
            this.txtBox_URL.Name = "txtBox_URL";
            this.txtBox_URL.Size = new System.Drawing.Size(623, 33);
            this.txtBox_URL.TabIndex = 0;
            this.txtBox_URL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_URL_KeyDown);
            // 
            // btn_Scrape
            // 
            this.btn_Scrape.Location = new System.Drawing.Point(629, 0);
            this.btn_Scrape.Name = "btn_Scrape";
            this.btn_Scrape.Size = new System.Drawing.Size(127, 34);
            this.btn_Scrape.TabIndex = 1;
            this.btn_Scrape.Text = "Extrect";
            this.btn_Scrape.UseVisualStyleBackColor = true;
            this.btn_Scrape.Click += new System.EventHandler(this.btn_Scrape_Click);
            // 
            // chkBox_ScrapedImages
            // 
            this.chkBox_ScrapedImages.CheckOnClick = true;
            this.chkBox_ScrapedImages.FormattingEnabled = true;
            this.chkBox_ScrapedImages.HorizontalScrollbar = true;
            this.chkBox_ScrapedImages.Location = new System.Drawing.Point(0, 40);
            this.chkBox_ScrapedImages.Name = "chkBox_ScrapedImages";
            this.chkBox_ScrapedImages.ScrollAlwaysVisible = true;
            this.chkBox_ScrapedImages.Size = new System.Drawing.Size(999, 580);
            this.chkBox_ScrapedImages.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(762, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Image count:";
            // 
            // lbl_ImageCount
            // 
            this.lbl_ImageCount.AutoSize = true;
            this.lbl_ImageCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ImageCount.Location = new System.Drawing.Point(909, 3);
            this.lbl_ImageCount.Name = "lbl_ImageCount";
            this.lbl_ImageCount.Size = new System.Drawing.Size(0, 32);
            this.lbl_ImageCount.TabIndex = 4;
            // 
            // btn_SaveImg
            // 
            this.btn_SaveImg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_SaveImg.Location = new System.Drawing.Point(201, 624);
            this.btn_SaveImg.Name = "btn_SaveImg";
            this.btn_SaveImg.Size = new System.Drawing.Size(798, 45);
            this.btn_SaveImg.TabIndex = 5;
            this.btn_SaveImg.Text = "Save Images";
            this.btn_SaveImg.UseVisualStyleBackColor = true;
            this.btn_SaveImg.Click += new System.EventHandler(this.btn_SaveImg_Click);
            // 
            // chkbox_CheckAll
            // 
            this.chkbox_CheckAll.AutoSize = true;
            this.chkbox_CheckAll.Location = new System.Drawing.Point(12, 640);
            this.chkbox_CheckAll.Name = "chkbox_CheckAll";
            this.chkbox_CheckAll.Size = new System.Drawing.Size(76, 19);
            this.chkbox_CheckAll.TabIndex = 6;
            this.chkbox_CheckAll.Text = "Check All";
            this.chkbox_CheckAll.UseVisualStyleBackColor = true;
            this.chkbox_CheckAll.CheckedChanged += new System.EventHandler(this.chkbox_CheckAll_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 674);
            this.Controls.Add(this.chkbox_CheckAll);
            this.Controls.Add(this.btn_SaveImg);
            this.Controls.Add(this.lbl_ImageCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkBox_ScrapedImages);
            this.Controls.Add(this.btn_Scrape);
            this.Controls.Add(this.txtBox_URL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_URL;
        private System.Windows.Forms.Button btn_Scrape;
        private System.Windows.Forms.CheckedListBox chkBox_ScrapedImages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ImageCount;
        private System.Windows.Forms.Button btn_SaveImg;
        private System.Windows.Forms.CheckBox chkbox_CheckAll;
    }
}

