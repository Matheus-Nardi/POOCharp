using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public  class Person
    {
        public Person()
        {
            Life = 15;
            DanoSofrido = 0;
            Nome = null;
            Vivo = true;
        }

        public void EscolhendoInimigo()
        {
            var nomes = new List<string>() { "Sião" , "Wuivo" , "Cacetinho" , "Arno"};
            Random aleatorio = new Random();
            int num = aleatorio.Next(0, 4);
            Nome = nomes[num];
        }

        public int Life { get; set; }
        public int DanoSofrido { get; set; }
        public int DanoAoUsuario { get; set; }
        public string Nome { get; set; }
        public int DadoPerson { get; set; }

        public bool Vivo { get; set; }

        public void AtkPerson()
        {
             Random dado = new Random();
             DadoPerson = dado.Next(1, 11);

        }

        Usuario u = new Usuario();
        public void ShowInfoAtk()
        {
           
            AtkPerson();
            Thread.Sleep(1500);
            Console.WriteLine("------------------------------");
            if (Vivo == false)
            {
                Thread.Sleep(1400);
                return;
            }
            else
            {
            MsgPerson();

            }
            if (DadoPerson < 2)
            {
                DanoAoUsuario = 0;
                Console.WriteLine("O inimigo errou!");
            }
            else if (DadoPerson <= 6)
            {

                DanoAoUsuario = 4;
                Console.WriteLine($"O inimigo tirou {DanoAoUsuario} de vida");
               
               


            }
            else if (DadoPerson <= 8)
            {
                DanoAoUsuario = 6;
                Console.WriteLine($"O inimigo tirou {DanoAoUsuario} de vida");
                
               

            }
            else
            {
                DanoAoUsuario = 7;
                Console.WriteLine($"DANO CRÍTICO, o inimigo tirou {DanoAoUsuario} de vida");
              

            }
            
            var vida = u.getVida();
            u.VidaUsuario -= vida;
            Console.WriteLine("Sua vida : " + u.VidaUsuario);
            
        }

        public  void MsgPerson()
        {
            Console.WriteLine($"Vez do {Nome}");
            Thread.Sleep(1500);
        }

        
    }
}
