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
            this.lstPersonas = new System.Windows.Forms.ListBox();
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
            // lstPersonas
            // 
            this.lstPersonas.FormattingEnabled = true;
            this.lstPersonas.ItemHeight = 16;
            this.lstPersonas.Location = new System.Drawing.Point(15, 76);
            this.lstPersonas.Name = "lstPersonas";
            this.lstPersonas.Size = new System.Drawing.Size(608, 244);
            this.lstPersonas.Sorted = true;
            this.lstPersonas.TabIndex = 4;
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
            this.labTotal.Location = new System.Drawing.Point(12, 57);
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
            this.Controls.Add(this.lstPersonas);
            this.Controls.Add(this.labCabeceraAltaMed);
            this.Name = "FormTotalPersonas";
            this.Text = "Herramienta gestion hospital: Personas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCabeceraAltaMed;
        private System.Windows.Forms.ListBox lstPersonas;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.Label labTotal;
    }
}