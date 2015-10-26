namespace AdsDesktop
{
    partial class Principal
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
            this.dgvEstudios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreEstudio = new System.Windows.Forms.TextBox();
            this.brnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtActualizar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cmbEstudios = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstudios
            // 
            this.dgvEstudios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudios.Location = new System.Drawing.Point(52, 62);
            this.dgvEstudios.Name = "dgvEstudios";
            this.dgvEstudios.Size = new System.Drawing.Size(226, 570);
            this.dgvEstudios.TabIndex = 0;
            this.dgvEstudios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Estudio";
            // 
            // txtNombreEstudio
            // 
            this.txtNombreEstudio.Location = new System.Drawing.Point(427, 70);
            this.txtNombreEstudio.Name = "txtNombreEstudio";
            this.txtNombreEstudio.Size = new System.Drawing.Size(152, 20);
            this.txtNombreEstudio.TabIndex = 2;
            // 
            // brnGuardar
            // 
            this.brnGuardar.Location = new System.Drawing.Point(608, 70);
            this.brnGuardar.Name = "brnGuardar";
            this.brnGuardar.Size = new System.Drawing.Size(92, 23);
            this.brnGuardar.TabIndex = 3;
            this.brnGuardar.Text = "Guardar";
            this.brnGuardar.UseVisualStyleBackColor = true;
            this.brnGuardar.Click += new System.EventHandler(this.brnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre del Estudio";
            // 
            // txtActualizar
            // 
            this.txtActualizar.Location = new System.Drawing.Point(441, 334);
            this.txtActualizar.Name = "txtActualizar";
            this.txtActualizar.Size = new System.Drawing.Size(152, 20);
            this.txtActualizar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Agregar Estudio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Modificar Estudio";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(630, 334);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(92, 23);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Guardar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cmbEstudios
            // 
            this.cmbEstudios.FormattingEnabled = true;
            this.cmbEstudios.Location = new System.Drawing.Point(441, 280);
            this.cmbEstudios.Name = "cmbEstudios";
            this.cmbEstudios.Size = new System.Drawing.Size(152, 21);
            this.cmbEstudios.TabIndex = 9;
            this.cmbEstudios.SelectedValueChanged += new System.EventHandler(this.cmbEstudios_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(908, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Pacientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 735);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbEstudios);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtActualizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.brnGuardar);
            this.Controls.Add(this.txtNombreEstudio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEstudios);
            this.Name = "Principal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstudios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreEstudio;
        private System.Windows.Forms.Button brnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtActualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox cmbEstudios;
        private System.Windows.Forms.Button button1;
    }
}

