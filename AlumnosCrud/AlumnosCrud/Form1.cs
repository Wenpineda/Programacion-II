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

namespace AlumnosCrud
{
    public partial class Form1 : Form
    {

        ArrayList alumnos = new ArrayList();


        public Form1()
        {
            InitializeComponent();



            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            limpiar();
        }

        private string GenerarCodigo()
        {
            string cod = "";

            if (alumnos.Count < 1)
            {
                return "a001";
            }
            else
            {
                foreach (Alumnos e in alumnos)
                {

                    cod = e.codigo.ToString();
                }

            }
            return "A" + (int.Parse(cod.Substring(1, 3)) + 1).ToString("000");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //objeto de la clase equipos

            Alumnos a = new Alumnos();

            try
            {
                if (txtNombre.Text == String.Empty || txtEdad.Text == String.Empty || txtCarrera.Text == String.Empty)
                {
                    MessageBox.Show("Todos los campos deben estar llenos");
                }
                else { 



                a.codigo = lblCodigo.Text;
                a.nombre = txtNombre.Text;
                a.edad = txtEdad.Text;
                a.carrera = txtCarrera.Text;
                 alumnos.Add(a);

                //agragar al arrayList

                listado();
                limpiar();
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                btnNuevo.Enabled = true;

            }



            }
            catch(Exception)
            {
                MessageBox.Show("Error al registrar alumno");
            }

}

        private void lvRegistro_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem elemento = lvRegistro.GetItemAt(e.X, e.Y);
            lblCodigo.Text = elemento.Text;
            txtNombre.Text = elemento.SubItems[1].Text;
            txtEdad.Text = elemento.SubItems[2].Text;
            txtCarrera.Text = elemento.SubItems[3].Text;

            btnGuardar.Enabled = false;
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = true;
            limpiar();
        }

        private void limpiar()
        {
            lblCodigo.Text = GenerarCodigo();
            txtNombre.Clear();
            txtEdad.Clear();
            txtCarrera.Clear();
            txtNombre.Focus();
           
        }

        private void btnActualizar_Click(object sender, EventArgs e){
    try
    {
        foreach (Alumnos item in alumnos)
        {
            if (item.codigo == lblCodigo.Text)
            {
                item.nombre = txtNombre.Text;
                item.edad = txtEdad.Text;
                item.carrera = txtCarrera.Text;
                break;

            }

        }

        listado();
        limpiar();

    }
    
            
            catch(Exception)
            {
                MessageBox.Show("Error al modifir alumno");

            }
        }


        private void listado()
        {
            lvRegistro.Items.Clear();

            foreach(Alumnos e in alumnos)
            {
                ListViewItem fila = new ListViewItem(e.codigo);
                fila.SubItems.Add(e.nombre);
                fila.SubItems.Add(e.edad);
                fila.SubItems.Add(e.carrera);

                lvRegistro.Items.Add(fila);

            }
        }

        private void lvRegistro_SelectedIndexChanged(object sender, EventArgs e) {
           


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Alumnos item in alumnos)
                {
                    if (item.codigo == lblCodigo.Text)
                    {
                       alumnos.Remove(item);
                        break;

                    }

                }

                listado();
                limpiar();

            }


            catch (Exception)
            {
                MessageBox.Show("Error al eliminar alumno");

            }
        }


        private void lblCodigo_Click(object sender, EventArgs e) { 



        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
