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
            //cnx es el nombre que se puso en app.Config
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
            //consulta sql + sqlConnection
            SqlCommand cmd = new SqlCommand("SELECT IIDCLINICA,NOMBRE,DIRECCION FROM Clinica WHERE BHABILITADO = 1 ",cn);
            //ejecuta el sql comand
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //instacia de la tabla
            DataTable tabla = new DataTable();
            //llenado de la tabla
            sda.Fill(tabla);
            //llenado gridView
            dgvClinica.DataSource = tabla;


        }
    }
}
