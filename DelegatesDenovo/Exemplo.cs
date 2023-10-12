using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDenovo
{
    public class Exemplo
    {
        public delegate void FunçãoPreguiça(int num);

        public FunçãoPreguiça FaçaAlgo;

        public Exemplo()
        {
            FaçaAlgo = Fun1;
            Fun1(4);
        }

        public void Fun1(int num)
        {
            Console.WriteLine($"Olha , um número :{num}");
        }
       
    }
}
