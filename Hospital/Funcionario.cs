using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public abstract class Funcionario : Pessoa
    {
        public DateTime DatadeAdmissao { get; set; }
        public Guid Matricula { get; set; }
    }
}
