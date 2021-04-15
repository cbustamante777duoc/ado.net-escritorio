using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraConexionConSqlServer
{
    public partial class frmConsultarMedicoPorEspecialidad : Form
    {
        public frmConsultarMedicoPorEspecialidad()
        {
            InitializeComponent();
        }

        private void frmConsultarMedicoPorEspecialidad_Load(object sender, EventArgs e)
        {
            //listado
            SQL.ListarProcedureSQL("USPLISTARMEDICOS", dgvMedico);
            //llenado comboBox
            SQL.LLenarComboBox("USPLISTARCOMBOESPECIALIDAD2", cboEspecialidad, "NOMBRE", "IIDESPECIALIDAD");
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //filtrado de datos
            SQL.FiltradoProcemientoAlmacenado("USPCONSULTARDOCTORPORESPECIALIDAD2", 
                "@IDESPECIALIDAD", cboEspecialidad.SelectedValue.ToString(), dgvMedico);
        }
    }
}
