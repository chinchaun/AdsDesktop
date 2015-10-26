using Negocio;
using System;
using System.Windows.Forms;

namespace AdsDesktop
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            var rptDataSource = new Microsoft.Reporting.WinForms.ReportDataSource("Pacientes", Paciente.GetAll());
            this.reportViewer1.LocalReport.DataSources.Add(rptDataSource);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
