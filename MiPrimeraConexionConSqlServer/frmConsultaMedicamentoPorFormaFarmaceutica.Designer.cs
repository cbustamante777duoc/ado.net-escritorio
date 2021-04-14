
namespace MiPrimeraConexionConSqlServer
{
    partial class frmConsultaMedicamentoPorFormaFarmaceutica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboFormaFarmaceutica = new System.Windows.Forms.ComboBox();
            this.dgvMedicamento = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ingrese forma farmaceutica";
            // 
            // cboFormaFarmaceutica
            // 
            this.cboFormaFarmaceutica.FormattingEnabled = true;
            this.cboFormaFarmaceutica.Location = new System.Drawing.Point(191, 32);
            this.cboFormaFarmaceutica.Name = "cboFormaFarmaceutica";
            this.cboFormaFarmaceutica.Size = new System.Drawing.Size(375, 21);
            this.cboFormaFarmaceutica.TabIndex = 1;
            this.cboFormaFarmaceutica.SelectionChangeCommitted += new System.EventHandler(this.filtrar);
            // 
            // dgvMedicamento
            // 
            this.dgvMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamento.Location = new System.Drawing.Point(54, 124);
            this.dgvMedicamento.Name = "dgvMedicamento";
            this.dgvMedicamento.Size = new System.Drawing.Size(620, 261);
            this.dgvMedicamento.TabIndex = 2;
            // 
            // frmConsultaMedicamentoPorFormaFarmaceutica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMedicamento);
            this.Controls.Add(this.cboFormaFarmaceutica);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultaMedicamentoPorFormaFarmaceutica";
            this.Text = "frmConsultaMedicamentoPorFormaFarmaceutica";
            this.Load += new System.EventHandler(this.frmConsultaMedicamentoPorFormaFarmaceutica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFormaFarmaceutica;
        private System.Windows.Forms.DataGridView dgvMedicamento;
    }
}