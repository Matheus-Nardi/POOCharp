using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SistemaBiblioteca
{
    public class Biblioteca
    {

        List<Livro> livroList = new List<Livro>();
        public Biblioteca()
        {
            livroList = new List<Livro>();

        }

        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("MENU SIMPLES");
            Console.WriteLine("1-VER LIVROS");
            Console.WriteLine("2-ADD LIVROS");
            Console.WriteLine("3-REMOVER LIVROS");
            Console.WriteLine("4-ALUGAR LIVRO");
            Console.WriteLine("OPÇÃO :");
            short op = short.Parse(Console.ReadLine());

            switch (op)
            {

                case 1: LivrosExistentes(); break;
                case 2: AdicionarLivros(); break;
                case 3: RemoverLivro(); break;
                case 4: AlugarLivro(); break;
                default: Menu(); break;
            }
        }
        public void AdicionarLivros()
        {
            Console.Clear();
            var novoLivro = new Livro();
            livroList.Add(novoLivro);
            Console.WriteLine("Livro Adicionado com sucesso");
            Thread.Sleep(1400);
            Menu();
        }

        public void RemoverLivro()
        {
            Console.Clear();
            Console.WriteLine("Insira o titulo do livro a ser Removido ?");
            string titulo = Console.ReadLine();

            Livro livroParaRemover = livroList.Find(l => l.Titulo == titulo);
            if (livroParaRemover != null)
            {
                livroList.Remove(livroParaRemover);
                Console.WriteLine("Livro Removido com sucesso");
            }
            else
            {
                Console.WriteLine("Livro não encontrado na lista.");
            }
            Thread.Sleep(1400);
            Menu();
        }

        public void LivrosExistentes()
        {

            if (livroList.Count == 0)
            {
                Console.WriteLine("Lista vazia");
                Thread.Sleep(1400);
                Menu();
            }
            else
            {
                foreach (var item in livroList)
                {

                    Console.WriteLine("---------------");
                    Console.Write($"Titulo:{item.Titulo}\nAutor:{item.Autor}\nNumero de Paginas:{item.Paginas}\n");
                    Console.WriteLine("---------------");

                    Thread.Sleep(2500);
                }
                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadKey();
                Menu();
            }
        }

        public void AlugarLivro()
        {
            Emprestimo em = new Emprestimo();
            Console.WriteLine("Livros Disponíveis:");

            foreach (var item in livroList)
            {
                if (!item.Alugado)
                {
                    Console.WriteLine("---------------");
                    Console.Write($"Título: {item.Titulo}\nAutor: {item.Autor}\nNúmero de Páginas: {item.Paginas}\n");
                    Console.WriteLine("----------------");
                    Thread.Sleep(1000);
                }
            }

            Cliente c = new Cliente();
            Console.WriteLine("Escolha seu livro | Insira o título: ");
            string titulo = Console.ReadLine();

            Livro livroParaAlugar = livroList.Find(l => l.Titulo == titulo);

            if (livroParaAlugar != null && !livroParaAlugar.Alugado)
            {
                livroParaAlugar.Alugado = true; // Marcar o livro como alugado
                Console.WriteLine($"Livro: {titulo}");
                Console.WriteLine($"Data de Retirada: {em.Retirada}");
                Console.WriteLine($"Data de Devolução: {em.Devolucao}");
                Console.WriteLine($"Em posse de {c.Nome}");
               
            }
            else if (livroParaAlugar == null)
            {
                Console.WriteLine("Livro não encontrado na lista.");
            }
            else if (livroParaAlugar.Alugado)
            {
                Console.WriteLine("Livro já está alugado.");
            }

            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            Menu();
        }
        

    }
}
