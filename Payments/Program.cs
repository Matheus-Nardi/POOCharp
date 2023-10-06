namespace Payments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pagamentoBoleto = new PagarViaBoleto();
            var dataPagamento =pagamentoBoleto.Vencimento.ToString("d");
            pagamentoBoleto.Pagar();
            pagamentoBoleto.numeroBoleto = "8741520123";
            Console.WriteLine($"Data de vencimento{dataPagamento}");
            Console.WriteLine(pagamentoBoleto.numeroBoleto);
            
            Console.ReadLine();
        }
    }

      class Pagamento
    {
        //Propriedade
         protected DateTime Vencimento = DateTime.Now.AddDays(17);
        //Métodos-Funções
         protected void Pagar() { Console.WriteLine("Pagando"); }
        EndereçoDeCobrança ZipCode; // Acessando um tipo complexo
    }
    //Herança
    public class PagarViaBoleto : Pagamento 
    {
        void GetInfoPai()
        {
            base.Vencimento = Vencimento;
        }

    }

    public class EndereçoDeCobrança
    {
        string Cep = "";
    
    }




}