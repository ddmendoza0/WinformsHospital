namespace WinformsHospital
{
    partial class FormTotalPersonas
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
            this.labCabeceraAltaMed = new System.Windows.Forms.Label();
            this.labMed = new System.Windows.Forms.Label();
            this.lstMedicos = new System.Windows.Forms.ListBox();
            this.lstPacientes = new System.Windows.Forms.ListBox();
            this.labPacientes = new System.Windows.Forms.Label();
            this.butCancelar = new System.Windows.Forms.Button();
            this.labTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labCabeceraAltaMed
            // 
            this.labCabeceraAltaMed.BackColor = System.Drawing.SystemColors.Highlight;
            this.labCabeceraAltaMed.Dock = System.Windows.Forms.DockStyle.Top;
            this.labCabeceraAltaMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCabeceraAltaMed.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labCabeceraAltaMed.Location = new System.Drawing.Point(0, 0);
            this.labCabeceraAltaMed.Name = "labCabeceraAltaMed";
            this.labCabeceraAltaMed.Size = new System.Drawing.Size(632, 47);
            this.labCabeceraAltaMed.TabIndex = 2;
            this.labCabeceraAltaMed.Text = "Total de personas en el hospital";
            this.labCabeceraAltaMed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labMed
            // 
            this.labMed.AutoSize = true;
            this.labMed.Location = new System.Drawing.Point(9, 68);
            this.labMed.Name = "labMed";
            this.labMed.Size = new System.Drawing.Size(59, 16);
            this.labMed.TabIndex = 3;
            this.labMed.Text = "Medicos";
            // 
            // lstMedicos
            // 
            this.lstMedicos.FormattingEnabled = true;
            this.lstMedicos.ItemHeight = 16;
            this.lstMedicos.Location = new System.Drawing.Point(12, 87);
            this.lstMedicos.Name = "lstMedicos";
            this.lstMedicos.Size = new System.Drawing.Size(258, 196);
            this.lstMedicos.TabIndex = 4;
            // 
            // lstPacientes
            // 
            this.lstPacientes.FormattingEnabled = true;
            this.lstPacientes.ItemHeight = 16;
            this.lstPacientes.Location = new System.Drawing.Point(341, 87);
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(247, 196);
            this.lstPacientes.TabIndex = 5;
            // 
            // labPacientes
            // 
            this.labPacientes.AutoSize = true;
            this.labPacientes.Location = new System.Drawing.Point(338, 68);
            this.labPacientes.Name = "labPacientes";
            this.labPacientes.Size = new System.Drawing.Size(67, 16);
            this.labPacientes.TabIndex = 6;
            this.labPacientes.Text = "Pacientes";
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(225, 353);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(156, 38);
            this.butCancelar.TabIndex = 7;
            this.butCancelar.Text = "Cerrar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // labTotal
            // 
            this.labTotal.AutoSize = true;
            this.labTotal.Location = new System.Drawing.Point(13, 312);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(120, 16);
            this.labTotal.TabIndex = 8;
            this.labTotal.Text = "Total de personas:";
            // 
            // FormTotalPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(632, 403);
            this.Controls.Add(this.labTotal);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.labPacientes);
            this.Controls.Add(this.lstPacientes);
            this.Controls.Add(this.lstMedicos);
            this.Controls.Add(this.labMed);
            this.Controls.Add(this.labCabeceraAltaMed);
            this.Name = "FormTotalPersonas";
            this.Text = "Herramienta gestion hospital: Listado de personas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCabeceraAltaMed;
        private System.Windows.Forms.Label labMed;
        private System.Windows.Forms.ListBox lstMedicos;
        private System.Windows.Forms.ListBox lstPacientes;
        private System.Windows.Forms.Label labPacientes;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.Label labTotal;
    }
}