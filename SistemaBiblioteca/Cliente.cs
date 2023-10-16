using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca
{
    public class Cliente
    {
        public Cliente()
        {
            
           Console.WriteLine("Insira o se nome para registro:");
           Nome = Console.ReadLine();
            
        }
        public Guid Id { get; set; }
        public string Nome { get; set; }

        
       
    }
}
