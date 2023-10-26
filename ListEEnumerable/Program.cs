namespace ListEEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var limiteCredito = new List<Limite>();

            for(int i = 0 ; i <16; i++)
            {
                limiteCredito.Add(new Limite() { Numero = i });
            }

            var limitesComRestrição = limiteCredito.Where(x => x.AnalisaLimite()).ToList();
            if(limitesComRestrição.Count() > 3)
            {
                Console.WriteLine("Ha mais de 3 limites com retrição");
            }
        }   
    }

    public class Limite
    {
        public int Numero { get; set; }
        private bool isRestricao;

        public Limite()
        {
            var semente = Guid.NewGuid().GetHashCode();
            var numeroAleatorio = new Random(semente).Next(1,4);
            isRestricao = numeroAleatorio == 1;
        }

        public bool AnalisaLimite()
        {
            Console.WriteLine($"Executa analise de limite de credito para o limite {Numero}");
            return isRestricao;
        }
    }
}