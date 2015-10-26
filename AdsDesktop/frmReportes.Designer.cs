namespace AdsDesktop
{
    partial class frmReportes
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EstudioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.PacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstudioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PacienteBindingSource
            // 
            this.PacienteBindingSource.DataSource = typeof(Negocio.Paciente);
            // 
            // EstudioBindingSource
            // 
            this.EstudioBindingSource.DataSource = typeof(Negocio.Estudio);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Pacientes";
            reportDataSource1.Value = this.PacienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AdsDesktop.rptPacientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1027, 758);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 758);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstudioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource PacienteBindingSource;
        private System.Windows.Forms.BindingSource EstudioBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}