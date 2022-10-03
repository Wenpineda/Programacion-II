using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPlaylist
{
    public partial class Form1 : Form
    {
        List<Usuario> usuarios = new List<Usuario> {
            new Usuario(1, "Duran", "hamburguesa"),
            new Usuario(2, "Fredy", "fubol"), 
            new Usuario(3, "Franklin", "basquet")
        };

        public Form1()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\loginBackground.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario login = new Usuario();
            login.Nombre = txtNombre.Text;
            login.Pass = txtPass.Text;

            //var resultadoLogin = usuarios.Where(u => u.Nombre == login.Nombre && u.Pass == login.Pass);

            IEnumerable<Usuario> resultadoLogin = from u in usuarios
                                                  where u.Nombre == login.Nombre && u.Pass == login.Pass
                                                  select u;

            if(resultadoLogin.Any())
            {
                this.Hide();
                PlayList frm = new PlayList();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
