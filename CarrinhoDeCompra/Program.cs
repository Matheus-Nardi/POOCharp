namespace CarrinhoDeCompra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var produto1 = new Produto("Arroz 5kg" , 22.97);
            var produto2 = new Produto("Sal Cristal", 1.98);

            var carrinho = new CarrinhoDeCompra();
            carrinho.AdicionarProduto(produto1);
            carrinho.AdicionarProduto(produto2);

            var precoFinal = carrinho.CalcularProdutos();

            Console.WriteLine("Produtos No Carrinho");
            foreach(var item in carrinho.produtos)
            {
                Console.WriteLine($"{item.Nome} - {item.Preco:F2}");
            }

            Console.WriteLine($"Total da compra :{precoFinal}");


            Console.ReadLine();

        }
    }
}