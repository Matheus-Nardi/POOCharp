using System;
using System.Threading;

namespace MyGame
{
    partial class Dado
    {
        private Person pe = new Person();
        
        public void RolarDado()
        {
            Random dado = new Random();
            Resultado = dado.Next(1, 11); // Alterei para de 1 a 10 para incluir todos os números possíveis do dado de 10 faces
        }

        public int Resultado { get; set; }

        public void Usuario()
        {
            Console.WriteLine($"Nome do Inimigo: {pe.Nome}");
            do
            {
                Console.WriteLine("1 - Ataque");
                Console.WriteLine("2-Fugir");
                Console.WriteLine("Escolha uma ação:");

                short op = short.Parse(Console.ReadLine());
                if(op == 2 )
                {
                    Fugir();
                }
                else
                {
                    switch (op)
                    {
                        case 1:
                            Console.Clear();
                            Dano();
                            pe.ShowInfoAtk();
                            var vidaUs = pe.MsgVidaDoUsuario();
                            if(vidaUs == 0)
                            {
                                Console.WriteLine("INIMIGO MORTO");
                            }
                           
                            break;
                    
                    }

                }
            } while (pe.Life > 0 );
        }
    }
        
}
