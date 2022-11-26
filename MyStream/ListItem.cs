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
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }
        private string episodeId;

        public string EpisodeId
        {
            get { return episodeId; }
            set { episodeId = value; }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; label1.Text = value; }
        }

        private string episode;

        public string Episode
        {
            get { return episode; }
            set { episode = value; label2.Text = value; }
        }


        private Image picture;

        public Image Picture
        {
            get { return picture; }
            set { picture = value; pictureBox1.Image = value; }
        }
    }
}
