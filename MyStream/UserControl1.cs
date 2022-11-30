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
    public partial class UserControl1 : UserControl
    {
        public static UserControl1 instance;
        public static string animeId;
        public UserControl1()
        {
            InitializeComponent();
            instance = this;
            animeId = string.Empty;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void lblCategoryContent_Click(object sender, EventArgs e)
        {

        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void lblGenre_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            instance.Hide();
        }
    }
}
