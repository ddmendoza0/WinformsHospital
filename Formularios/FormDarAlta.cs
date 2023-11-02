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
    public partial class FormDarAlta : Form
    {
        FormMenu infoForm;

        public FormDarAlta(FormMenu menuPrincipal)
        {
            infoForm = menuPrincipal;
            InitializeComponent();
            MostrarListaPacientes();//Llamamamos a la funcion para rellenar la lista
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            EliminarPaciente();//Lamamos para que elimine al paciente de la lista
            MostrarListaPacientes();//Asi nos actualiza la lista
            MessageBox.Show("Operación realizada con exito");
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Funcion para llenar la lista de pacientes
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
            foreach(Medico med in infoForm.hospital.Medicos)
            {
                foreach(Paciente pac in med.Pacientes)
                {
                    if (pac.Nombre == lstPacientes.SelectedItem.ToString())
                    {
                        txtMedico.Text = med.Nombre.ToString();
                        txtIdPaciente.Text = pac.Id.ToString();
                    }
                }
            }
        }

        //Funcion para eliminar el paciente de la lista del medico
        private void EliminarPaciente()
        {
            foreach (Medico med in infoForm.hospital.Medicos)
            {
                foreach (Paciente pac in med.Pacientes.ToList())
                {
                    if (pac.Nombre == lstPacientes.SelectedItem.ToString())
                        med.Pacientes.Remove(pac);
                }
            }
        }
    }
}
