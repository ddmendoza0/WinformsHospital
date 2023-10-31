using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsHospital
{
    public class Persona
    {
        private int id;
        private string nombre;

        public int Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }

        public Persona() { }

        public Persona(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
