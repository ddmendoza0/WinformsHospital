using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsHospital
{
    public class Paciente : Persona
    {
        public Paciente() { }

        public Paciente(int id, string nombre) : base(id, nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
