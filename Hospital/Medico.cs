using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Medico : Funcionario
    {
        public string CRM { get; set; }

        public void Operar()
        {
            Console.WriteLine("operando...");
        }

        public string MostrarDados()
        {
            Console.WriteLine("Nome do Médico :");
            Nome = Console.ReadLine();
            Console.WriteLine("Sexo do Médico : M|F");
            Sexo = char.Parse(Console.ReadLine());
            Matricula = Guid.NewGuid();
            Console.WriteLine(Matricula);
            Console.WriteLine("CRM :");
            CRM = Console.ReadLine();

            return $" Nome :{Nome?.ToUpper()} - Sexo :{Sexo} - CRM :{CRM} - ID :{Matricula}";
        }
    }
}
