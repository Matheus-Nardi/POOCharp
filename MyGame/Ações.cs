using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    partial class Dado
    {
        public void Dano()
        {
            RolarDado();
            Console.WriteLine($"Vida do Inimigo: {pe.Life}");

            MsgBatalha();
            ShowInfo();

            pe.Life -= pe.DanoSofrido;
            if (pe.Life <= 0)
            {
                pe.Life = 0;
                Console.WriteLine($"Voce derrotou o {pe.Nome}");
                Console.WriteLine($"Vida do Inimigo: {pe.Life}");
            }
            else
            {
                Console.WriteLine($"Vida do Inimigo: {pe.Life}");

            }
        }

        public static void MsgBatalha()
        {
            Console.WriteLine("Iniciando Batalha...");
            Thread.Sleep(1200);
            Console.WriteLine("Rolando os dados...");
            Thread.Sleep(1100);
            Console.Clear();
        }

        public void ShowInfo() 
        {
            Console.Clear();
            int dano;
            if (Resultado < 2)
            {

                Console.WriteLine($"Dado : {Resultado}");
                Console.WriteLine("Você errou!");
                pe.DanoSofrido = 0;
            }
            else if (Resultado <= 6)
            {
                dano = 3;
                Console.WriteLine($"Dado : {Resultado}");
                Console.WriteLine($"Você acertou e tirou {dano} de vida");
                pe.DanoSofrido = 3;
            }
            else if (Resultado <= 8)
            {
                dano = 5;
                Console.WriteLine($"Dado : {Resultado}");
                Console.WriteLine($"Você acertou e tirou {dano} de vida");
                pe.DanoSofrido = 5;
            }
            else
            {
                dano = 7;
                Console.WriteLine($"Dado : {Resultado}");
                Console.WriteLine($"DANO CRÍTICO, tirou {dano} de vida");
                pe.DanoSofrido = 7;
            }

        }

        public void Fugir()
        {
            Console.Clear();
            Console.WriteLine("Para fugir voce deve tirar o valor máximo do dado");
            Console.WriteLine("Rolando os dados...");
            Thread.Sleep(1500);
            RolarDado();
            if(Resultado == 10)
            {
                Console.WriteLine($"Dado : {Resultado}");
                Console.WriteLine("BOA , VOCE CONSEGUIU");
            }
            else
            {
                Console.WriteLine($"Dado : {Resultado}");
                Console.WriteLine("Não foi dessa vez");
            }
        }
    }
}

