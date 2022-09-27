using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListadoEstudiante
{
    public partial class Form1 : Form
    {

        List<Estudiantes> listar = new List<Estudiantes>();

        public Form1()
        {
            InitializeComponent();
        }

        private void tslSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tslAgregar_Click(object sender, EventArgs e)
        {
           if (validarNombre() == false) {

                return;
            
            }

            if (validarCarrera() == false)
            {
                return;
            }
            if(validarAño() == false)
            {
                return;
            } 
           


            //Objeto para la clase lista
            Estudiantes datos = new Estudiantes();
            datos.Nombre = txtNombre.Text;
            datos.Carrera = cmbCarrera.SelectedItem.ToString();
            datos.Año = int.Parse(txtAño.Text);
            listar.Add(datos);
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = listar;
            limpiarCampos();






        }


        //boton cunsultar

        private void tslConsultar_Click(object sender, EventArgs e)
        {

            if(validarNombre() == false)
            {
                return ;
            }
            Estudiantes lista = GetAlumno(txtNombre.Text);
            if(lista == null)
            {
                erpError.SetError(txtNombre, "el estudiante no esta registrado");
                limpiarCampos();
                txtNombre.Focus();
                return;

            }
            else
            {
                erpError.SetError(txtNombre, "");
                txtNombre.Text = lista.Nombre;
                cmbCarrera.SelectedItem = lista.Carrera;
                txtAño.Text = lista.Año.ToString();
            }
        }

        private Estudiantes GetAlumno(string nombre)
        {
            return listar.Find(data => data.Nombre.Contains(nombre));
        }

        
        private bool validarAño()
        {
            int Año;

            if (!int.TryParse(txtAño.Text, out Año ) || txtAño.Text == "")
            {
                erpError.SetError(txtAño, "El campo no puede ser vacio");
                txtAño.Clear();
                txtAño.Focus();
                return false;

            }
            else
            {
                erpError.SetError(txtAño, "");
                return true;

            }
        }


        //Objeto para la clase Estudiantes
        private bool validarNombre()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                erpError.SetError(txtNombre, "El campo no puede ser vacio");
                return false;
            }
            else
            {
                erpError.SetError(txtNombre, "");
                return true;
            }

        }

        private bool validarCarrera()
        {
            if (string.IsNullOrEmpty(cmbCarrera.Text))
            {
                erpError.SetError(cmbCarrera, "El campo no puede ser vacio");
                return false;
            }
            else
            {
                erpError.SetError(cmbCarrera, "");
                return true;
            }

        }
        
        private void limpiarCampos()
        {
            txtNombre.Clear();
            cmbCarrera.SelectedIndex = 0;
            txtAño.Clear();
    }

        private void tslEliminar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == null)
            {
                erpError.SetError(txtNombre, "debe consultar primero para eliminar");
                limpiarCampos();
                txtNombre.Focus();
                return;

            }
            else
            {
                erpError.SetError(txtNombre, "");
                DialogResult Respuesta = MessageBox.Show("Esta seguro de eliminar este estudiante",
                 "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if(Respuesta == DialogResult.Yes)
                {
                    foreach(Estudiantes data in listar)
                    {
                        if(data.Nombre == txtNombre.Text)
                        {
                            listar.Remove(data);
                            break;
                        }
                    }

                    limpiarCampos();
                    dgvDatos.DataSource = null;
                    dgvDatos.DataSource = listar;
                }
            }
        }
    }

   

}
