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
    public partial class frmPaciente : Form
    {
        List<Paciente> pacientes;

        public frmPaciente()
        {
            InitializeComponent();
            LoadData();
            LoaddvgPacientes();
            LoadcmbPacientes();
        }

        private void LoadData() {
            LoadPacientes();
        }

        private void LoadPacientes() {
            pacientes = Paciente.GetAll();
        }

        private void LoaddvgPacientes() {
            dvgPacientes.DataSource = pacientes;
        }

        private void LoadcmbPacientes() {
            cmbPacientes.DataSource = pacientes;
            cmbPacientes.DisplayMember = "Apellido";
            cmbPacientes.ValueMember = "cod_paciente";
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Paciente.Insert(txtNombre.Text.ToString(), txtApellido.Text.ToString());
            txtApellido.Text = String.Empty;
            txtNombre.Text = String.Empty;
            LoadData();
            LoaddvgPacientes();
            dvgPacientes.Update();
            dvgPacientes.Refresh();
        }
    }
}
