﻿using System;
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
        public UserControl1()
        {
            InitializeComponent();
            instance = this;

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

        private void button1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile("D:\\GDSC\\asset_1.png");
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblCategoryContent_Click(object sender, EventArgs e)
        {

        }
    }
}
