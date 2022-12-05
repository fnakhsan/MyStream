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

        int p360 = 0;
        int p480 = 0;
        int p720 = 0;
        int p1080 = 0;
        int pDefault = 0;
        int pBackup = 0;

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

            for (int i = 0; i < streamList.sources.Length; i++)
            {
                switch (streamList.sources[i].quality)
                {
                    case "360p":
                        btn360p.Visible = true;
                        p360 = i;
                        break;
                    case "480p":
                        btn480p.Visible = true;
                        p480 = i;
                        break;
                    case "720p":
                        btn720p.Visible = true;
                        p720 = i;
                        break;
                    case "1080p":
                        btn1080p.Visible = true;
                        p1080 = i;
                        break;
                    case "backup":
                        pBackup = i;
                        break;
                    default:
                        pDefault = i;
                        btnDefault.Visible = true;
                        break;
                }
            }

            if (btnDefault.Visible && streamList.sources[pDefault].url != null)
            {
                axVLCPlugin21.playlist.add(streamList.sources[pDefault].url);
                axVLCPlugin21.playlist.play();
            }
            else if (btn1080p.Visible && streamList.sources[p1080].url != null)
            {
                axVLCPlugin21.playlist.add(streamList.sources[p1080].url);
                axVLCPlugin21.playlist.play();
            }
            else if (btn720p.Visible && streamList.sources[p720].url != null)
            {
                axVLCPlugin21.playlist.add(streamList.sources[p720].url);
                axVLCPlugin21.playlist.play();
            }
            else if (btn480p.Visible && streamList.sources[p480].url != null)
            {
                axVLCPlugin21.playlist.add(streamList.sources[p480].url);
                axVLCPlugin21.playlist.play();
            }
            else if (btn360p.Visible && streamList.sources[p360].url != null)
            {
                axVLCPlugin21.playlist.add(streamList.sources[p360].url);
                axVLCPlugin21.playlist.play();
            }
            else if (streamList.sources[pBackup].url != null)
            {
                axVLCPlugin21.playlist.add(streamList.sources[pBackup].url);
                axVLCPlugin21.playlist.play();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (streamList.sources[1].url != null)
            {
                if (axVLCPlugin21.playlist.isPlaying)
                {
                    axVLCPlugin21.playlist.togglePause();
                    btnPause.Text = "Resume";
                }
                else
                {
                    axVLCPlugin21.playlist.togglePause();
                    btnPause.Text = "Pause";
                }
            }
        }

        private void btn360p_Click(object sender, EventArgs e)
        {
            if (streamList.sources[p360].url != null)
            {
                axVLCPlugin21.playlist.add(streamList.sources[p360].url);
                axVLCPlugin21.playlist.next();
                axVLCPlugin21.playlist.play();
            }
        }

        private void btn480p_Click(object sender, EventArgs e)
        {
            if (streamList.sources[p480].url != null)
            {
                axVLCPlugin21.playlist.add(streamList.sources[p480].url);
                axVLCPlugin21.playlist.next();
                axVLCPlugin21.playlist.play();
            }
        }

        private void btn720p_Click(object sender, EventArgs e)
        {
            if (streamList.sources[p720].url != null)
            {
                axVLCPlugin21.playlist.add(streamList.sources[p720].url);
                axVLCPlugin21.playlist.next();
                axVLCPlugin21.playlist.play();
            }
        }

        private void btn1080p_Click(object sender, EventArgs e)
        {
            if (streamList.sources[p1080].url != null)
            {
                axVLCPlugin21.playlist.add(streamList.sources[p1080].url);
                axVLCPlugin21.playlist.next();
                axVLCPlugin21.playlist.play();
            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            if (streamList.sources[pDefault].url != null)
            {
                axVLCPlugin21.playlist.add(streamList.sources[pDefault].url);
                axVLCPlugin21.playlist.next();
                axVLCPlugin21.playlist.play();
            }
        }
    }
}
