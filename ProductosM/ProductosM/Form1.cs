using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosM
{
    public partial class Form1 : Form
    {

        Productos producto = new Productos();   
        List<Productos> lista = new List<Productos>();

        public Form1()
        {
            InitializeComponent();
            precargarProductos();
        }


        public void precargarProductos()
        {
            List<Productos> list = new List<Productos>()
            {
                new Productos("chocolate", "es muy bueno", 20.1, 100),
                 new Productos("chocolate", "es muy bueno", 20.1, 100)
            };

            dgvProductos.DataSource = list;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void listarProducto()
        {
            lvProductos.Items.Clear();

            foreach (Productos p in lista)
            {
                ListViewItem fila = new ListViewItem(p.Producto);
                fila.SubItems.Add(p.Descripcion);
                fila.SubItems.Add(Convert.ToString(p.Precio));
                fila.SubItems.Add(Convert.ToString(p.Stock));
                lvProductos.Items.Add(fila);

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           producto.Producto = txtProducto.Text;
            producto.Descripcion = txtDescripcion.Text;
            producto.Precio = double.Parse(txtPrecio.Text);
            producto.Stock = int.Parse(txtStock.Text);
            lista.Add(producto);
            listarProducto();

            color();
            limpiar();


        }

        public void color()
        {
            for (int i = 0; i <= lvProductos.Items.Count -1; i++)
            {
                lvProductos.Items[i].BackColor = Color.FromArgb(211,138, 123);
            }
        }

        public void limpiar()
        {
            txtProducto.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            foreach (Productos p in lista)
            {
                if (p.Producto == txtProducto.Text)
                {
                    p.Producto = txtProducto.Text;
                    p.Descripcion = txtDescripcion.Text;
                    p.Precio = double.Parse(txtPrecio.Text);
                    p.Stock = int.Parse(txtStock.Text);
                    break;
                }
            }
            listarProducto();
            limpiar();
            color();
        }

        private void btnEiminar_Click(object sender, EventArgs e)
        {
            foreach (Productos list in lista)
            {
                if (list.Producto == txtProducto.Text)
                {
                    lista.Remove(list);
                    break;
                }
            }
            listarProducto();
            limpiar();
        }

        private void lvProductos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem elemento = lvProductos.GetItemAt(e.X, e.Y);
            txtProducto.Text = elemento.SubItems[0].Text;
            txtDescripcion.Text = elemento.SubItems[1].Text;
            txtPrecio.Text = elemento.SubItems[2].Text;
            txtStock.Text = elemento.SubItems[3].Text;
        }
    }
}
