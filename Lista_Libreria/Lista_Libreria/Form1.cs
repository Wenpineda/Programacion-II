using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Libreria
{
    struct libros
    {
       public string Titulo;
       public string Edicion;
       public string Genero;
       public string Autor;
       public string Pais;
       public int Year;

    }
    public partial class Form1 : Form
    {
        //Declaracion Arreglo tipo escritura
        libros[] libro = new libros[100];
        
        //Variable de Uso Global
        int Indice = 0, Imodificar;
        public Form1()
        {
            InitializeComponent();
        }
        //Metodo Para limpiar los Campos

        void LimpiarCampo()
        {
            txtTitulo.Text = ""; ;
            txtEdicion.Text = "";
            sbGenero.Text = "";
            txtAutor.Text = "";
            txtPais.Text = "";
            txtAño.Text = "";

        }
        void Registrar()
        {
            try
            {
                if (txtTitulo.Text != "" && txtEdicion.Text != "" && sbGenero.Text != "" ) 
                {
                    libro[Indice].Titulo = txtTitulo.Text;
                    libro[Indice].Edicion= txtEdicion.Text;
                    libro[Indice].Genero = Convert.ToString(sbGenero.SelectedText);
                    libro[Indice].Autor= txtAutor.Text;
                    libro[Indice].Pais = txtPais.Text;
                    libro[Indice].Year = Convert.ToInt32(txtAño.Text);
                    Indice++;
                }
                else
                {

                }

            } catch (Exception e)
            {
                MessageBox.Show("Error registro del libro", e.Message);
            }
        }
        //Metdo de Registro

        void MostrarRegistro()
        {
            try
            {
                string Lista = "";
                for (int i = 0; i < Indice; i++)
                {
                    Lista = Lista + i + "-" + libro[i].Titulo + "-" + libro[i].Edicion + "-" + libro[i].Genero + "" + libro[i].Autor + "" + libro[i].Pais + "" + libro[i].Year + "\n";
                }
                RthRegistro.Text = Lista;

            }
            catch(Exception e)
            {
                MessageBox.Show("Error de Registro de Libro", e.Message);
            }
        }
        //metodo para  Buscar Registro

        void BuscarRegistro()
        {
            try
            {
                if(txtBuscar.Text !="")
                {
                    for(int i=0; i < Indice; i++)
                    {
                        if (libro[i].Titulo == txtBuscar.Text)
                        {
                            txtTitulo.Text = libro[i].Titulo;
                            txtEdicion.Text = libro[i].Edicion;
                            sbGenero.SelectedText = libro[i].Genero;
                            txtAutor.Text = libro[i].Autor;
                            txtPais.Text = libro[i].Pais;
                            txtAño.Text = Convert.ToString(libro[i].Year);
                            Imodificar = i;
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Campo de Busqueda Vacio");
                }
               
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un Error en la busqueda de Registro", e.Message);
            }
        }
        void ModificarRegistro()
        {

        }
        void EliminarRegistro()
        {
            try
            {
                if (txtTitulo.Text != "")
                {
                    for (int i = 0; i < Indice; i++)
                    {
                        if (libro[i].Titulo == txtBuscar.Text)
                        {
                            txtTitulo.Text = libro[i].Titulo;
                            txtEdicion.Text = libro[i].Edicion;
                            sbGenero.SelectedText = libro[i].Genero;
                            txtAutor.Text = libro[i].Autor;
                            txtPais.Text = libro[i].Pais;
                            txtAño.Text = Convert.ToString(libro[i].Year);
                            Imodificar = i-1;
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Campo de Busqueda Vacio");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un Error en la busqueda de Registro", e.Message);
            }
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled= true;
            btnGuardar.Enabled=false;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarRegistro();
        }

        private void sbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RthRegistro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarRegistro();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registrar();
            MostrarRegistro();
            LimpiarCampo();
        }
    }
}
