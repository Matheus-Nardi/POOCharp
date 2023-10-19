using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CarrinhoDeCompra
{
    public class CarrinhoDeCompra
    {
        public List<Produto> produtos = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        public double CalcularProdutos()
        {
            double sum = 0;
            foreach (var item in produtos)
            {
                sum += item.Preco;
            }

            return sum;
        }
    }
}
