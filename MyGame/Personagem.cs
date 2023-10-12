using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Personagem
    {
        public Personagem()
        {
            VidaInicial = 100;
        }
        public string Nome { get; set; }
        private int VidaInicial { get;  }

        public int Ataque { get; set; }

        public void CriarPersonagem()
        {
            Console.WriteLine("Digite o nome do seu personagem :");
            Nome = Console.ReadLine();
            Console.WriteLine($"Bem vindo a aventura {Nome}");
        }
    }
}
