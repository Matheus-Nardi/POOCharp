using System.Threading.Channels;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando uma lista de pagamentos
            var pay = new List<Payment>();
            pay.Add(new Payment(1));
            pay.Add(new Payment(2));
            pay.Add(new Payment(3));

            foreach (var payment in pay)
            {
                Console.WriteLine(payment.Id);
            }

            var paySearch = pay.Where(x => x.Id == 1);
            

            Console.ReadKey();
        }
        public class Payment
        {
            public int Id { get; set; }
            public Payment(int id)
            {
                Id = id;
            }
        }

    }
}