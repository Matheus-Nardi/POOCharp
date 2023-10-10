namespace CompararObj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //O que não da certo , pq classes são refence types(sei apenas o endereço)
            var pessoaA = new Pessoa(1, "Matheus Nardi");
            var pessoaB = new Pessoa(1, "Matheus Nardi");
            Console.WriteLine(pessoaA == pessoaB);

            //A maneira ineficiente , pois verifica propriedade por propriedade
            Console.WriteLine(pessoaA.Id == pessoaB.Id);

            //A mais eficiente com interface
             if(pessoaA.Equals(pessoaB) == true)
              {
                Console.WriteLine("Usario Ja existente");
                
              }
           

            Console.ReadLine();
        }
    }

    public class Pessoa : IEquatable<Pessoa>
    {
        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public int Id { get; set; }
        public string Nome { get; set; }

        public bool Equals(Pessoa other)
        {
            return Id == other.Id || Nome == other.Nome;
        }
    }
}