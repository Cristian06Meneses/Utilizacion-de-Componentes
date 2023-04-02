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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_ir_Click(object sender, EventArgs e)
        {
            wb_navegador.Navigate(txt_url.Text);
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            wb_navegador.GoBack();
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            wb_navegador.GoForward();
        }

        private void btn_recargar_Click(object sender, EventArgs e)
        {
            wb_navegador.Refresh();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            wb_navegador.GoHome();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            Form2 ventana2 = new Form2();
            ventana2.Show();
            this.Hide();
        }
    }
}
