namespace WinformsHospital
{
    partial class FormLstMedico
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
            this.lstMedicos = new System.Windows.Forms.ListBox();
            this.lstPacientes = new System.Windows.Forms.ListBox();
            this.labLstMedicos = new System.Windows.Forms.Label();
            this.labLstPacientes = new System.Windows.Forms.Label();
            this.butCerrar = new System.Windows.Forms.Button();
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
            this.labCabeceraLstMedic.Size = new System.Drawing.Size(682, 47);
            this.labCabeceraLstMedic.TabIndex = 2;
            this.labCabeceraLstMedic.Text = "Listado de medicos";
            this.labCabeceraLstMedic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstMedicos
            // 
            this.lstMedicos.FormattingEnabled = true;
            this.lstMedicos.ItemHeight = 16;
            this.lstMedicos.Location = new System.Drawing.Point(12, 76);
            this.lstMedicos.Name = "lstMedicos";
            this.lstMedicos.Size = new System.Drawing.Size(299, 164);
            this.lstMedicos.TabIndex = 3;
            this.lstMedicos.SelectedValueChanged += new System.EventHandler(this.lstMedicos_SelectedValueChanged);
            // 
            // lstPacientes
            // 
            this.lstPacientes.FormattingEnabled = true;
            this.lstPacientes.ItemHeight = 16;
            this.lstPacientes.Location = new System.Drawing.Point(371, 76);
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(299, 164);
            this.lstPacientes.TabIndex = 4;
            // 
            // labLstMedicos
            // 
            this.labLstMedicos.AutoSize = true;
            this.labLstMedicos.Location = new System.Drawing.Point(12, 57);
            this.labLstMedicos.Name = "labLstMedicos";
            this.labLstMedicos.Size = new System.Drawing.Size(131, 16);
            this.labLstMedicos.TabIndex = 5;
            this.labLstMedicos.Text = "Medicos por nombre";
            // 
            // labLstPacientes
            // 
            this.labLstPacientes.AutoSize = true;
            this.labLstPacientes.Location = new System.Drawing.Point(368, 57);
            this.labLstPacientes.Name = "labLstPacientes";
            this.labLstPacientes.Size = new System.Drawing.Size(137, 16);
            this.labLstPacientes.TabIndex = 6;
            this.labLstPacientes.Text = "Pacientes del medico";
            // 
            // butCerrar
            // 
            this.butCerrar.Location = new System.Drawing.Point(261, 303);
            this.butCerrar.Name = "butCerrar";
            this.butCerrar.Size = new System.Drawing.Size(158, 38);
            this.butCerrar.TabIndex = 8;
            this.butCerrar.Text = "Cerrar";
            this.butCerrar.UseVisualStyleBackColor = true;
            this.butCerrar.Click += new System.EventHandler(this.butCerrar_Click);
            // 
            // FormLstMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 353);
            this.Controls.Add(this.butCerrar);
            this.Controls.Add(this.labLstPacientes);
            this.Controls.Add(this.labLstMedicos);
            this.Controls.Add(this.lstPacientes);
            this.Controls.Add(this.lstMedicos);
            this.Controls.Add(this.labCabeceraLstMedic);
            this.Name = "FormLstMedico";
            this.Text = "Herramienta gestion hospital: Listado de medicos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCabeceraLstMedic;
        private System.Windows.Forms.ListBox lstMedicos;
        private System.Windows.Forms.ListBox lstPacientes;
        private System.Windows.Forms.Label labLstMedicos;
        private System.Windows.Forms.Label labLstPacientes;
        private System.Windows.Forms.Button butCerrar;
    }
}