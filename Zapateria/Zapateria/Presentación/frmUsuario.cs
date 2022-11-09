using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zapateria.Negocio;

namespace Zapateria.Presentación
{
    public partial class frmUsuario : Form
    {
        ClsGestionUsuario GU = new ClsGestionUsuario();
        public frmUsuario()
        {
            InitializeComponent();
            dtvVistaUsuarios.DataSource = GU.ViewUser(); 
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
