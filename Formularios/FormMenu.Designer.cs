namespace WinformsHospital
{
    partial class FormMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labCabecera = new System.Windows.Forms.Label();
            this.labGestiones = new System.Windows.Forms.Label();
            this.butAltaMedic = new System.Windows.Forms.Button();
            this.butAltaPaciente = new System.Windows.Forms.Button();
            this.butListaMedic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.butListaPacient = new System.Windows.Forms.Button();
            this.butBajaPaciente = new System.Windows.Forms.Button();
            this.butLstPersonas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labCabecera
            // 
            this.labCabecera.BackColor = System.Drawing.SystemColors.Highlight;
            this.labCabecera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.labCabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCabecera.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labCabecera.Location = new System.Drawing.Point(0, 0);
            this.labCabecera.Name = "labCabecera";
            this.labCabecera.Size = new System.Drawing.Size(653, 66);
            this.labCabecera.TabIndex = 0;
            this.labCabecera.Text = "NUEVO HOSPITAL MEJORADO";
            this.labCabecera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labGestiones
            // 
            this.labGestiones.AutoSize = true;
            this.labGestiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGestiones.Location = new System.Drawing.Point(12, 93);
            this.labGestiones.Name = "labGestiones";
            this.labGestiones.Size = new System.Drawing.Size(195, 20);
            this.labGestiones.TabIndex = 1;
            this.labGestiones.Text = "Gestiones disponibles";
            // 
            // butAltaMedic
            // 
            this.butAltaMedic.Location = new System.Drawing.Point(16, 133);
            this.butAltaMedic.Name = "butAltaMedic";
            this.butAltaMedic.Size = new System.Drawing.Size(191, 26);
            this.butAltaMedic.TabIndex = 2;
            this.butAltaMedic.Text = "Dar de alta un medico";
            this.butAltaMedic.UseVisualStyleBackColor = true;
            this.butAltaMedic.Click += new System.EventHandler(this.OnClickAltaMedico);
            // 
            // butAltaPaciente
            // 
            this.butAltaPaciente.Location = new System.Drawing.Point(16, 184);
            this.butAltaPaciente.Name = "butAltaPaciente";
            this.butAltaPaciente.Size = new System.Drawing.Size(191, 23);
            this.butAltaPaciente.TabIndex = 3;
            this.butAltaPaciente.Text = "Admitir paciente";
            this.butAltaPaciente.UseVisualStyleBackColor = true;
            this.butAltaPaciente.Click += new System.EventHandler(this.butAltaPaciente_Click);
            // 
            // butListaMedic
            // 
            this.butListaMedic.Location = new System.Drawing.Point(405, 133);
            this.butListaMedic.Name = "butListaMedic";
            this.butListaMedic.Size = new System.Drawing.Size(191, 23);
            this.butListaMedic.TabIndex = 4;
            this.butListaMedic.Text = "Medicos";
            this.butListaMedic.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Listados disponibles";
            // 
            // butListaPacient
            // 
            this.butListaPacient.Location = new System.Drawing.Point(405, 184);
            this.butListaPacient.Name = "butListaPacient";
            this.butListaPacient.Size = new System.Drawing.Size(191, 23);
            this.butListaPacient.TabIndex = 6;
            this.butListaPacient.Text = "Pacientes";
            this.butListaPacient.UseVisualStyleBackColor = true;
            // 
            // butBajaPaciente
            // 
            this.butBajaPaciente.Location = new System.Drawing.Point(16, 233);
            this.butBajaPaciente.Name = "butBajaPaciente";
            this.butBajaPaciente.Size = new System.Drawing.Size(191, 23);
            this.butBajaPaciente.TabIndex = 7;
            this.butBajaPaciente.Text = "Dar el alta a un paciente";
            this.butBajaPaciente.UseVisualStyleBackColor = true;
            // 
            // butLstPersonas
            // 
            this.butLstPersonas.Location = new System.Drawing.Point(405, 233);
            this.butLstPersonas.Name = "butLstPersonas";
            this.butLstPersonas.Size = new System.Drawing.Size(191, 23);
            this.butLstPersonas.TabIndex = 8;
            this.butLstPersonas.Text = "Personas en el hospital";
            this.butLstPersonas.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(653, 329);
            this.Controls.Add(this.butLstPersonas);
            this.Controls.Add(this.butBajaPaciente);
            this.Controls.Add(this.butListaPacient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butListaMedic);
            this.Controls.Add(this.butAltaPaciente);
            this.Controls.Add(this.butAltaMedic);
            this.Controls.Add(this.labGestiones);
            this.Controls.Add(this.labCabecera);
            this.Name = "FormMenu";
            this.Text = "Herramienta gestion hospital: Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCabecera;
        private System.Windows.Forms.Label labGestiones;
        private System.Windows.Forms.Button butAltaMedic;
        private System.Windows.Forms.Button butAltaPaciente;
        private System.Windows.Forms.Button butListaMedic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butListaPacient;
        private System.Windows.Forms.Button butBajaPaciente;
        private System.Windows.Forms.Button butLstPersonas;
    }
}

