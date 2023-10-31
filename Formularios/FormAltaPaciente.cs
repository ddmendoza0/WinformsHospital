using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsHospital.Formularios
{
    public partial class FormAltaPaciente : Form
    {
        FormMenu infoForm;

        public FormAltaPaciente(FormMenu menuPrincipal)
        {
            infoForm = menuPrincipal;
            InitializeComponent();
            MostrarListaMedicos();
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            int id = 1;
            string nombre = txtNombre.Text;

            foreach (Medico med in infoForm.hospital.Medicos)
            {
                if (med.Nombre == cmbMedicos.SelectedItem.ToString())
                    med.Pacientes.Add(new Paciente(id, nombre));
            }
            this.Close();
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarListaMedicos()
        { 
            cmbMedicos.Items.Clear();
            foreach (Medico med in infoForm.hospital.Medicos)
            {
                cmbMedicos.Items.Add(med.Nombre);
            }
        }
    }
}
