using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria
{
    struct Libros
    {
        public string titulo;
        public string edicion;
        public string genero;
        public string autor;
        public string pais;
        public int year;
    }
    public partial class Form1 : Form
    {
        //Declaracion del arreglo tipo estructura
        Libros[] Lib = new Libros[100];
        //variable de uso global
        int indice = 0, iModificar;

        public Form1()
        {
            InitializeComponent();
        }

        //metodo para limpiar los campos de texto 
        void LimpiarCampos()
        {
            //Clear(); Funciona para limpiar los campos tambien se puede poner el "";
            txttitulo.Text = "";
            txtedicion.Text = "";
            cbgenero.Text = "";
            txtautor.Text = "";
            txtpais.Text = "";
            txtyear.Text = "";
        }
        void Registrar()
        {
            try
            {
                if (txttitulo.Text !=""&& txtedicion.Text !=""&& cbgenero.Text!="")
                {
                    Lib[indice].titulo = txttitulo.Text;
                    Lib[indice].edicion = txtedicion.Text;
                    Lib[indice].genero = Convert.ToString(cbgenero.Text);
                    Lib[indice].autor = txtautor.Text;
                    Lib[indice].pais = txtpais.Text;
                    Lib[indice].year = Convert.ToInt32( txtyear.Text);
                    indice++;
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Error en el registro del libro", e.Message);
            }
        }
        //Metodo para mostrar los datos
        void MostrarRegistros()
        {
            try
            {
                string Lista = "";
                for (int i = 0; i < indice; i++)
                {
                    Lista = Lista + i + " - " + Lib[i].titulo + " " + Lib[i].edicion + " " + Lib[i].genero + " " + Lib[i].autor + " " + Lib[i].pais + " " + Lib[i].year + "\n";
                }
                rthRegistro.Text = Lista;
            }
            catch (Exception e)
            {

                MessageBox.Show("Ocurrio un error a la hora de cargar los datos", e.Message);
            }
        }
        void BuscarRegistro()
        {
            try
            {
                if (txtbuscar.Text !="")
                {
                    for (int i = 0; i < indice; i++)
                    {
                        if (Lib[i].titulo == txtbuscar.Text)
                        {
                            txttitulo.Text = Lib[i].titulo;
                            txtedicion.Text = Lib[i].edicion;
                            cbgenero.SelectedText = Convert.ToString(Lib[i].genero);
                            txtautor.Text = Lib[i].autor;
                            txtpais.Text = Lib[i].pais;
                            txtyear.Text = Convert.ToString(Lib[i].year);
                            iModificar = i;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("NO se encontro nada " + e.Message); ;
            }
        }

        public void GuardarCambios()
        {
            try
            {
                // MessageBox.Show("Indice" + iModificar); "Verificar que si esta llamando la variable

                if (txttitulo.Text != "" && txtedicion.Text != "" && cbgenero.Text != "")
                {
                    Lib[iModificar].titulo = txttitulo.Text;
                    Lib[iModificar].edicion = txtedicion.Text;
                    Lib[iModificar].genero =Convert.ToString(cbgenero.Text);
                    Lib[iModificar].autor = txtautor.Text;
                    Lib[iModificar].pais = txtpais.Text;
                    Lib[iModificar].year = Convert.ToInt32(txtyear.Text);
                    
                }

            }
            catch (Exception e)
            {

                MessageBox.Show("Error al guardar los cambions generados");
            }
        }
        public void EliminarRegistro()
        {
            try
            {
                for (int i = iModificar; i <indice; i++)
                {
                    Lib[i].titulo = Lib[i + 1].titulo; 
                    Lib[i].edicion = Lib[i + 1].edicion;
                    Lib[i].genero = Lib[i + 1].genero;
                    Lib[i].autor = Lib[i + 1].autor;
                    Lib[i].pais = Lib[i + 1].pais;
                    Lib[i].year = Lib[i + 1].year;
                }
                indice--;
            }
            catch (Exception e)
            {

                MessageBox.Show("Error al eliminar el registro");
            }
        }

    private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            btnguardar.Enabled = true;
            btnmodificar.Enabled = false;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            btnmodificar.Enabled = true;
            btnguardar.Enabled = false;
            GuardarCambios();
            MostrarRegistros();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            BuscarRegistro();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            EliminarRegistro();
            MostrarRegistros();
            LimpiarCampos();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            Registrar();
            MostrarRegistros();
            LimpiarCampos();
        }
    }
}
