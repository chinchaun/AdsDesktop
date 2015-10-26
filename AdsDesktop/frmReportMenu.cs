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
    public partial class frmReportMenu : Form
    {
        public frmReportMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmReporte = new frmReportes();
            frmReporte.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frmReporte = new frmReporteEstudios();
            frmReporte.Show();
        }
    }
}
