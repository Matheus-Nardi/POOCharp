using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaNardi
{
    public class Turma
    {
        public Turma(string nomeDaTurma, string anoDaTurma)
        {
            NomeDaTurma = nomeDaTurma;
            AnoDaTurma = anoDaTurma;
            Alunos = new List<Aluno>();
            Professor = new List<Professor>();

        }

        public string NomeDaTurma { get; set; }
        public string AnoDaTurma { get; set; }
        public IList<Aluno> Alunos { get; set; }
        public IList<Professor> Professor { get; set; }
    }
}
