using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Gerente : Funcionario
    {
       public string LiberarPIX ()
        {
            Console.WriteLine("Digite o salario do funcionario :");
            var salario = double.Parse(Console.ReadLine());

            return $"Liberando PIX de {salario:C}";
        }
            

    }
}
