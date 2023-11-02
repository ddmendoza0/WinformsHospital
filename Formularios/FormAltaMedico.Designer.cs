namespace WinformsHospital.Formularios
{
    partial class FormAltaMedico
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
            this.labNomMed = new System.Windows.Forms.Label();
            this.labCabeceraAltaMed = new System.Windows.Forms.Label();
            this.txtNomMedic = new System.Windows.Forms.TextBox();
            this.labEspecialidad = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.butAceptar = new System.Windows.Forms.Button();
            this.butCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labNomMed
            // 
            this.labNomMed.AutoSize = true;
            this.labNomMed.Location = new System.Drawing.Point(12, 58);
            this.labNomMed.Name = "labNomMed";
            this.labNomMed.Size = new System.Drawing.Size(125, 16);
            this.labNomMed.TabIndex = 0;
            this.labNomMed.Text = "Introduce el nombre";
            // 
            // labCabeceraAltaMed
            // 
            this.labCabeceraAltaMed.BackColor = System.Drawing.SystemColors.Highlight;
            this.labCabeceraAltaMed.Dock = System.Windows.Forms.DockStyle.Top;
            this.labCabeceraAltaMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCabeceraAltaMed.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labCabeceraAltaMed.Location = new System.Drawing.Point(0, 0);
            this.labCabeceraAltaMed.Name = "labCabeceraAltaMed";
            this.labCabeceraAltaMed.Size = new System.Drawing.Size(582, 47);
            this.labCabeceraAltaMed.TabIndex = 1;
            this.labCabeceraAltaMed.Text = "Va a dar de alta un medico";
            this.labCabeceraAltaMed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNomMedic
            // 
            this.txtNomMedic.Location = new System.Drawing.Point(15, 78);
            this.txtNomMedic.Name = "txtNomMedic";
            this.txtNomMedic.Size = new System.Drawing.Size(225, 22);
            this.txtNomMedic.TabIndex = 2;
            // 
            // labEspecialidad
            // 
            this.labEspecialidad.AutoSize = true;
            this.labEspecialidad.Location = new System.Drawing.Point(15, 127);
            this.labEspecialidad.Name = "labEspecialidad";
            this.labEspecialidad.Size = new System.Drawing.Size(171, 16);
            this.labEspecialidad.TabIndex = 3;
            this.labEspecialidad.Text = "Selecciona la especialidad";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Items.AddRange(new object[] {
            "Astrologia",
            "Cardiologia",
            "Geriatria",
            "Neurologia",
            "Reflexologia"});
            this.cmbEspecialidad.Location = new System.Drawing.Point(18, 147);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(222, 24);
            this.cmbEspecialidad.Sorted = true;
            this.cmbEspecialidad.TabIndex = 4;
            // 
            // butAceptar
            // 
            this.butAceptar.Location = new System.Drawing.Point(98, 228);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(158, 38);
            this.butAceptar.TabIndex = 5;
            this.butAceptar.Text = "Dar de alta";
            this.butAceptar.UseVisualStyleBackColor = true;
            this.butAceptar.Click += new System.EventHandler(this.butAceptar_Click);
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(326, 228);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(156, 38);
            this.butCancelar.TabIndex = 6;
            this.butCancelar.Text = "Cerrar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // FormAltaMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 303);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.butAceptar);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.labEspecialidad);
            this.Controls.Add(this.txtNomMedic);
            this.Controls.Add(this.labCabeceraAltaMed);
            this.Controls.Add(this.labNomMed);
            this.Name = "FormAltaMedico";
            this.Text = "Herramienta gestion hospital: Medicos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNomMed;
        private System.Windows.Forms.Label labCabeceraAltaMed;
        private System.Windows.Forms.TextBox txtNomMedic;
        private System.Windows.Forms.Label labEspecialidad;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.Button butCancelar;
    }
}