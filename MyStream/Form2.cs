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
        public Form2()
        {
            InitializeComponent();
            instance = this;
            episodeId = string.Empty;
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            var response = await ApiHelper.GetStreaming(episodeId);
            StreamList streamList = JsonConvert.DeserializeObject<StreamList>(response);
            if (streamList.sources[1].url != null)
            {
                axVLCPlugin21.playlist.add(streamList.sources[1].url);
                axVLCPlugin21.playlist.play();
            }
        }
    }
}
