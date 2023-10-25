using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Paciente : Pessoa
    {
        private string CPF { get; set; }
        private Plano Plano { get; set; }

        public void Cadastrar(Paciente paciente)
        {
            int dia, mes, ano;
            var paci = new Paciente();
            paciente = paci;
            Console.WriteLine("----------------------");
            Console.WriteLine("CAMPO DE DADOS ");
            Console.WriteLine("Nome:");
            paciente.Nome = Console.ReadLine();
            Console.WriteLine("Data de nascimento (dd/mm/yyyy)");
            var dataDeNascimentoStr = Console.ReadLine();
            var divisao = dataDeNascimentoStr.Split("/");
            dia = int.Parse(divisao[0]);
            mes = int.Parse(divisao[1]);
            ano = int.Parse(divisao[2]);
            paciente.DataDeNascimento = new DateTime(ano, mes, dia);
            Console.WriteLine("CPF:");
            paciente.CPF = Console.ReadLine();
            


        }

        public void Alterar(Paciente paciente)
        {

        }

        public void Excluir()
        {

        }

        public Paciente Consular(string cpf)
        {
            // Arrumar
            return new Paciente();
        }
    }
}
