using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsHospital
{
    public class Medico : Persona
    {
        private string especialidad;
        private List<Paciente> pacientes = null;

        public string Especialidad { get { return especialidad; } set { especialidad = value; } }
        public List<Paciente> Pacientes
        {
            get
            {
                if (pacientes == null)
                    pacientes = new List<Paciente>();
                return pacientes;
            }
            set { pacientes = value; }
        }

        public Medico() { }

        public Medico(int id, string nombre, string especialidad) : base(id, nombre)
        {
            Id = id;
            Especialidad = especialidad;
            Nombre = nombre;
        }
    }
}
