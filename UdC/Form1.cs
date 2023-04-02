using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_url_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_reproducir_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos mp4 | *.mp4";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                wmp.URL = openFileDialog1.FileName;
            }
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            Form2 ventana2 = new Form2();
            ventana2.Show();
            this.Hide();
        }
    }
}
