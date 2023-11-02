using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsHospital.Formularios;

namespace WinformsHospital
{
    public partial class FormMenu : Form
    {
        public Hospital hospital = new Hospital();
        
        public FormMenu()
        {
            InitializeComponent();
        }

        private void OnClickAltaMedico(object sender, EventArgs e)
        {
            FormAltaMedico nuevoFormAltaMedico = new FormAltaMedico(this);
            nuevoFormAltaMedico.Show();
        }

        private void butAltaPaciente_Click(object sender, EventArgs e)
        {
            FormAltaPaciente nuevoFormAltaPaciente = new FormAltaPaciente(this);
            nuevoFormAltaPaciente.Show();
        }

        private void butListaMedic_Click(object sender, EventArgs e)
        {
            FormLstMedico nuevoFormLstMedico = new FormLstMedico(this);
            nuevoFormLstMedico.Show();
        }
    }
}
