using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZapateriaShu.Datos;
using ZapateriaShu.Presentacion;

namespace ZapateriaShu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timerZapateria_Shu_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToShortDateString();
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            FormLogin lg = new FormLogin();
            lg.TopLevel = false;
            contenedor.Controls.Add(lg);
            lg.Show();
        }
    }
}
