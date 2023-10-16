using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca
{
    public class Emprestimo
    {
        public Emprestimo()
        {
            Retirada = DateTime.Now;
            Retirada.ToString("d");
            Devolucao = Retirada.AddDays(7);
        }
        public DateTime Retirada { get; set; }
        public DateTime Devolucao { get; set; }
    }
}
