namespace Delegate
{
    internal class Program
    {
        //Criando a função responsável
        static void RealizarPagamento(double valor)
        {
            Console.WriteLine($"Valor pago de {valor:C}");
        }

        
        static void Main(string[] args)
        {
            //Istanciando o obj e chamando a função
            var pagar = new Pagamento.Pagar(RealizarPagamento);
            pagar(87);

            Console.ReadKey();
        }
    }

    public class Pagamento
    {
        //Usando o delegate para informar que aponta para outra função
        //Aqui há apenas a declaração
        public delegate void Pagar(double valor);
    }
}