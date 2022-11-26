﻿using MyStream.Model;
using MyStream.Properties;
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
        //private Button downloadButton;
        //private ProgressBar progressBar1;
        //private XmlDocument document = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Populate_Items();
            axVLCPlugin21.playlist.add("https://cache.387e6278d8e06083d813358762e0ac63.com/67ed5da6-6c61-11ed-84ed-246e963a41ed.m3u8?videoid=222937727069");
            axVLCPlugin21.playlist.play();
        }

        private async void Populate_Items()
        {
            var response = await ApiHelper.GetRecentEpisodes();
            RecentEpisode recentEpisodeList = JsonConvert.DeserializeObject<RecentEpisode>(response);
            ListItem[] listItem = new ListItem[recentEpisodeList.results.Length];

            for (int i = 0; i < recentEpisodeList.results.Length; i++)
            {
                listItem[i] = new ListItem();
                listItem[i].Title = recentEpisodeList.results[i].title;
                listItem[i].Episode = recentEpisodeList.results[i].episodeNumber.ToString();
                listItem[i].Picture = Bitmap.FromStream(WebRequest.Create(recentEpisodeList.results[i].image).GetResponse().GetResponseStream());
                listItem[i].EpisodeId = recentEpisodeList.results[i].episodeId;
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else flowLayoutPanel1.Controls.Add(listItem[i]);
                listItem[i].Cursor = Cursors.Hand;
                listItem[i].Click += new EventHandler(OnClick);
            }
        }

        private void OnClick(Object sender, EventArgs e)
        {
            ListItem itemClicked = (ListItem)sender;
            Form2 form2 = new Form2();
            form2.Show();
            Form2.episodeId = itemClicked.EpisodeId;
            MessageBox.Show(itemClicked.Title);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //var response = await ApiHelper.GetAll();
            //List<Server> serverList = JsonConvert.DeserializeObject<List<Server>>(response);
            //textBox1.Text = serverList[1].url;
            //webBrowser1.Navigate("https://gogohd.net/streaming.php?id=MTg4Mzgx&title=Spy+x+Family+Episode+12");
            //richTextBox1.Text = ApiHelper.JsonFormatting(response);
            //axWindowsMediaPlayer1.URL = "https://wwwx12.gogocdn.stream/videos/hls/fLhhC6zkdoMrrY2e_Uk9FQ/1669112123/184141/0789fd4f049c3ca2a49b860ea5d1f456/ep.1.1657688325.360.m3u8";
            //axWindowsMediaPlayer1.settings.autoStart = true;
            //axVLCPlugin21.playlist.add("https://wwwx12.gogocdn.stream/videos/hls/vpDypoCYa2YT1VAXOfM8tQ/1669138115/184141/0789fd4f049c3ca2a49b860ea5d1f456/ep.1.1657688325.360.m3u8");
            //axVLCPlugin21.playlist.play();
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            //userControl11.Show();
            //userControl11.BringToFront();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
