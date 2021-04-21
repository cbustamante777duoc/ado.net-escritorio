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
    public partial class frmListadoPaciente : Form
    {
        public frmListadoPaciente()
        {
            InitializeComponent();
        }

        private void frmListadoPaciente_Load(object sender, EventArgs e)
        {
            cboOpciones.SelectedIndex = 0;
            SQL.ListarProcedureSQL("uspListarPacientePrograma", dgvPaciente);
        }

        private void filtrar(object sender, EventArgs e)
        {
            string Opcion = cboOpciones.Text;
            string valor = txtValor.Text;
            if (Opcion.Equals("Nombre"))
            {
                SQL.FiltradoProcemientoAlmacenado("uspConsultarPacienteProgramaPorNombre2", "@nombre", valor, dgvPaciente);
            }
            else if (Opcion.Equals("Apellido Paterno"))
            {
                SQL.FiltradoProcemientoAlmacenado("uspConsultarPacienteProgramaPorApellidoPaterno", "@apPaterno", valor, dgvPaciente);
            }
            else
            {
                SQL.FiltradoProcemientoAlmacenado("uspConsultarPacienteProgramaPorApellidoMaterno", "@apMaterno", valor, dgvPaciente);
            }
        }
    }
}
