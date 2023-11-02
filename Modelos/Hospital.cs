using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsHospital
{
    public class Hospital
    {
        private List<Medico> medicos = null;

        public List<Medico> Medicos
        {
            get
            {
                if (medicos == null)
                    medicos = new List<Medico>();
                return medicos;
            }
            set
            {
                medicos = value;
            }
        }

        public Hospital() { }

        public void NumberPersonas()
        {
            Console.Clear();

            //Sumamos 1 al cotador por cada medico y paciente
            int cont = 0;
            foreach (Medico medic in Medicos)
            {
                foreach (Paciente paciente in medic.Pacientes)
                    cont++;
                cont++;
            }
            Console.WriteLine($"El total de personas en el hospital es de {cont}");

            Console.ReadKey();
        }
    }
}
