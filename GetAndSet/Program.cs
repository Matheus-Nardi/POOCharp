using System.ComponentModel.DataAnnotations;

namespace GetAndSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pagamento = new Pagamento();
            pagamento.DataDePagamento = DateTime.Now;
            pagamento.Vencimento = DateTime.Now;
            Console.WriteLine(pagamento.Vencimento);
            Console.ReadLine();
        }
    }

    public class Pagamento
    {
        public DateTime Vencimento { get; set; }

        //
        private DateTime _dataDePagamento;

        public DateTime DataDePagamento
        {
            get {
                Console.WriteLine("Lendo o  valor:");
                return _dataDePagamento; }
            set {
                Console.WriteLine("Atribuindo o valor");
                _dataDePagamento = value; }
        }

    }
}