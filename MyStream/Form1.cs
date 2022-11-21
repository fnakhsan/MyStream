using MyStream.Model;
using MyStream.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Net.WebRequestMethods;

namespace MyStream
{
    public partial class Form1 : Form
    {
        //private BackgroundWorker backgroundWorker1;
        //private Button downloadButton;
        //private ProgressBar progressBar1;
        //private XmlDocument document = null;

        public Form1()
        {
            InitializeComponent();
            //backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            //backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            //backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var response = await ApiHelper.GetAll();
            List<Server> serverList = JsonConvert.DeserializeObject<List<Server>>(response);
            textBox1.Text = serverList[1].url;
            //webBrowser1.Navigate("https://gogohd.net/streaming.php?id=MTg4Mzgx&title=Spy+x+Family+Episode+12");
            richTextBox1.Text = ApiHelper.JsonFormatting(response);
            axWindowsMediaPlayer1.URL = "https://c-an-ca4.betterstream.cc:2223/hls-playback/b2325f15f875af1546c9697c8233c7513ed01882593048c114e0c2195b3d6130c3e55f42189da4861143dc0edb591969c3beb7ed16a5cbbee0a75bae793d1d2b95c8bbe94c2f21d4c20098c29dabf298589ce166406ddad131f8fbe26f4db90f86223e8d13bd96153dada9b2dd97611c1774f4a2c15cc0bad5aeebd1bf9e36a86dc1be897b53503d3ad5185de8ef1b80/index-f3-v1-a1.m3u8";
            axWindowsMediaPlayer1.settings.autoStart = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ProcessStartInfo psi = new ProcessStartInfo(@"D:\Dev\dekstop\ani-cli\ani-cli.exe");
            //psi.Arguments = "--login -i D:\\Dev\\dekstop\\ani-cli\\ani-cli  E://Work/Voice/Temp";
            //Process p = Process.Start(psi);
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            //// Start the download operation in the background.
            //this.backgroundWorker1.RunWorkerAsync();

            //// Disable the button for the duration of the download.
            //this.downloadButton.Enabled = false;

            // Once you have started the background thread you
            // can exit the handler and the application will
            // wait until the RunWorkerCompleted event is raised.

            // Or if you want to do something else in the main thread,
            // such as update a progress bar, you can do so in a loop
            // while checking IsBusy to see if the background task is
            // still running.

            //while (this.backgroundWorker1.IsBusy)
            //{
            //    progressBar1.Increment(1);
            //    // Keep UI messages moving, so the form remains
            //    // responsive during the asynchronous operation.
            //    Application.DoEvents();
            //}
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter_1(object sender, EventArgs e)
        {

        }

        //private void backgroundWorker1_DoWork(
        //object sender,
        //DoWorkEventArgs e)
        //{
        //    document = new XmlDocument();

        //    // Uncomment the following line to
        //    // simulate a noticeable latency.
        //    //Thread.Sleep(5000);

        //    // Replace this file name with a valid file name.
        //    document.Load(@"http://www.tailspintoys.com/sample.xml");
        //}

        //private void backgroundWorker1_RunWorkerCompleted(
        //    object sender,
        //    RunWorkerCompletedEventArgs e)
        //{
        //    // Set progress bar to 100% in case it's not already there.
        //    progressBar1.Value = 100;

        //    if (e.Error == null)
        //    {
        //        MessageBox.Show(document.InnerXml, "Download Complete");
        //    }
        //    else
        //    {
        //        MessageBox.Show(
        //            "Failed to download file",
        //            "Download failed",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Error);
        //    }

        //    // Enable the download button and reset the progress bar.
        //    this.downloadButton.Enabled = true;
        //    progressBar1.Value = 0;
        //}
    }
}
