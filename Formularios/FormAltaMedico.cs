using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsHospital;

namespace WinformsHospital.Formularios
{
    public partial class FormAltaMedico : Form
    {
        FormMenu infoForm;

        public FormAltaMedico(FormMenu menuPrincipal)
        {
            infoForm = menuPrincipal;
            InitializeComponent();
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            //Se deben seleccionar los campos para dar de alta un medico
            if (cmbEspecialidad.SelectedItem != null && txtNomMedic.Text != "")
            {
                AdmitirMedico();
                MessageBox.Show("Operación realizada con exito");

                //Volvemos a empezar
                cmbEspecialidad.SelectedValue = null;
                txtNomMedic.Text = "";
            }
            else
                MessageBox.Show("Debe rellenar los campos para admitir un medico");
        }

        private void AdmitirMedico()
        {
            int id = 1;
            string nombre = txtNomMedic.Text;
            string especialidad = cmbEspecialidad.SelectedItem.ToString();

            foreach (Medico med in infoForm.hospital.Medicos)
                    id = med.Id + 1; //Con el ultimo medico seteamos el id

            infoForm.hospital.Medicos.Add(new Medico(id, nombre, especialidad));
        }
    }
}
