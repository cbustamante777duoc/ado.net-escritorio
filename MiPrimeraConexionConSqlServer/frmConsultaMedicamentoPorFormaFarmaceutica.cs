using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraConexionConSqlServer
{
    public partial class frmConsultaMedicamentoPorFormaFarmaceutica : Form
    {
        public frmConsultaMedicamentoPorFormaFarmaceutica()
        {
            InitializeComponent();
        }

        private void frmConsultaMedicamentoPorFormaFarmaceutica_Load(object sender, EventArgs e)
        {
            SQL.LLenarComboBox("USPLLENARCOMBOFORMAFARMACEUTICA2", cboFormaFarmaceutica);
            SQL.ListarConsultaSQL("USPLISTARMEDICAMENTO", dgvMedicamento);
            // SQL.LLenarComboBox("USPLLENARCOMBOFORMAFARMACEUTICA2", cboFormaFarmaceutica, "NOMBRE", "IIDFORMAFARMACEUTICA");
            //SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
            //SqlCommand command = new SqlCommand("USPLLENARCOMBOFORMAFARMACEUTICA2",cn);
            //command.CommandType = CommandType.StoredProcedure;
            //DataTable table = new DataTable();
            //SqlDataAdapter sqlData = new SqlDataAdapter(command);
            //sqlData.Fill(table);
            //cboFormaFarmaceutica.DataSource = table;
            //cboFormaFarmaceutica.DisplayMember = "NOMBRE";
            //cboFormaFarmaceutica.ValueMember = "IIDFORMAFARMACEUTICA";

        }

        private void filtrar(object sender, EventArgs e)
        {
            //usar evento rallito
            //convertir el valor del value "id" en tostring
            string idforma = cboFormaFarmaceutica.SelectedValue.ToString();
            SQL.FiltradoProcemientoAlmacenado("USPCONSULTARMEDICAMENTOPORFORMA2", "@IIDFORMAFARMACEUTICA", idforma, dgvMedicamento);
        }
    }
}
