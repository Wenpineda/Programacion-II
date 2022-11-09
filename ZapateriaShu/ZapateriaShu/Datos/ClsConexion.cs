using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ZapateriaShu.Datos
{
    class ClsConexion
    {
        private SqlConnection sqlConn = new SqlConnection("Data Source=CC1PC37-38;" + "Initial Catalog=ZapateriaShu; " +
            "integrated security=SSPI");

        //ABRIR LA CONEXION
        public SqlConnection OpenConexion()
        {
            if (sqlConn.State == ConnectionState.Closed)
            {
                sqlConn.Open();
                MessageBox.Show("Conexion Exitosa");
            }
            return sqlConn;
        }

        //CERRAR LA CONEXION
        public SqlConnection ClosedConexion()
        {
            if (sqlConn.State == ConnectionState.Open)
            {
                sqlConn.Close();
                MessageBox.Show("Conexion Cerrada");
            }
            return sqlConn;
        }
    }
}
