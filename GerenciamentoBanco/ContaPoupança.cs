using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoBanco
{
    public class ContaPoupança : ContaBancaria

    {
        public ContaPoupança( Guid idDaConta , double valor ,double taxaDeJuros ,int mesesRendimento) : base (idDaConta , valor)
        {
          
            TaxaDeJuros = taxaDeJuros;
            MesesNaConta = mesesRendimento;
            
        }

        public double TaxaDeJuros { get; set; }
        public int MesesNaConta { get; set; }

        public double CalularRendimentoPoupanca()
        {
            return SaldoDaConta * Math.Pow((TaxaDeJuros +1) , MesesNaConta);
        }
    }
}
