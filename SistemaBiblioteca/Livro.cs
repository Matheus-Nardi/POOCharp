using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca
{
    public class Livro
    {
        public Livro()
        {
          
            Console.WriteLine("Titulo do Livro :");
            Titulo = Console.ReadLine();
            Console.WriteLine("Autor do Livro :");
            Autor = Console.ReadLine();
            Console.WriteLine("Numero de Páginas :");
            Paginas = int.Parse(Console.ReadLine());
            Alugado = false;
        }
      
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Paginas { get; set; }

        public bool Alugado { get; set; }

         List<string> AlgunsLivros = new List<string>();
        
        //List<string> AutorList = new List<string>();

    }
}
