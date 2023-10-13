using System;
using System.Threading;

namespace MyGame
{
    partial class Dado
    {
        

        public void RolarDado()
        {
            Random dado = new Random();
            Resultado = dado.Next(1, 11); // Alterei para de 1 a 10 para incluir todos os números possíveis do dado de 10 faces
        }

        public int Resultado { get; set; }

        public void UsuarioInicio()
        {
            pe.EscolhendoInimigo();
            while (pe.Life > 0)
            {
                Console.WriteLine($"Nome do Inimigo: {pe.Nome}");
                Menu();
            }
            Console.Clear();
            Console.WriteLine("Vitoria");
            Console.WriteLine("Obrigado por Jogar");
            Console.WriteLine("Pressioene qualquer tecla para sair");
        }
    }

}
