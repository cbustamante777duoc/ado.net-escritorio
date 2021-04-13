using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace MiPrimeraConexionConSqlServer
{
    public partial class frmListadoEspecialidad : Form
    {
        public frmListadoEspecialidad()
        {
            InitializeComponent();
        }

        private void frmListadoEspecialidad_Load(object sender, EventArgs e)
        {
            SQL.ListarProcedureSQL("uspListarEspecialidad", dgvEspecialidad);

            //SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
            ////paso el storeProcedure + sqlConnection
            //SqlCommand cmd = new SqlCommand("uspListarEspecialidad",cn);
            ////digo que es un stoteProcedure
            //cmd.CommandType = CommandType.StoredProcedure;
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            ////instacia de la tabla
            //DataTable tabla = new DataTable();
            ////llenado de la tabla
            //sda.Fill(tabla);
            //dgvEspecialidad.DataSource = tabla;


        }
    }
}
