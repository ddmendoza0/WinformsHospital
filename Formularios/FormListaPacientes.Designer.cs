namespace WinformsHospital
{
    partial class FormListaPacientes
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
            this.labCabeceraLstMedic = new System.Windows.Forms.Label();
            this.lstPacientes = new System.Windows.Forms.ListBox();
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            this.labIdPaciente = new System.Windows.Forms.Label();
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.labMedico = new System.Windows.Forms.Label();
            this.butCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labCabeceraLstMedic
            // 
            this.labCabeceraLstMedic.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.labCabeceraLstMedic.Dock = System.Windows.Forms.DockStyle.Top;
            this.labCabeceraLstMedic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCabeceraLstMedic.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labCabeceraLstMedic.Location = new System.Drawing.Point(0, 0);
            this.labCabeceraLstMedic.Name = "labCabeceraLstMedic";
            this.labCabeceraLstMedic.Size = new System.Drawing.Size(632, 47);
            this.labCabeceraLstMedic.TabIndex = 3;
            this.labCabeceraLstMedic.Text = "Listado de pacientes";
            this.labCabeceraLstMedic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstPacientes
            // 
            this.lstPacientes.FormattingEnabled = true;
            this.lstPacientes.ItemHeight = 16;
            this.lstPacientes.Location = new System.Drawing.Point(4, 73);
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(296, 164);
            this.lstPacientes.TabIndex = 4;
            this.lstPacientes.SelectedValueChanged += new System.EventHandler(this.lstPacientes_SelectedValueChanged);
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.Location = new System.Drawing.Point(402, 145);
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.Size = new System.Drawing.Size(187, 22);
            this.txtIdPaciente.TabIndex = 19;
            // 
            // labIdPaciente
            // 
            this.labIdPaciente.AutoSize = true;
            this.labIdPaciente.Location = new System.Drawing.Point(399, 126);
            this.labIdPaciente.Name = "labIdPaciente";
            this.labIdPaciente.Size = new System.Drawing.Size(95, 16);
            this.labIdPaciente.TabIndex = 18;
            this.labIdPaciente.Text = "Id del paciente";
            // 
            // txtMedico
            // 
            this.txtMedico.Location = new System.Drawing.Point(402, 84);
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.Size = new System.Drawing.Size(187, 22);
            this.txtMedico.TabIndex = 17;
            // 
            // labMedico
            // 
            this.labMedico.AutoSize = true;
            this.labMedico.Location = new System.Drawing.Point(399, 64);
            this.labMedico.Name = "labMedico";
            this.labMedico.Size = new System.Drawing.Size(112, 16);
            this.labMedico.TabIndex = 16;
            this.labMedico.Text = "Medico asignado";
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(433, 253);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(156, 38);
            this.butCancelar.TabIndex = 20;
            this.butCancelar.Text = "Cerrar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // FormListaPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(632, 303);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.labIdPaciente);
            this.Controls.Add(this.txtMedico);
            this.Controls.Add(this.labMedico);
            this.Controls.Add(this.lstPacientes);
            this.Controls.Add(this.labCabeceraLstMedic);
            this.Name = "FormListaPacientes";
            this.Text = "Herramienta gestion hospital: Pacientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCabeceraLstMedic;
        private System.Windows.Forms.ListBox lstPacientes;
        private System.Windows.Forms.TextBox txtIdPaciente;
        private System.Windows.Forms.Label labIdPaciente;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.Label labMedico;
        private System.Windows.Forms.Button butCancelar;
    }
}