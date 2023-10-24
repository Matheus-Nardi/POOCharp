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
        public string Nome
        {
            get { return nome; }
            set
            {
                if (value != null)
                {
                    nome = value;
                }
                else
                {
                    Console.WriteLine("Nome nulo");
                    nome = "desconhecido";

                }
            }
        }
        public char Sexo
        {
            
            get { return sexo; }
            set 
            { 
              if(value != 'M' && value != 'F' )
                {
                    Console.WriteLine("Sexo não reconhecido");
                    sexo = '?';
                }
                else
                    sexo = value;
            
            }
        
        }

        char sexo;
        string nome;

    }
}
