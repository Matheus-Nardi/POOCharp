namespace GerenciamentoBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando Conta Corrente
            var contaCorrente = new ContaCorrente(Guid.NewGuid() , 1000 , 0.10);
            contaCorrente.DepositarValor(50);
            var taxaContaCorrente = contaCorrente.CalcularTaxaDeTransacao();
            Console.WriteLine($"ID : {contaCorrente.IdDaConta}");
            Console.WriteLine($"Saldo {contaCorrente.SaldoDaConta:C}");
            Console.WriteLine($"Taxa mensal de Transação {taxaContaCorrente:C}");

            Console.WriteLine("-------------------------------------------------");
            //Criando Conta Poupança
            var contaPoupanca = new ContaPoupança(Guid.NewGuid() , 1000 , 0.012, 3);
            contaPoupanca.SacarValor(50);
            var taxaDeRendimento = contaPoupanca.CalularRendimentoPoupanca();

            Console.WriteLine($"ID :{contaPoupanca.IdDaConta}");
            Console.WriteLine($"Saldo {contaPoupanca.SaldoDaConta:C}");
            Console.WriteLine($"Possivel rendimento na poupança em {contaPoupanca.MesesNaConta} meses com taxa de {contaPoupanca.TaxaDeJuros}% = {taxaDeRendimento:c}");


            Console.Read();
        }
    }
}