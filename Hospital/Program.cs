namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pacientes = new List<Paciente>();
            var Joao = new Paciente();
            Joao.Cadastrar(Joao);
            pacientes.Add( Joao );

           


           
            Console.ReadLine();
        }
    }
}