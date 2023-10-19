using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GerenciamentoBanco
{
    public abstract class ContaBancaria
    {
        public ContaBancaria(Guid idDaConta, double saldoDaConta)
        {
            IdDaConta = idDaConta;
            SaldoDaConta = saldoDaConta;
        }

        public Guid IdDaConta { get; set; }
        public double SaldoDaConta { get; set; }

        public void DepositarValor(double valor)
        {
            SaldoDaConta += valor;
        }

        public void SacarValor(double valor)
        {
            SaldoDaConta -= valor;
        }

        public double VerSaldo()
        {
            return SaldoDaConta;
        }
    }
}
