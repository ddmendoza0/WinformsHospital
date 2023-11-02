namespace WinformsHospital.Formularios
{
    partial class FormAltaPaciente
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
            this.labNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labMedico = new System.Windows.Forms.Label();
            this.butAceptar = new System.Windows.Forms.Button();
            this.butCancelar = new System.Windows.Forms.Button();
            this.cmbMedicos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labCabeceraAltaPaciente
            // 
            this.labCabeceraAltaPaciente.BackColor = System.Drawing.SystemColors.Highlight;
            this.labCabeceraAltaPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.labCabeceraAltaPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCabeceraAltaPaciente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labCabeceraAltaPaciente.Location = new System.Drawing.Point(0, 0);
            this.labCabeceraAltaPaciente.Name = "labCabeceraAltaPaciente";
            this.labCabeceraAltaPaciente.Size = new System.Drawing.Size(582, 47);
            this.labCabeceraAltaPaciente.TabIndex = 2;
            this.labCabeceraAltaPaciente.Text = "Va a admitir un paciente";
            this.labCabeceraAltaPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(12, 60);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(125, 16);
            this.labNombre.TabIndex = 3;
            this.labNombre.Text = "Introduce el nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(15, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(174, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // labMedico
            // 
            this.labMedico.AutoSize = true;
            this.labMedico.Location = new System.Drawing.Point(12, 130);
            this.labMedico.Name = "labMedico";
            this.labMedico.Size = new System.Drawing.Size(219, 16);
            this.labMedico.TabIndex = 5;
            this.labMedico.Text = "Selecciona un medico responsable";
            // 
            // butAceptar
            // 
            this.butAceptar.Location = new System.Drawing.Point(104, 253);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(158, 38);
            this.butAceptar.TabIndex = 7;
            this.butAceptar.Text = "Admitir";
            this.butAceptar.UseVisualStyleBackColor = true;
            this.butAceptar.Click += new System.EventHandler(this.butAceptar_Click);
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(318, 253);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(156, 38);
            this.butCancelar.TabIndex = 8;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // cmbMedicos
            // 
            this.cmbMedicos.FormattingEnabled = true;
            this.cmbMedicos.Location = new System.Drawing.Point(15, 150);
            this.cmbMedicos.Name = "cmbMedicos";
            this.cmbMedicos.Size = new System.Drawing.Size(174, 24);
            this.cmbMedicos.TabIndex = 9;
            // 
            // FormAltaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 303);
            this.Controls.Add(this.cmbMedicos);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.butAceptar);
            this.Controls.Add(this.labMedico);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labNombre);
            this.Controls.Add(this.labCabeceraAltaPaciente);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormAltaPaciente";
            this.Text = "Herramienta gestion hospital: Admitir paciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCabeceraAltaPaciente;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label labMedico;
        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.ComboBox cmbMedicos;
    }
}