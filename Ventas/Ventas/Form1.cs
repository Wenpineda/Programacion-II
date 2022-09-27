using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class Form1 : Form

    {

        List<Facturas> factura;
        List<Facturas> facturasFiltradas;



        public Form1()
        {
            InitializeComponent();

            consultaFactura();
        }

        private void consultaFactura()
        {

            factura = new List<Facturas>()
            {
                new Facturas{Factura = 1, Producto = "Chocolate", Cliente = "Divid", Empleado = "Juan Perez", Total = 1000.5},
                new Facturas{Factura = 2, Producto = "Cafe", Cliente = "Divid", Empleado = "Juan Perez", Total = 1000.5},
                new Facturas{Factura = 3, Producto = "Pollo", Cliente = "Divid", Empleado = "Juan Perez", Total = 1000.5},
                new Facturas{Factura = 4, Producto = "Pollo", Cliente = "Divid", Empleado = "Juan", Total = 5},
                new Facturas{Factura = 5, Producto = "Sopa", Cliente = "Divid", Empleado = "Juan", Total = 1.25}

            };

            dgvFactura.DataSource = factura; 


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            //Utilizando la interfaz IENUMERABLE como metodo

           facturasFiltradas = factura.Where(x => x.Total > 1000).ToList();
            
            dgvFactura.DataSource = facturasFiltradas;



            //Utilizando la interfaz IENUMERABLE como consulta

          /*  facturasFiltradas = (from datos  in factura
                                 where datos.Total > 1000
                                 select datos).ToList();
            dgvFactura.DataSource = facturasFiltradas; */

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            //Utilizando la interfaz IENUMERABLE como metodo

            facturasFiltradas = factura.Where(x => x.Empleado == "Juan Perez").ToList();

            dgvFactura.DataSource = facturasFiltradas;


            //Utilizando la interfaz IENUMERABLE como consulta

        }

        private void btnReinicio_Click(object sender, EventArgs e)
        {
            consultaFactura();
        }
    }
}
