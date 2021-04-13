using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraConexionConSqlServer
{
    public class SQL
    {
        private static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);

        public static void ListarConsultaSQL(string consulta, DataGridView grilla) 
        {
            //consulta sql + sqlConnection
            SqlCommand cmd = new SqlCommand(consulta, cn);
            //ejecuta el sql comand
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //instacia de la tabla
            DataTable tabla = new DataTable();
            //llenado de la tabla
            sda.Fill(tabla);
            //llenado gridView
            grilla.DataSource = tabla;
        }
    }
}
