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
            this.labMedicos = new System.Windows.Forms.Label();
            this.butAltaMedic = new System.Windows.Forms.Button();
            this.butAltaPaciente = new System.Windows.Forms.Button();
            this.butListaMedic = new System.Windows.Forms.Button();
            this.labPaciente = new System.Windows.Forms.Label();
            this.butBajaPaciente = new System.Windows.Forms.Button();
            this.butLstPersonas = new System.Windows.Forms.Button();
            this.butCerrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labPersonas = new System.Windows.Forms.Label();
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
            this.labCabecera.Size = new System.Drawing.Size(632, 66);
            this.labCabecera.TabIndex = 0;
            this.labCabecera.Text = "NUEVO HOSPITAL MEJORADO";
            this.labCabecera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labMedicos
            // 
            this.labMedicos.AutoSize = true;
            this.labMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMedicos.Location = new System.Drawing.Point(12, 93);
            this.labMedicos.Name = "labMedicos";
            this.labMedicos.Size = new System.Drawing.Size(79, 20);
            this.labMedicos.TabIndex = 1;
            this.labMedicos.Text = "Medicos";
            // 
            // butAltaMedic
            // 
            this.butAltaMedic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butAltaMedic.Location = new System.Drawing.Point(16, 125);
            this.butAltaMedic.Name = "butAltaMedic";
            this.butAltaMedic.Size = new System.Drawing.Size(191, 26);
            this.butAltaMedic.TabIndex = 2;
            this.butAltaMedic.Text = "Admisión";
            this.butAltaMedic.UseVisualStyleBackColor = false;
            this.butAltaMedic.Click += new System.EventHandler(this.OnClickAltaMedico);
            // 
            // butAltaPaciente
            // 
            this.butAltaPaciente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butAltaPaciente.Location = new System.Drawing.Point(331, 128);
            this.butAltaPaciente.Name = "butAltaPaciente";
            this.butAltaPaciente.Size = new System.Drawing.Size(191, 23);
            this.butAltaPaciente.TabIndex = 3;
            this.butAltaPaciente.Text = "Admitisión";
            this.butAltaPaciente.UseVisualStyleBackColor = false;
            this.butAltaPaciente.Click += new System.EventHandler(this.butAltaPaciente_Click);
            // 
            // butListaMedic
            // 
            this.butListaMedic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butListaMedic.Location = new System.Drawing.Point(16, 166);
            this.butListaMedic.Name = "butListaMedic";
            this.butListaMedic.Size = new System.Drawing.Size(191, 23);
            this.butListaMedic.TabIndex = 4;
            this.butListaMedic.Text = "Listado";
            this.butListaMedic.UseVisualStyleBackColor = false;
            this.butListaMedic.Click += new System.EventHandler(this.butListaMedic_Click);
            // 
            // labPaciente
            // 
            this.labPaciente.AutoSize = true;
            this.labPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPaciente.Location = new System.Drawing.Point(327, 93);
            this.labPaciente.Name = "labPaciente";
            this.labPaciente.Size = new System.Drawing.Size(92, 20);
            this.labPaciente.TabIndex = 5;
            this.labPaciente.Text = "Pacientes";
            // 
            // butBajaPaciente
            // 
            this.butBajaPaciente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butBajaPaciente.Location = new System.Drawing.Point(331, 166);
            this.butBajaPaciente.Name = "butBajaPaciente";
            this.butBajaPaciente.Size = new System.Drawing.Size(191, 23);
            this.butBajaPaciente.TabIndex = 7;
            this.butBajaPaciente.Text = "Dar el alta";
            this.butBajaPaciente.UseVisualStyleBackColor = false;
            this.butBajaPaciente.Click += new System.EventHandler(this.butBajaPaciente_Click);
            // 
            // butLstPersonas
            // 
            this.butLstPersonas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butLstPersonas.Location = new System.Drawing.Point(16, 311);
            this.butLstPersonas.Name = "butLstPersonas";
            this.butLstPersonas.Size = new System.Drawing.Size(191, 23);
            this.butLstPersonas.TabIndex = 8;
            this.butLstPersonas.Text = "Ver";
            this.butLstPersonas.UseVisualStyleBackColor = false;
            this.butLstPersonas.Click += new System.EventHandler(this.butLstPersonas_Click);
            // 
            // butCerrar
            // 
            this.butCerrar.Location = new System.Drawing.Point(464, 303);
            this.butCerrar.Name = "butCerrar";
            this.butCerrar.Size = new System.Drawing.Size(156, 38);
            this.butCerrar.TabIndex = 9;
            this.butCerrar.Text = "Salir";
            this.butCerrar.UseVisualStyleBackColor = true;
            this.butCerrar.Click += new System.EventHandler(this.butCerrar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(331, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Listado";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labPersonas
            // 
            this.labPersonas.AutoSize = true;
            this.labPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPersonas.Location = new System.Drawing.Point(12, 288);
            this.labPersonas.Name = "labPersonas";
            this.labPersonas.Size = new System.Drawing.Size(299, 20);
            this.labPersonas.TabIndex = 11;
            this.labPersonas.Text = "Listado de personas en el hospital";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(632, 353);
            this.Controls.Add(this.labPersonas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butCerrar);
            this.Controls.Add(this.butLstPersonas);
            this.Controls.Add(this.butBajaPaciente);
            this.Controls.Add(this.labPaciente);
            this.Controls.Add(this.butListaMedic);
            this.Controls.Add(this.butAltaPaciente);
            this.Controls.Add(this.butAltaMedic);
            this.Controls.Add(this.labMedicos);
            this.Controls.Add(this.labCabecera);
            this.Name = "FormMenu";
            this.Text = "Herramienta gestion hospital: Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCabecera;
        private System.Windows.Forms.Label labMedicos;
        private System.Windows.Forms.Button butAltaMedic;
        private System.Windows.Forms.Button butAltaPaciente;
        private System.Windows.Forms.Button butListaMedic;
        private System.Windows.Forms.Label labPaciente;
        private System.Windows.Forms.Button butBajaPaciente;
        private System.Windows.Forms.Button butLstPersonas;
        private System.Windows.Forms.Button butCerrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labPersonas;
    }
}

