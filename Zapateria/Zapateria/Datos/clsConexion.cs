﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Zapateria.Datos
{
    class clsConexion
    {
        private SqlConnection sqlConn = new SqlConnection("Data Source=CC1PC37-38;" + "Initial Catalog=ZapateriaShu; " +"Integrated Security=SSPI");
        public SqlConnection AbrirConexion()
        {
            if (sqlConn.State == ConnectionState.Closed)
            {
                sqlConn.Open();               
                
            }
            return sqlConn;
        }
        public SqlConnection CerrarConexion()
        {
            if (sqlConn.State == ConnectionState.Open)
            {
                sqlConn.Close();                
            }
            return sqlConn;
        }

    }
}
