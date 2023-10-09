using Pagamento;

namespace ClassePartial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pag = new Pagamentos();
            pag.PropA = 1;
            pag.PropB = 2;
            Console.WriteLine($"{pag.PropA} {pag.PropB}");
            Console.ReadLine();
        }
    }
}