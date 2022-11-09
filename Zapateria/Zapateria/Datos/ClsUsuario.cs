using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Zapateria.Datos
{
    class ClsUsuario 
    {
        private clsConexion Conn = new clsConexion();
        SqlDataReader read;
        DataTable Tabla = new DataTable();
        SqlCommand Cmd = new SqlCommand();
        public DataTable MostrarUsuarios()
        {
            Cmd.Connection = Conn.AbrirConexion();
            Cmd.CommandText = "SELECT* FROM tbUsuario";
            Cmd.CommandType = CommandType.Text;
            read = Cmd.ExecuteReader();
            Tabla.Load(read);
            Conn.CerrarConexion();
            return Tabla;
        }
    }
}
