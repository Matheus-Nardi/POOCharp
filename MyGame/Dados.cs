using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    partial class Batalha
    {
        private int d1;
        public int Dado { get; set; }
        public void RolarDados()
        {
           Random dados = new Random();
            d1 =dados.Next(1, 7);
            Console.WriteLine("Rolando os dados...");
            Thread.Sleep(1000);
            Console.WriteLine($"Voce tirou {d1}");
            
           
        }

        
          
         Personagem personagem = new Personagem();
         Mob m = new Mob();
        private void AtaquePersosagem()
        {
            if(d1 < 4)
                personagem.Ataque = 12;
            else if(d1 > 5 && d1 <8)
                personagem.Ataque = 14;
            else  
                personagem.Ataque= 20;
        }
        public void AçãodeAtaque()
        {
            if(personagem.Ataque > 8)
            {
                AtaquePersosagem();
                Console.WriteLine($"Voce acertou um crítico e tirou {personagem.Ataque} de vida do inimigo");
            }
            else
            {
                AtaquePersosagem();
                Console.WriteLine($"Voce tirou {personagem.Ataque} de vida do inimigo");
                
            }
        }
        public void TirarVidaDoInimigo()
        {
            m.NomeMob = "Gladiador das Neves";
            Console.WriteLine($"Vida atual de {m.NomeMob} = {m.VidaMob - personagem.Ataque}");
        }

       
       

        
        
    }
}
