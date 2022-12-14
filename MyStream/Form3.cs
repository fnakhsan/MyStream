using MyStream.Model;
using MyStream.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStream
{
    public partial class Form3 : Form
    {
        public static Form3 instance;
        public static string animeId;
        AnimeInfo animeInfo;
        public Form3()
        {
            InitializeComponent();
            instance = this;
            animeId = string.Empty;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void Form3_Load(object sender, EventArgs e)
        {
            var response = await ApiHelper.GetAnimeInfo(animeId);
            animeInfo = JsonConvert.DeserializeObject<AnimeInfo>(response);
            lblTitle.Text = animeInfo.title;
            pictureBox1.Image = Bitmap.FromStream(WebRequest.Create(animeInfo.image).GetResponse().GetResponseStream());
            lblCategoryContent.Text = animeInfo.type;
            var genre = string.Join(", ", animeInfo.genres);
            lblGenreContent.Text = genre;
            lblSynopsisContent.Text = animeInfo.description;
            lblReleasedContent.Text = animeInfo.releaseDate;
            lblStatusContent.Text = animeInfo.status;
            if (animeInfo.episodes.Length != 0)
            {
                lblSearch.Text = $"Search Episode ({animeInfo.episodes[0].number} - {animeInfo.episodes.Length}) : ";
            }

            flowLayoutPanel2.Controls.Clear();
            ListEpisode[] listEpisode = new ListEpisode[animeInfo.episodes.Length];
            for (int i = 0; i < animeInfo.episodes.Length; i++)
            {
                listEpisode[i] = new ListEpisode();
                listEpisode[i].EpisodeId = animeInfo.episodes[i].id;
                listEpisode[i].EpisodeNumber = animeInfo.episodes[i].number;
                listEpisode[i].Cursor = Cursors.Hand;

                if (flowLayoutPanel2.Controls.Count < 0)
                {
                    flowLayoutPanel2.Controls.Clear();
                }
                else flowLayoutPanel2.Controls.Add(listEpisode[i]);
            }
        }

        private void Search(int episode)
        {
            int maxEpisode = animeInfo.episodes.Length - 1;
            if (episode > 0)
            {
                episode = episode - 1;
            }
            if (episode > maxEpisode)
            {
                MessageBox.Show($"Please enter episode between {animeInfo.episodes[0].number} and {animeInfo.episodes[maxEpisode].number}");
            }
            else
            {
                listEpisode1.EpisodeId = animeInfo.episodes[episode].id;
                listEpisode1.EpisodeNumber = animeInfo.episodes[episode].number;
                listEpisode1.Cursor = Cursors.Hand;
                listEpisode1.Visible = true;
            } 
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int episode = int.Parse(tbSearch.Text);
                    Search(episode);
                }
                catch (FormatException fe)
                {
                    Console.WriteLine(fe.Message);
                }
                tbSearch.Text = "";
            }
        }
    }
}
