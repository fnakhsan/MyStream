using MyStream.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStream
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var response = await ApiHelper.GetAll();
            richTextBox1.Text = ApiHelper.JsonFormatting(response);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
