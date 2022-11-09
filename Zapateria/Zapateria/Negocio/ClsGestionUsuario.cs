using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zapateria.Datos;
using System.Data;

namespace Zapateria.Negocio
{
    class ClsGestionUsuario
    {
        ClsUsuario user = new ClsUsuario();
        //Metodo para cargar los datos de la tabla usuarios en un datagridview
        public DataTable ViewUser() 
        {
            DataTable Table = new DataTable();
            Table = user.MostrarUsuarios();
            return Table;
        }

    }
}
