namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pacientes = new List<Paciente>();
            Console.WriteLine("Quantos pacientes serão adcionados ?");
            var qtd = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtd; i++)
            {
                var paci = new Paciente();
                Console.WriteLine("NOME:");
                paci.Nome = Console.ReadLine();
                Console.WriteLine("SEXO : M|F");
                paci.Sexo = char.Parse(Console.ReadLine());
                paci.DataDeInternação = DateTime.Now;
            
                pacientes.Add(paci);

            }
             Console.WriteLine("DADOS DO PACIENTE");
             foreach(var paciente in pacientes)
            {
                Console.WriteLine("Nome : " + paciente.Nome);
                Console.WriteLine("Sexo :" + paciente.Sexo);
                Console.WriteLine($"Data de Internação :{paciente.DataDeInternação.ToString("f")}");

            }


            Console.WriteLine("------------------");
            Console.WriteLine("AREA MEDICA");
            var med = new Medico();
            var infoMedico = med.MostrarDados();
            Console.WriteLine(infoMedico);
            Console.WriteLine("------------------");

            Console.WriteLine("AREA DO GERENTE");
            var gerente = new Gerente();
            var comprovantePix = gerente.LiberarPIX();
            Console.WriteLine(comprovantePix);

            Console.WriteLine("-------------------");




            Console.ReadLine();
        }
    }
}