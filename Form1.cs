using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

using System.Net;
using System.IO;

namespace youtube
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            urlTextBox.TextChanged += urlTextBoxTextChanged;
            // btn1.Click += btn1Click;
            // btn2.Click += btn2Click;
        }

        // private void btn1Click(object sender, EventArgs e){
        //     if(btn1.Text.Length<3){
        //         btn1.Text+="?";
        //     }
        //     else{
        //         btn1.Text = "";
        //     }
        //     Console.WriteLine(btn1.Text);
        // }

        // private void btn2Click(object sender, EventArgs e){//폴더 선택 이벤트
        //     CommonOpenFileDialog d = new CommonOpenFileDialog();
        //     d.IsFolderPicker = true;
        //     if(d.ShowDialog()==CommonFileDialogResult.Ok){
        //         btn1.Text = d.FileName;
        //         Console.WriteLine(btn1.Text);
        //         String option = "-o "+d.FileName+"\"\\download\\%(title)s.%(ext)s\" https://www.youtube.com/watch?v=1vryJp_ylVQ -v";
        //         var sample = Process.Start(Application.StartupPath+"/yt-dlp.exe",option);
        //         Console.WriteLine(option);
        //     }
        // }
        // private void thumbnailBtnClick(object sender, EventArgs e){
        //     String URL = "https://img.youtube.com/vi/1bNNQBDeCtY/0.jpg";
        //     this.thumbnailPicbox.Image = getImageURL(URL);
        // }
        private void urlTextBoxTextChanged(object sender, EventArgs e){
            if(urlTextBox.Text.Length>16){
                String[] strArray = urlTextBox.Text.Split('/');
                // for(int i=0;i<strArray.Length;i++){
                //     Console.WriteLine(strArray[i]);
                // }
                if(strArray.Length!=4){
                    return;
                }
                if(String.Compare(strArray[2],"youtu.be",false)==0||String.Compare(strArray[2],"www.youtube.com",false)==0){
                    Console.WriteLine(strArray[2]);
                    strArray=strArray[3].Split('=');
                    this.thumbnailPictureBox.Image=getImageURL(strArray[strArray.Length-1]);
                }
            }
        }
        private Image getImageURL(String url){
            url = "https://img.youtube.com/vi/"+url+"/0.jpg";
            Console.WriteLine(url);
            using(WebClient client = new WebClient()){
                byte[] img;
                try
                {
                    img = client.DownloadData(url);
                }
                catch (System.Exception)
                {
                    return null;
                    throw;
                }
                using(MemoryStream mes = new MemoryStream(img)){
                    Image i = Image.FromStream(mes);
                    return i;
                }
            }
        }
        // private void thumbnailPictureBoxImage()

        private void MousePointXY(object sender, MouseEventArgs e){
            Console.WriteLine("Sender : {0}", ((Form)sender).Text);
            Console.WriteLine("X : {0}, Y : {1}", e.X, e.Y);
            Console.WriteLine("Button : {0}, Clicks : {1}", e.Button, e.Clicks);
            Console.WriteLine();
        }
    }
}
