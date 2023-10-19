using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoBanco
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(Guid idDaConta , double valor , double taxaDeTransacao) : base( idDaConta , valor )
        {
           
            TaxaDeTransacao = taxaDeTransacao;
        }
        public double TaxaDeTransacao { get; set; }
        public double  CalcularTaxaDeTransacao()
        {
            return SaldoDaConta * TaxaDeTransacao;  
        }
    }
}
