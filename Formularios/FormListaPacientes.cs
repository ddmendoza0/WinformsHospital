using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsHospital
{
    public partial class FormListaPacientes : Form
    {
        FormMenu infoForm;

        public FormListaPacientes(FormMenu menuPrincipal)
        {
            infoForm = menuPrincipal;
            InitializeComponent();
            MostrarListaPacientes();
        }

        private void MostrarListaPacientes()
        {
            lstPacientes.Items.Clear();
            foreach (Medico med in infoForm.hospital.Medicos)
            {
                foreach (Paciente pac in med.Pacientes)
                    lstPacientes.Items.Add(pac.Nombre);
            }
        }

        //Mostrar el id del paciente y el nombre del medico asignado
        private void lstPacientes_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (Medico med in infoForm.hospital.Medicos)
            {
                foreach (Paciente pac in med.Pacientes)
                {
                    if (pac.Nombre == lstPacientes.SelectedItem.ToString())
                    {
                        txtMedico.Text = med.Nombre.ToString();
                        txtIdPaciente.Text = pac.Id.ToString();
                    }
                }
            }
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
