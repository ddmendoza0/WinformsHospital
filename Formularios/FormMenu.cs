﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsHospital.Formularios;

namespace WinformsHospital
{
    public partial class FormMenu : Form
    {
        //Iniciamos el hospital
        public Hospital hospital = new Hospital();
        
        public FormMenu()
        {
            //Añadimos unos medicos para comprobacion de datos
            hospital.Medicos.Add(new Medico(100, "Quique Chatarras", "Cardiologia"));
            hospital.Medicos.Add(new Medico(101, "El que no debe ser nombrado", "Neurologia"));
            hospital.Medicos.Add(new Medico(102, "Frodo Bolson", "Generalista"));

            //Añadimos pacientes
            hospital.Medicos[1].Pacientes.Add(new Paciente(500, "Enfermito A"));
            hospital.Medicos[1].Pacientes.Add(new Paciente(501, "Enfermito B"));
            hospital.Medicos[2].Pacientes.Add(new Paciente(502, "Enfermito C"));

            InitializeComponent();
        }

        private void OnClickAltaMedico(object sender, EventArgs e)
        {
            FormAltaMedico nuevoFormAltaMedico = new FormAltaMedico(this);
            nuevoFormAltaMedico.Show();
        }

        private void butAltaPaciente_Click(object sender, EventArgs e)
        {
            FormAdmitirPaciente nuevoFormAltaPaciente = new FormAdmitirPaciente(this);
            nuevoFormAltaPaciente.Show();
        }

        private void butListaMedic_Click(object sender, EventArgs e)
        {
            FormLstMedico nuevoFormLstMedico = new FormLstMedico(this);
            nuevoFormLstMedico.Show();
        }

        private void butBajaPaciente_Click(object sender, EventArgs e)
        {
            FormDarAlta nuevoFormDarAlta = new FormDarAlta(this);
            nuevoFormDarAlta.Show();
        }

        private void butCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butLstPersonas_Click(object sender, EventArgs e)
        {
            FormTotalPersonas nuevoFormTotal = new FormTotalPersonas(this);
            nuevoFormTotal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormListaPacientes nuevoFormPersonas = new FormListaPacientes(this);
            nuevoFormPersonas.Show();
        }
    }
}
