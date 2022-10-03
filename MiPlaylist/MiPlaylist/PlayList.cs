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
    
    public partial class PlayList : Form
    {
        List<Cancion> canciones = new List<Cancion> {
            new Cancion(1, "I miss you", "Blink182"),
            new Cancion(8, "Yukon", "Joji"),
            new Cancion(3, "Muerte en Hawaii", "Calle 13"),
            new Cancion(2, "Caraluna", "Bacilos"),
            new Cancion(5, "Por amar a ciegas", "Arcangel"),
            new Cancion(4, "Mi primer millon", "Bacilos"),
            new Cancion(9, "Ojos color sol", "Calle 13"),
            new Cancion(7, "Así de grandes son las ideas", "Calle 13"),
            new Cancion(6, "La bala", "Calle 13")
        };

        public PlayList()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\background.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            renderizarLista();
        }

        public void renderizarLista() {

            var listaOrdenada = canciones.OrderBy(c => c.Id);

            foreach (Cancion c in listaOrdenada) {
                lblPlaylist.Text += c.imprimir() + "\n";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dato = txtDato.Text;

            /*            IEnumerable<Cancion> resultados = from c in canciones
                                                          where c.Artista == dato
                                                          select c;*/

            var resultados = canciones.Where(c => c.Artista == dato);

            lblResultados.Text = "";

            foreach (Cancion c in resultados)
            {
                lblResultados.Text += c.imprimir() + "\n";
            }
        }

        //SOLO ACEPTA NUMEROS
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 ||
                e.KeyChar >= 123 && e.KeyChar <= 255
                )
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtArtista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >=32 && e.KeyChar <=96 || e.KeyChar >=123 && e.KeyChar <=225 )
            {
                MessageBox.Show("Solo minusulas", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        public void Registrar()
        {
            try
            {
                if (txtId.Text != "" && txtNombre.Text != "" && txtArtista.Text != "")
                {
                    
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

        }
    }
}
