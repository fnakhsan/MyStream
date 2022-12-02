using MyStream.Model;
using MyStream.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStream
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public static string episodeId;
        string response;
        StreamList streamList;
        public Form2()
        {
            InitializeComponent();
            instance = this;
            episodeId = string.Empty;
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            response = await ApiHelper.GetStreaming(episodeId);
            streamList = JsonConvert.DeserializeObject<StreamList>(response);
            if (streamList.sources[1].url != null)
            {
                axVLCPlugin21.playlist.add(streamList.sources[1].url);
                axVLCPlugin21.playlist.play();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (streamList.sources[1].url != null)
            {
                axVLCPlugin21.playlist.add(streamList.sources[1].url);
                axVLCPlugin21.playlist.play();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {

        }

        private void btn360p_Click(object sender, EventArgs e)
        {

        }

        private void btn480p_Click(object sender, EventArgs e)
        {

        }

        private void btn720p_Click(object sender, EventArgs e)
        {

        }

        private void btn1080p_Click(object sender, EventArgs e)
        {

        }
    }
}
