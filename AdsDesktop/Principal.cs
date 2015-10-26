using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace AdsDesktop
{
    public partial class Principal : Form
    {
        private List<Estudio> estudios { get; set; }
        public Principal()
        {
            InitializeComponent();
            LoadEstudios();
            
        }

        private void LoadEstudios()
        {
            this.estudios = Estudio.GetAll();
            LoaddvgEstudios();
            LoadcmbEstudios();
        }

        private void LoaddvgEstudios() {
           
            dgvEstudios.DataSource = estudios;
        }

        private void LoadcmbEstudios() {
            cmbEstudios.DisplayMember = "desc_estudio";
            cmbEstudios.ValueMember = "cod_estudio";
            cmbEstudios.DataSource = estudios;
            
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void brnGuardar_Click(object sender, EventArgs e)
        {
            Estudio.Insert(txtNombreEstudio.Text.ToString());
            LoadEstudios();
            dgvEstudios.Update();
            dgvEstudios.Refresh();
            txtNombreEstudio.Text = String.Empty;
            
        }

        private void cmbEstudios_SelectedValueChanged(object sender, EventArgs e)
        {
            txtActualizar.Text = cmbEstudios.Text.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Estudio.Update(Convert.ToInt16(cmbEstudios.SelectedValue), txtActualizar.Text.ToString());
            txtActualizar.Text = String.Empty;
            LoadEstudios();
            dgvEstudios.Update();
            dgvEstudios.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmPacientes = new frmPaciente();
            frmPacientes.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Grupo 38
            var frmReportMenu = new frmReportMenu();
            frmReportMenu.Show();
        }
    }
}
