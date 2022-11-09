using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosM
{
    public class Productos
    {
      

        public string Producto { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }

    
        public Productos()
        {

        }

        public Productos(string producto, string descripcion, double precio, int stock)
        {
            Producto = producto;
            Descripcion = descripcion;
            Precio = precio;
            Stock = stock;
        }

        public override string ToString()
        {
            return "Nombre" + Producto + "\n" + "Descripcion" + Descripcion + "\n" + "Precio" + Precio + "\n " + "Stock" + Stock;
        }

    }
}
