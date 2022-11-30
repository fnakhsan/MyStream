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
    public partial class ListEpisode : UserControl
    {
        public ListEpisode()
        {
            InitializeComponent();
        }

        private string episodeId;

        public string EpisodeId
        {
            get { return episodeId; }
            set { episodeId = value; }
        }

        private int episodeNumber;

        public int EpisodeNumber
        {
            get { return episodeNumber; }
            set { episodeNumber = value; lblEpisode.Text = $"Episode {value}"; }
        }

        private void lblEpisode_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Form2.episodeId = EpisodeId;
            form2.Show();
            MessageBox.Show($"Episode {EpisodeNumber}");
        }
    }
}
