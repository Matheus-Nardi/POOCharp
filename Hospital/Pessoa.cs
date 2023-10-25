using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public abstract class Pessoa
    {
        protected string Nome { get; set; }
        protected DateTime DataDeNascimento { get; set; }

        protected Endereco Endereco { get; set; }
    }

    public class Endereco
    {
        public string Logradouro { get; set; }
        private int Numero { get; set; }
        private string Bairro { get; set; }
        private int CEP { get; set; }
      
    }

}
