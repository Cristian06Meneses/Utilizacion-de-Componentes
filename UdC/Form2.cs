using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdC
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos PDF | *.pdf";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pdf.src = openFileDialog1.FileName;
            }
            
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            Form3 ventana3 = new Form3();
            ventana3.Show();
            this.Hide();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            Form1 ventana1 = new Form1();
            ventana1.Show();
            this.Hide();
        }
    }
}
