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
    public partial class frmListadoMedicamento : Form
    {
        public frmListadoMedicamento()
        {
            InitializeComponent();
        }

        private void frmListadoMedicamento_Load(object sender, EventArgs e)
        {
            rbNombre.Checked = true;
            SQL.ListarProcedureSQL("uspListarMedicamentoPrograma2", dgvMedicamento);

        }

        private void filtrar(object sender, EventArgs e)
        {
            string valor = txtValor.Text;
            if (rbNombre.Checked==true)
            {
                SQL.FiltradoProcemientoAlmacenado("uspConsultarMedicamentoPorNombre2", 
                    "@nombre", valor, dgvMedicamento);
            }
            else
            {
                SQL.FiltradoProcemientoAlmacenado("uspConsultarMedicamentoPorConcentracion2",
                    "@concentracion", valor, dgvMedicamento);
            }
        }
    }
}
