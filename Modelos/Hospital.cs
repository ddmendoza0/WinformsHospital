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
    }
}
