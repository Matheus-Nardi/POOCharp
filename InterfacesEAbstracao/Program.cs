namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Não consigo instancias uma classe abstrata
           var pag = new PagametoBoleto();
           pag.Pagar(100);
        }
    }

    // Posso tornar a classe Pagamento abstrata , porque ela é vaga 
    public abstract class Pagamento : IPagamento
    {
        public DateTime Vencimento { get; set; }

        public virtual void Pagar(double valor)
        {
           
        }
    }

    public class PagametoCartaoCredito : Pagamento
    {
        public DateTime Vencimento { get; set; }

        public override void Pagar(double valor)
        {

        }
    }  public class PagametoBoleto : Pagamento
    {
        public DateTime Vencimento { get; set; }

        public override void Pagar(double valor)
        {

        }
    }


    public interface IPagamento
    {
        // Aqui virá as informações que a classe pagamento deve conter 
        //Não é nessecario modificadores de acesso(public , private ...)

         DateTime Vencimento { get; set; }

        //Nos métodos não é necessario os parentes e definir o que é ocorre , apenas declarar que possui um método
        //SEM IMPLEMENTAÇÕES
        void Pagar(double valor);
    }
}