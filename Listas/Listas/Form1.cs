namespace Listas
{
    public partial class Form1 : Form
    {
        List<string> Productos = new List<string>();

        //METODO PARA LIMPIAR LOS CAMPOS
        public void LimpiarCampos()
        {
            txtnombre.Clear();
            txtcategoria.Clear();
            txtprecio.Clear();
        }

        //METODO PARA REGISTRAR DATOS
        public void Registrar()
        {
            try
            {
                if (txtnombre.Text !="-" && txtcategoria.Text != "-" && txtprecio.Text != "-" )
                {
                    Productos.Add(txtnombre.Text);
                    Productos.Add(txtcategoria.Text);
                    Productos.Add(txtprecio.Text);
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Error al registrar el dato" + e.Message);
            }
        }

        //METODO PARA MOSTRAR LOS REGISTROS
        public void Mostrar ()
        {
            try
            {
                string Lista = "";
                for (int i = 0; i < Productos.Count; i+=3)
                {
                    Lista = Lista + i + "-" + Productos[i] + " - " + Productos[i + 1] + " - " + Productos[i + 2] + "\n";
                }
                rtblistaproductos.Text = Lista;
            }
            catch (Exception e)
            {

                MessageBox.Show("Error al cargar la lista" + e.Message);
            }
        }

        //METODO PARA BUSCAR LOS DATOS
        public void Buscar()
        {
            try
            {
                if (txtbuscar.Text != "")
                {
                    for (int i = 0; i < Productos.Count; i ++)
                    {
                        if (txtnombre.Text != txtbuscar.Text)
                        {
                            txtnombre.Text = Productos[i];
                            txtcategoria.Text = Productos[i+1];
                            txtprecio.Text = Productos[i+2];
                        }

                    }
                }
                
            }
            catch (Exception e)
            {

                MessageBox.Show("Registro no necontrado" + e.Message);
            }
        }

        //METODO PARA ELIMINAR LOS DATOS
        public void EliminarRegistro()
        {
            try
            {
                for (int i = 0; i < Productos.Count; i++)
                {
                    if (txtnombre.Text == Productos[i])
                    {
                        Productos.RemoveAt(i);
                        Productos.RemoveAt(i);
                        Productos.RemoveAt(i);
                    }
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Error al eliminar la informacion" + e.Message);
            }
        }
        //METODO PARA MODIFICAR EL REGISTRO
        public void Modificar()
        {
            try
            {
                if (txtnombre.Text != "" && txtcategoria.Text != "" && txtprecio.Text != "") 
                {
                    txtnombre.Text = txtnombre.Text.Trim();
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Error al modificar la informacion" + e.Message);
            }
        }
        /*public void Eliminar()
        {
            try
            {
                if (txtnombre.Text != "")
                {
                    for (int i = 0; i < Productos.Count() - 1; i++)
                    {
                        if (txtnombre.Text == Productos[i])
                        {
                            Productos.RemoveAt(i);
                            Productos.RemoveAt(i);
                            Productos.RemoveAt(i);
                            LimpiarCampos();
                            Mostrar();
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Campo nombre esta vacio!!");

                }



            }
            catch (Exception)
            {
                MessageBox.Show("Error al elminar registro");
            }
        }*/
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            Registrar();
            Mostrar();
            LimpiarCampos();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            EliminarRegistro();
            Mostrar();
            LimpiarCampos();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Buscar();
            Mostrar();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            
        }
    }
}