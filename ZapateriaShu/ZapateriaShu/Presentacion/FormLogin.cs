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
using ZapateriaShu.Negocio;
using ZapateriaShu.Presentacion;

namespace ZapateriaShu.Presentacion
{
    public partial class FormLogin : Form
    {
        ClsLogin log = new ClsLogin();
        public FormLogin()
        {
            InitializeComponent();
        }

        public void btniniciarsesion_Click(object sender, EventArgs e)
        {
            if (rbAdmin.Text.Equals("admin"))
            {
                log.Login(txtUsuario.Text, txtPassword.Text, rbAdmin.Text);
            }
            else
            {
                log.Login(txtUsuario.Text, txtPassword.Text, rbVendedor.Text);
            }
           
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

    }   
}
