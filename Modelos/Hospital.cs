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

        public void MenuHospital()
        {
            bool salir = false;

            while (salir != true)
            {
                Console.Clear();

                Console.WriteLine("Que gestion desea realizar?\n" +
                    "[1] Dar de alta un medico\n" +
                    "[2] Dar de alta un paciente\n" +
                    "[3] Listar los medicos\n" +
                    "[4] Listar los pacientes de un medico\n" +
                    "[5] Dar de baja un paciente\n" +
                    "[6] Personas en el hospital actualmente\n" +
                    "[0] Salir");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "0":
                        salir = true;
                        break;
                    case "1":
                        //AltaMedico();
                        break;
                    case "2":
                        AltaPaciente();
                        break;
                    case "3":
                        ListarMedicos();
                        break;
                    case "4":
                        ListarPacientesMedico();
                        break;
                    case "5":
                        BajaPaciente();
                        break;
                    case "6":
                        NumberPersonas();
                        break;
                    default:
                        Console.WriteLine("Opcion no contemplada");
                        break;
                }
            }
        }

        public void AltaMedico(string nombre, string especialidad)
        {
            int id = 0;

            foreach (Medico i in Medicos)
            {
                if (i.Id == id)
                {
                    Console.WriteLine("\nERROR ID repetido");
                    Console.ReadKey();
                    return;
                }
            }

            Medicos.Add(new Medico(id, nombre, especialidad));
        }

        public void AltaPaciente()
        {
            Console.Clear();

            //Si no hay medicos en el hospital nos devuelve al menu
            if (Medicos.Count == 0)
            {
                Console.WriteLine("No hay medicos disponibles.");
                return;
            }

            int idPacient;
            int idMedic;
            do Console.Write("Introduce el ID de paciente:  \n");
            while (!int.TryParse(Console.ReadLine(), out idPacient));

            foreach (Medico medico in Medicos)//Comprovamos los ids de los pacientes
            {
                foreach (Paciente i in medico.Pacientes)
                {
                    if (i.Id == idPacient)
                    {
                        Console.WriteLine("\nERROR ID repetido");
                        Console.ReadKey();
                        return;
                    }
                }
            }

            Console.WriteLine("Introduce el nombre del paciente: ");
            string nombre = Console.ReadLine();

            do Console.WriteLine("Introduce el ID del medico a asignar: ");
            while (!int.TryParse(Console.ReadLine(), out idMedic));

            //Buscamos el medico por id y le añadimos el paciente
            foreach (Medico medic in Medicos)
            {
                if (medic.Id == idMedic)
                    medic.Pacientes.Add(new Paciente(idPacient, nombre));
            }

            Console.WriteLine($"\nEl paciente con ID: {idPacient} y Nombre: {nombre} ha sido admitido");

            Console.ReadKey();
        }

        public void ListarMedicos()
        {
            Console.Clear();

            Console.WriteLine("Medicos en el hospital:");

            foreach (Medico persona in Medicos)
                Console.WriteLine($"\nID: {persona.Id} Nombre: {persona.Nombre} Especialidad: {persona.Especialidad} Numero de pacientes: {persona.Pacientes.Count}");

            Console.ReadKey();
        }

        public void ListarPacientesMedico()
        {
            Console.Clear();

            //Pedimos el id del medico
            int idMedic;
            do Console.WriteLine("Introduce el ID del medico para ver sus pacientes: ");
            while (!int.TryParse(Console.ReadLine(), out idMedic));

            bool control = true;
            foreach (Medico medic in Medicos) //Recorremos medicos buscando el id
            {
                if (medic.Id == idMedic)
                {
                    Console.WriteLine($"\nPacientes asignados a {medic.Id} {medic.Nombre}\n");
                    foreach (Paciente paciente in medic.Pacientes)
                        Console.WriteLine($"ID: {paciente.Id} Nombre: {paciente.Nombre}");
                    control = false;
                }
            }
            if (control) //Si no encuentra el id
                Console.WriteLine($"\nNo se pudo encontra el medico con ID: {idMedic}");

            Console.ReadKey();
        }

        public void BajaPaciente()
        {
            Console.Clear();

            int idPacient; //Pedimos el id del paciente
            do Console.Write("Introduce el ID de paciente que quiere dar de baja del sistema:  \n");
            while (!int.TryParse(Console.ReadLine(), out idPacient));

            bool control = true;
            foreach (Medico medic in Medicos)
            {
                foreach (Paciente paciente in medic.Pacientes)
                {
                    if (paciente.Id == idPacient)//Si el id concuerda con el paciente del medico lo quitamos.
                    {
                        medic.Pacientes.Remove(paciente);
                        Console.WriteLine($"El paciente con ID: {paciente.Id} y Nombre: {paciente.Nombre} ha sido dado de baja del sistema");
                        control = false;
                        Console.ReadKey();
                        return;
                    }
                }
            }

            if (control) //Si no ha encontrado el id
                Console.WriteLine($"No nos ha sido posible encontrar el paciente con ID: {idPacient}");

            Console.ReadKey();
        }

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
