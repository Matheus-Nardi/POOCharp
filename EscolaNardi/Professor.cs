using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaNardi
{
    public class Professor
    {
        public Professor(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public string Nome { get; set; }
        public double Salario { get; set; }

        public void AdicionarDisciplina()
        {
            var dis = new Disciplinas();
            Console.WriteLine("Digite o nome da máteria :");
            var novaDisci = Console.ReadLine();
            dis.Materia.Add(novaDisci);
            Console.WriteLine($"{novaDisci} adicionada");
        }

       
    }
}
