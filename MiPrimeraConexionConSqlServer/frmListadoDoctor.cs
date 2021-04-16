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
    public partial class frmListadoDoctor : Form
    {
        public frmListadoDoctor()
        {
            InitializeComponent();
        }

        private void frmListadoDoctor_Load(object sender, EventArgs e)
        {
            rbPaterno.Checked = true;
            SQL.ListarProcedureSQL("upsListarDoctorPrograma", dgvDoctor);
        }

        private void filtrar(object sender, EventArgs e)
        {
            string valor = txtValor.Text;
            if (rbPaterno.Checked==true)
            {
                SQL.FiltradoProcemientoAlmacenado("upsConsultaDoctorPorApPaterno", "@apPaterno", valor, dgvDoctor);
            }
            else
            {
                SQL.FiltradoProcemientoAlmacenado("upsConsultaDoctorPorApMaterno", "@apMaterno", valor, dgvDoctor);
            }
        }
    }
}
