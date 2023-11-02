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
            MostrarListaMedicos();//Llamamos para mostrar la lista al abrir
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            AnadirPaciente();//Llamamos a la funcion para añadir el paciente
            this.Close();
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Funcion para mostrar los medicos en la listas
        private void MostrarListaMedicos()
        { 
            cmbMedicos.Items.Clear();
            foreach (Medico med in infoForm.hospital.Medicos)
            {
                cmbMedicos.Items.Add(med.Nombre);
            }
        }

        //Funcion para añadir el paciente al medico seleccionado
        private void AnadirPaciente()
        {
            int id = 1;
            string nombre = txtNombre.Text;

            foreach (Medico med in infoForm.hospital.Medicos)
            {
                foreach (Paciente pac in med.Pacientes)
                    id = pac.Id + 1; //Con el ultimo paciente seteamos el id
            }

            //Recorremos las listas para añadir el paciente al medico
            foreach (Medico med in infoForm.hospital.Medicos)
            {
                if (med.Nombre == cmbMedicos.SelectedItem.ToString())
                {
                    med.Pacientes.Add(new Paciente(id, nombre));
                }
            }
        }
    }
}
