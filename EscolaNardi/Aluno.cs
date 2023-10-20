using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaNardi
{
    public class Aluno
    {
        public string Nome { get; set; }
        public Guid idAluno { get; set; }
        public double Nota { get; set; }


        public IList<double> Notas = new List<double>();

        public IList<Disciplinas> Disciplina = new List<Disciplinas>();

        public Aluno(string nome, Guid idAluno)
        {
            Nome = nome;
            this.idAluno = idAluno;
            //Não iniciar lista vazi
            Notas = new List<double>();
            Disciplina = new List<Disciplinas>();
           
        }

        public  double CalcularMedia(IList<double> notasAluno)
        {
            return notasAluno.Sum()/notasAluno.Count();
        }

        public void MostrarDisciplinas()
        {
            Disciplinas dis = new Disciplinas();
            foreach( var materia in dis.Materia)
            {
                Console.WriteLine(materia);
            }

           
        }

        

       
    }

}
