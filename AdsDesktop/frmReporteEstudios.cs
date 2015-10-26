using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdsDesktop
{
    public partial class frmReporteEstudios : Form
    {
        public frmReporteEstudios()
        {
            InitializeComponent();
        }

        private void frmReporteEstudios_Load(object sender, EventArgs e)
        {
            this.reportViewer2.LocalReport.DataSources.Clear();
            var rptDataSource = new Microsoft.Reporting.WinForms.ReportDataSource("Estudios", Estudio.GetAll());
            this.reportViewer2.LocalReport.DataSources.Add(rptDataSource);
            this.reportViewer2.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer2.RefreshReport();
        }
    }
}
