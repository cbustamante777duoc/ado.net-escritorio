
namespace MiPrimeraConexionConSqlServer
{
    partial class frmListadoDoctor
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
            this.dgvDoctor = new System.Windows.Forms.DataGridView();
            this.rbPaterno = new System.Windows.Forms.RadioButton();
            this.rbMaterno = new System.Windows.Forms.RadioButton();
            this.txtValor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDoctor
            // 
            this.dgvDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctor.Location = new System.Drawing.Point(57, 106);
            this.dgvDoctor.Name = "dgvDoctor";
            this.dgvDoctor.Size = new System.Drawing.Size(666, 251);
            this.dgvDoctor.TabIndex = 0;
            // 
            // rbPaterno
            // 
            this.rbPaterno.AutoSize = true;
            this.rbPaterno.Location = new System.Drawing.Point(69, 60);
            this.rbPaterno.Name = "rbPaterno";
            this.rbPaterno.Size = new System.Drawing.Size(102, 17);
            this.rbPaterno.TabIndex = 1;
            this.rbPaterno.TabStop = true;
            this.rbPaterno.Text = "Apellido Paterno";
            this.rbPaterno.UseVisualStyleBackColor = true;
            // 
            // rbMaterno
            // 
            this.rbMaterno.AutoSize = true;
            this.rbMaterno.Location = new System.Drawing.Point(192, 60);
            this.rbMaterno.Name = "rbMaterno";
            this.rbMaterno.Size = new System.Drawing.Size(104, 17);
            this.rbMaterno.TabIndex = 2;
            this.rbMaterno.TabStop = true;
            this.rbMaterno.Text = "Apellido Materno";
            this.rbMaterno.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(349, 60);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(211, 20);
            this.txtValor.TabIndex = 3;
            this.txtValor.TextChanged += new System.EventHandler(this.filtrar);
            // 
            // frmListadoDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.rbMaterno);
            this.Controls.Add(this.rbPaterno);
            this.Controls.Add(this.dgvDoctor);
            this.Name = "frmListadoDoctor";
            this.Text = "frmListadoDoctor";
            this.Load += new System.EventHandler(this.frmListadoDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDoctor;
        private System.Windows.Forms.RadioButton rbPaterno;
        private System.Windows.Forms.RadioButton rbMaterno;
        private System.Windows.Forms.TextBox txtValor;
    }
}