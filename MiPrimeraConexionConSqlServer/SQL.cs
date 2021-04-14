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

        public static void ListarProcedureSQL(string nombreProcedimiento, DataGridView grilla) 
        {
            
            //paso el storeProcedure + sqlConnection
            SqlCommand cmd = new SqlCommand(nombreProcedimiento, cn);
            //digo que es un stoteProcedure
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //instacia de la tabla
            DataTable tabla = new DataTable();
            //llenado de la tabla
            sda.Fill(tabla);
            grilla.DataSource = tabla;
        }

        public static void FiltradoProcemientoAlmacenado(string nombreProcedure, string nombreParametro,
            string valorParametro,DataGridView grilla)
        {
            
            SqlCommand cmd = new SqlCommand(nombreProcedure, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(nombreParametro, valorParametro);
            DataTable table = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(table);
            grilla.DataSource = table;
        }

        public static void LLenarComboBox(string nombreProcedure,ComboBox combo, string displayMember="nombre",
            string valueMember="Id") 
        {

            SqlCommand command = new SqlCommand(nombreProcedure, cn);
            command.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            SqlDataAdapter sqlData = new SqlDataAdapter(command);
            sqlData.Fill(table);
            combo.DataSource = table;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
            //combox

        }

    }
}

