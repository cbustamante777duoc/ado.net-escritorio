using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MiPrimeraConexionConSqlServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listar();

            ////cnx es el nombre que se puso en app.Config
            //SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
            ////consulta sql + sqlConnection
            //SqlCommand cmd = new SqlCommand("SELECT IIDCLINICA,NOMBRE,DIRECCION FROM Clinica WHERE BHABILITADO = 1 ",cn);
            ////ejecuta el sql comand
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            ////instacia de la tabla
            //DataTable tabla = new DataTable();
            ////llenado de la tabla
            //sda.Fill(tabla);
            ////llenado gridView
            //dgvClinica.DataSource = tabla;

        }

        private void Listar() 
        {
            //metodo que recibe una consulta y una dataGridView
            SQL.ListarConsultaSQL("SELECT IIDCLINICA,NOMBRE,DIRECCION FROM Clinica WHERE BHABILITADO = 1", dgvClinica);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string idClinica = txtIdClinica.Text;
            SQL.FiltradoProcemientoAlmacenado("BuscarClinicaPorID", "@idClinica", idClinica, dgvClinica);
            //SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
            //SqlCommand cmd = new SqlCommand("BuscarClinicaPorID", cn);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@idClinica", idClinica);
            //DataTable table = new DataTable();
            //SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            //dataAdapter.Fill(table);
            //dgvClinica.DataSource = table;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Listar();
            txtIdClinica.Text = "";
        }
    }
}
