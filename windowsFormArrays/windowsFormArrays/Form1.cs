using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsFormArrays
{
    public partial class Form1 : Form
    {

        //string[] arrayEstudiantes = new string[2];
        List<bool> listaApellidos = new List<bool>();

        ArrayList listaNombres = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            listaNombres.Add("Sancho"); //[0]
            listaNombres.Add("Quixote"); //[1]
            listaNombres.Add("Dulcinea"); //[2]

            //
            renderList();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            listaNombres.Add(nombre);

            renderList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string indice = txtIndice.Text;
            int posicion = Int32.Parse(indice);

            listaNombres[posicion] = txtNombre.Text;

            renderList();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string indice = txtIndice.Text;
            int posicion = Int32.Parse(indice);

            listaNombres.RemoveAt(posicion);

            renderList();
        }

        public void renderList() {
            lblLista.Text = "";

            for (int i = 0; i < listaNombres.Count; i++)
            {
                lblLista.Text += i + " - " + listaNombres[i].ToString() + "\n";
            }
        }
    }

}
