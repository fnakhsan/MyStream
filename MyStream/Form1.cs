using MyStream.Model;
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
using System.Windows.Interop;
using System.Xml;
using static System.Net.WebRequestMethods;

namespace MyStream
{
    public partial class Form1 : Form
    {
        private string condition = "recent";
        private int page = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetRecent();
        }

        private async void GetRecent(string page = "1")
        {
            flowLayoutPanel1.Controls.Clear();
            var response = await ApiHelper.GetRecentEpisodes(page);
            RecentEpisode recentEpisodeList = JsonConvert.DeserializeObject<RecentEpisode>(response);
            ListItem[] listItem = new ListItem[recentEpisodeList.results.Length];

            for (int i = 0; i < recentEpisodeList.results.Length; i++)
            {
                listItem[i] = new ListItem();
                listItem[i].Title = recentEpisodeList.results[i].title;
                listItem[i].Episode = "Eps : " + recentEpisodeList.results[i].episodeNumber.ToString();
                listItem[i].Picture = Bitmap.FromStream(WebRequest.Create(recentEpisodeList.results[i].image).GetResponse().GetResponseStream());
                listItem[i].EpisodeId = recentEpisodeList.results[i].episodeId;
                listItem[i].EpisodeNumber = recentEpisodeList.results[i].episodeNumber;
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else flowLayoutPanel1.Controls.Add(listItem[i]);
                listItem[i].Cursor = Cursors.Hand;
                listItem[i].Click += new EventHandler(OnClick);
            }
            condition = "recent";
            if (page == "1")
            {
                btnPrevious.Visible = false;
            }
            else
            {
                btnPrevious.Visible = true;
            }
            if (recentEpisodeList.hasNextPage)
            {
                btnNext.Visible = true;
            }
            else
            {
                btnNext.Visible = false;
            }
        }

        private async void GetTop(string page = "1")
        {
            flowLayoutPanel1.Controls.Clear();
            var response = await ApiHelper.GetTopAiring(page);
            TopAiring topAiringList = JsonConvert.DeserializeObject<TopAiring>(response);
            ListItem[] listItem = new ListItem[topAiringList.results.Length];

            for (int i = 0; i < topAiringList.results.Length; i++)
            {
                listItem[i] = new ListItem();
                listItem[i].Title = topAiringList.results[i].title;
                var genre = string.Join(", ", topAiringList.results[i].genres);
                listItem[i].Episode = genre;
                listItem[i].Picture = Bitmap.FromStream(WebRequest.Create(topAiringList.results[i].image).GetResponse().GetResponseStream());
                listItem[i].EpisodeId = topAiringList.results[i].id;
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else flowLayoutPanel1.Controls.Add(listItem[i]);
                listItem[i].Cursor = Cursors.Hand;
                listItem[i].Click += new EventHandler(OnClickInfo);
            }
            condition = "top";
            if (page == "1")
            {
                btnPrevious.Visible = false;
            }
            else
            {
                btnPrevious.Visible = true;
            }
            if (topAiringList.hasNextPage)
            {
                btnNext.Visible = true;
            }
            else
            {
                btnNext.Visible = false;
            }
        }

        private async void Search(string page = "1")
        {
            flowLayoutPanel1.Controls.Clear();
            var response = await ApiHelper.GetAnime(tbSearch.Text.ToString(), page);
            AnimeSearch animeSearch = JsonConvert.DeserializeObject<AnimeSearch>(response);
            ListItem[] listItem = new ListItem[animeSearch.results.Length];

            for (int i = 0; i < animeSearch.results.Length; i++)
            {
                listItem[i] = new ListItem();
                listItem[i].Title = animeSearch.results[i].title;
                listItem[i].Episode = animeSearch.results[i].releaseDate;
                listItem[i].Picture = Bitmap.FromStream(WebRequest.Create(animeSearch.results[i].image).GetResponse().GetResponseStream());
                listItem[i].EpisodeId = animeSearch.results[i].id;           
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else flowLayoutPanel1.Controls.Add(listItem[i]);
                listItem[i].Cursor = Cursors.Hand;
                listItem[i].Click += new EventHandler(OnClickInfo);
            }
            condition = "search";
            if (page == "1")
            {
                btnPrevious.Visible = false;
            }
            else
            {
                btnPrevious.Visible = true;
            }
            if (animeSearch.hasNextPage)
            {
                btnNext.Visible = true;
            }
            else
            {
                btnNext.Visible = false;
            }
        }

        private void OnClick(Object sender, EventArgs e)
        {
            ListItem itemClicked = (ListItem)sender;
            Form2 form2 = new Form2();
            Form2.episodeId = itemClicked.EpisodeId;
            Form2.episodeName = itemClicked.EpisodeNumber.ToString();
            form2.Show();
        }

        private void OnClickInfo(Object sender, EventArgs e)
        {
            ListItem itemClicked = (ListItem)sender;
            Form3 form3 = new Form3();
            Form3.animeId = itemClicked.EpisodeId;
            form3.Show();
        }

        private void btnRecent_Click(object sender, EventArgs e)
        {
            page = 1;
            GetRecent(page.ToString());
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            page = 1; 
            GetTop(page.ToString());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            page = 1;
            Search(page.ToString());
            tbSearch.Text = "";
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            page--;
            switch (condition)
            {
                case "recent":
                    GetRecent(page.ToString());
                    break;
                case "top":
                    GetTop(page.ToString());
                    break;
                case "search":
                    Search(page.ToString());
                    break;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            page++;
            switch (condition)
            {
                case "recent":
                    GetRecent(page.ToString());
                    break;
                case "top":
                    GetTop(page.ToString());
                    break;
                case "search":
                    Search(page.ToString());
                    break;
            }
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }            
        }
    }
}
