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
    public partial class FormTotalPersonas : Form
    {
        FormMenu infoForm;

        public FormTotalPersonas(FormMenu menuPrincipal)
        {
            infoForm = menuPrincipal;
            InitializeComponent();
            MostrarListaPersonas();
            PersonasTotales();
            
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarListaPersonas()
        {
            lstPersonas.Items.Clear();
            foreach (Medico med in infoForm.hospital.Medicos)
                lstPersonas.Items.Add($"Medico {med.Id}, " + med.Nombre);
            
            foreach (Medico med in infoForm.hospital.Medicos)
            {
                foreach (Paciente pac in med.Pacientes)
                    lstPersonas.Items.Add($"Paciente {pac.Id}, " + pac.Nombre);
            }
        }

        private void PersonasTotales()
        {
            int cont = 0;
            foreach (Medico med in infoForm.hospital.Medicos)
            {
                cont++;
                foreach (Paciente pac in med.Pacientes)
                    cont++;
            }
            labTotal.Text = ("Personas totales en el hospital: " + cont.ToString());
        }
    }
}
