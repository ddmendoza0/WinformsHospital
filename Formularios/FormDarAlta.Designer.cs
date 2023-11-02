namespace WinformsHospital
{
    partial class FormDarAlta
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
            this.labCabeceraAltaPaciente = new System.Windows.Forms.Label();
            this.butAceptar = new System.Windows.Forms.Button();
            this.butCancelar = new System.Windows.Forms.Button();
            this.lstPacientes = new System.Windows.Forms.ListBox();
            this.labListaPacientes = new System.Windows.Forms.Label();
            this.labMedico = new System.Windows.Forms.Label();
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.labIdPaciente = new System.Windows.Forms.Label();
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labDateAlta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labCabeceraAltaPaciente
            // 
            this.labCabeceraAltaPaciente.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.labCabeceraAltaPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.labCabeceraAltaPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCabeceraAltaPaciente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labCabeceraAltaPaciente.Location = new System.Drawing.Point(0, 0);
            this.labCabeceraAltaPaciente.Name = "labCabeceraAltaPaciente";
            this.labCabeceraAltaPaciente.Size = new System.Drawing.Size(582, 47);
            this.labCabeceraAltaPaciente.TabIndex = 3;
            this.labCabeceraAltaPaciente.Text = "Va a dar el alta a un paciente";
            this.labCabeceraAltaPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butAceptar
            // 
            this.butAceptar.Location = new System.Drawing.Point(100, 303);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(158, 38);
            this.butAceptar.TabIndex = 8;
            this.butAceptar.Text = "Aceptar";
            this.butAceptar.UseVisualStyleBackColor = true;
            this.butAceptar.Click += new System.EventHandler(this.butAceptar_Click);
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(316, 303);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(156, 38);
            this.butCancelar.TabIndex = 9;
            this.butCancelar.Text = "Cerrar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // lstPacientes
            // 
            this.lstPacientes.FormattingEnabled = true;
            this.lstPacientes.ItemHeight = 16;
            this.lstPacientes.Location = new System.Drawing.Point(12, 93);
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(239, 148);
            this.lstPacientes.Sorted = true;
            this.lstPacientes.TabIndex = 10;
            this.lstPacientes.SelectedValueChanged += new System.EventHandler(this.lstPacientes_SelectedValueChanged);
            // 
            // labListaPacientes
            // 
            this.labListaPacientes.AutoSize = true;
            this.labListaPacientes.Location = new System.Drawing.Point(9, 74);
            this.labListaPacientes.Name = "labListaPacientes";
            this.labListaPacientes.Size = new System.Drawing.Size(132, 16);
            this.labListaPacientes.TabIndex = 11;
            this.labListaPacientes.Text = "Listado de pacientes";
            // 
            // labMedico
            // 
            this.labMedico.AutoSize = true;
            this.labMedico.Location = new System.Drawing.Point(329, 73);
            this.labMedico.Name = "labMedico";
            this.labMedico.Size = new System.Drawing.Size(112, 16);
            this.labMedico.TabIndex = 12;
            this.labMedico.Text = "Medico asignado";
            // 
            // txtMedico
            // 
            this.txtMedico.Location = new System.Drawing.Point(332, 93);
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.Size = new System.Drawing.Size(187, 22);
            this.txtMedico.TabIndex = 13;
            // 
            // labIdPaciente
            // 
            this.labIdPaciente.AutoSize = true;
            this.labIdPaciente.Location = new System.Drawing.Point(329, 135);
            this.labIdPaciente.Name = "labIdPaciente";
            this.labIdPaciente.Size = new System.Drawing.Size(95, 16);
            this.labIdPaciente.TabIndex = 14;
            this.labIdPaciente.Text = "Id del paciente";
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.Location = new System.Drawing.Point(332, 154);
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.Size = new System.Drawing.Size(187, 22);
            this.txtIdPaciente.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(332, 218);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(187, 22);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.Value = new System.DateTime(2023, 11, 2, 18, 40, 8, 0);
            // 
            // labDateAlta
            // 
            this.labDateAlta.AutoSize = true;
            this.labDateAlta.Location = new System.Drawing.Point(329, 199);
            this.labDateAlta.Name = "labDateAlta";
            this.labDateAlta.Size = new System.Drawing.Size(89, 16);
            this.labDateAlta.TabIndex = 17;
            this.labDateAlta.Text = "Fecha de alta";
            // 
            // FormDarAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.labDateAlta);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.labIdPaciente);
            this.Controls.Add(this.txtMedico);
            this.Controls.Add(this.labMedico);
            this.Controls.Add(this.labListaPacientes);
            this.Controls.Add(this.lstPacientes);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.butAceptar);
            this.Controls.Add(this.labCabeceraAltaPaciente);
            this.Name = "FormDarAlta";
            this.Text = "Herramienta gestion hospital: Pacientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCabeceraAltaPaciente;
        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.ListBox lstPacientes;
        private System.Windows.Forms.Label labListaPacientes;
        private System.Windows.Forms.Label labMedico;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.Label labIdPaciente;
        private System.Windows.Forms.TextBox txtIdPaciente;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labDateAlta;
    }
}