using System.Windows.Forms;

namespace youtube
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);//창 사이즈 조절
            this.Text = "Youtube Downloader";
            this.FormBorderStyle=FormBorderStyle.FixedSingle;//창 사이즈 고정
            
            downloadpathLabel=new Label();
            downloadpathLabel.Text="경로";
            downloadpathLabel.Location = new System.Drawing.Point(40,20);
            downloadpathLabel.Size = new System.Drawing.Size(45, 30);

            downloadpathTextBox=new TextBox();
            downloadpathTextBox.Location=new System.Drawing.Point(85,20);
            downloadpathTextBox.Size=new System.Drawing.Size(620-85,30);
            downloadpathTextBox.ReadOnly=true;

            downloadpathBtn=new Button();
            downloadpathBtn.Text="찾기";
            downloadpathBtn.Location=new System.Drawing.Point(650,20);
            downloadpathBtn.Size=new System.Drawing.Size(90,30);

            urlLabel = new Label();
            urlLabel.Text = "주소";
            urlLabel.Location = new System.Drawing.Point(40,70);
            urlLabel.Size = new System.Drawing.Size(45, 30);

            urlTextBox = new TextBox();
            urlTextBox.Location=new System.Drawing.Point(85,70);
            urlTextBox.Size=new System.Drawing.Size(620-85,30);

            downloadBtn=new Button();
            downloadBtn.Text="Download";
            downloadBtn.Location=new System.Drawing.Point(650,70);
            downloadBtn.Size=new System.Drawing.Size(90,30);

            thumbnailPictureBox=new PictureBox();
            thumbnailPictureBox.Location=new System.Drawing.Point(45,125);
            thumbnailPictureBox.Size=new System.Drawing.Size(486,360);

            // this.Controls.Add(btn1);
            // this.Controls.Add(btn2);

            this.Controls.Add(downloadpathLabel);
            this.Controls.Add(downloadpathTextBox);
            this.Controls.Add(downloadpathBtn);
            this.Controls.Add(urlLabel);
            this.Controls.Add(urlTextBox);
            this.Controls.Add(downloadBtn);
            this.Controls.Add(thumbnailPictureBox);

            this.MouseDown += new MouseEventHandler(MousePointXY);
        }

        // private Button btn1;
        // private Button btn2;
        private Label downloadpathLabel;
        private TextBox downloadpathTextBox;
        private Button downloadpathBtn;
        private Label urlLabel;
        private TextBox urlTextBox;
        private Button downloadBtn;
        private PictureBox thumbnailPictureBox;
        #endregion
    }
}