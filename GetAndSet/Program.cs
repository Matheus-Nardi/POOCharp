using System.ComponentModel.DataAnnotations;

namespace GetAndSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pagamento = new Pagamento(DateTime.Now.AddDays(13));
            //var pagamento = new PagarComCartao();
           
            pagamento.Vencimento = DateTime.Now;
            Console.WriteLine(pagamento.Vencimento);

           // Mesmo nome de método e assinatura
            pagamento.Pagar("123");
            Console.ReadLine();
        }
    }

    public class Pagamento
    {
        
        public Pagamento(DateTime vencimento)
        {
            Console.WriteLine("Método Construtor , sou chamado logo apos o New");
            DataDePagamento = DateTime.Now;
        }
        public DateTime Vencimento { get; set; }


        private DateTime _dataDePagamento;

        public DateTime DataDePagamento
        {
            get
            {
                Console.WriteLine("Lendo o  valor:");
                return _dataDePagamento;
            }
            set
            {
                Console.WriteLine("Atribuindo o valor");
                _dataDePagamento = value;
            }
        }

        //Sobrecarga de método , uso o virtual para permitir "assinaturas" iguais
        public virtual void Pagar(string codigoDeBarra)
        {
            Console.WriteLine("Pagar");
        }

    }

    public class PagarComCartao : Pagamento 
    {
        public PagarComCartao(DateTime vencimento):base(vencimento) 
        {
            DataDePagamento = DateTime.Now;
        }

        public override void Pagar(string codigoDeBarra)
        {
            Console.WriteLine("Pagar Cartão");
        }
    }
}