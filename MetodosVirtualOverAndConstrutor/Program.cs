using System.Runtime.CompilerServices;

namespace MetodosVirtualOverAndConstrutor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Processando Informações");
            using (Funcionario func = new Funcionario("Ricardo", 22, "CEO") )
            {
                Console.WriteLine("ENTROU ÁS {0}", func.InicioDoTrabalho());
            }
            
            

            Console.ReadLine();
        }
    }

    public class Funcionario : IDisposable 
    {
        //Método Construtor
        public Funcionario(string nome, int idade, string cargo) 
        {
            Console.WriteLine("Nome : {0}" , nome);
            Console.WriteLine("Idade : {0}" , idade);
            Console.WriteLine("Cargo : {0}" , cargo);
        }

        public void Dispose()
        {
            Console.WriteLine("Finalizando Informações");
        }

        public  DateTime InicioDoTrabalho()
        {
            return DateTime.Now;
        }

        
    }

    

}