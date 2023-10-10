namespace UpCastAndDownCast
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var pessoa = new Pessoa();
            //Down Cast
            pessoa = new PessoaFisica();
            pessoa = new PesssoaJuridica();
             
            var pessoaFisica = new PessoaFisica();
            var pessoaJuridica = new PesssoaJuridica();

            //Up Cast
            pessoaFisica = (PessoaFisica)pessoa;
        }
    }

    public class Pessoa
    {
        public string Nome { get; set; }
    }

    public class PessoaFisica : Pessoa 
    {
        public string CPF { get; set; }
    }

    public class PesssoaJuridica : Pessoa
    {
        public string CNPJ { get; set;}
    }
}