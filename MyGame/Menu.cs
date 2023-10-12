using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyGame
{
     public class Menu
    {
         public  Menu() 
         {
            Batalha batalha = new Batalha();
            Console.Clear();
            batalha.RolarDados();
            batalha.AçãodeAtaque();
            batalha.TirarVidaDoInimigo();

         }

    }
}
