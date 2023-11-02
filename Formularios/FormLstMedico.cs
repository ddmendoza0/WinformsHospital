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
    public partial class FormLstMedico : Form
    {
        FormMenu infoForm;

        public FormLstMedico(FormMenu menuPrincipal)
        {
            infoForm = menuPrincipal;
            InitializeComponent();
            MostrarListaMedicos(); //Llamamos a la funcion para que nos cargue la lista de medicos

        }

        //Funcion que muestra los medicos
        private void MostrarListaMedicos()
        {
            lstMedicos.Items.Clear();
            foreach (Medico med in infoForm.hospital.Medicos)
            {
                lstMedicos.Items.Add(med.Nombre);
            }
        }

        //Funcion que muestra los pacientes de un medico
        private void MostrarListaPacientes(string nombreMedico)
        {
            lstPacientes.Items.Clear();
            foreach (Medico med in infoForm.hospital.Medicos)
            {
                if (med.Nombre == nombreMedico)
                {
                    foreach (Paciente pac in med.Pacientes)
                        lstPacientes.Items.Add(pac.Nombre);
                }
            }
        }

        private void butCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Al seleccionar un medico llamamos a la funcion para mostrar los pacientes
        private void lstMedicos_SelectedValueChanged(object sender, EventArgs e)
        {
            MostrarListaPacientes(lstMedicos.SelectedItem.ToString());
        }
    }
}
