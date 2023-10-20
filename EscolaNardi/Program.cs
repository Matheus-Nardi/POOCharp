namespace EscolaNardi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var primeiraTurma = new Turma("Sala 06", "5° Ano");
            primeiraTurma.Alunos.Add(new Aluno("Pedro", Guid.NewGuid()));
            primeiraTurma.Alunos.Add(new Aluno("Maria", Guid.NewGuid()));
            primeiraTurma.Alunos.Add(new Aluno("João", Guid.NewGuid()));

            

            primeiraTurma.Professor.Add(new Professor("Cleia", 3.100));

            Console.WriteLine($"{primeiraTurma.NomeDaTurma} - {primeiraTurma.AnoDaTurma}");
            Console.Write("Professor responsável:");
            foreach(var item in primeiraTurma.Professor)
            {
                Console.WriteLine(item.Nome);
               // item.AdicionarDisciplina();
            }

            var notasGeral = new List<Double>();
            foreach (var item in primeiraTurma.Alunos)
            {
                Console.WriteLine($"{item.Nome} - Matricula : {item.idAluno.ToString().Substring(0,8)}");
                for(int i = 1; i <=4; i ++)
                {
                    Console.WriteLine($"Digite a {i}° nota de {item.Nome} :");
                    var nota = double.Parse(Console.ReadLine());
                    notasGeral.Add(nota);

                }
                Console.WriteLine($"Média de {item.Nome} : {item.CalcularMedia(notasGeral)}");
      

                //Console.WriteLine("Matriculados em : ");
               // item.MostrarDisciplinas();
            }

            


                Console.Read();
            
        }
    }
}