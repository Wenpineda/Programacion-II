using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZapateriaShu.Datos;

namespace ZapateriaShu.Negocio
{
    class ClsLogin
    {
        ClsConexion cnn = new ClsConexion();
        SqlCommand command = new SqlCommand();
        SqlDataReader leerconsulta;

        public void Login(string Usuario, string Password, String Role)
        {
            try
            {
                command.Connection = cnn.OpenConexion();
                command.CommandText = "Select NomUsuario, Role, Password From Tb_Usuario" + "Where NomUsuario = '" + Usuario + "' And Password = ' " + Password + "'And Role = ' " + Role + " '";
                command.ExecuteNonQuery();
                leerconsulta = command.ExecuteReader();
                if (leerconsulta.Read())
                {
                    MessageBox.Show("Bienvenido al sistema" + Usuario);
                }
                else
                {
                    MessageBox.Show("Datos incorrectos chuchito");
                }
                command.Connection = cnn.ClosedConexion();
            }
            catch (Exception)
            {


            }
        }
    }
}
