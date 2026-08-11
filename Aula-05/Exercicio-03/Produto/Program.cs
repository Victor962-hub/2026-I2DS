internal class Program
{
    private static void Main(string[] args)
    {
        // Primeiro Produto
        Produto produto1 = new Produto();
        produto1.Codigo = 1001;
        produto1.Nome = "Teclado Gamer";
        produto1.Preco = 249.99;
        produto1.Quantidade = 15;

        // Primeiro Produto
        Produto produto2 = new Produto();
        produto2.Codigo = 1010;
        produto2.Nome = "Mouse Gamer";
        produto2.Preco = 169.99;
        produto2.Quantidade = 20;

        // Primeiro Produto
        Produto produto3 = new Produto();
        produto3.Codigo = 0202;
        produto3.Nome = "HeadSet Gamer";
        produto3.Preco = 149.99;
        produto3.Quantidade = 25;

        // Exibindo os produtos 
        Console.WriteLine("\nProduto 1");
        Console.WriteLine($"Código: {produto1.Codigo}");
        Console.WriteLine($"Nome: {produto1.Nome}");
        Console.WriteLine($"Preço: {produto1.Preco:F2}");
        Console.WriteLine($"Quantidade: {produto1.Quantidade}");
        Console.WriteLine($"Valor de Estoque: R$ {produto1.ValorEstoque()}");

        Console.WriteLine("\nProduto 2");
        Console.WriteLine($"Código: {produto2.Codigo}");
        Console.WriteLine($"Nome: {produto2.Nome}");
        Console.WriteLine($"Preço: {produto2.Preco:F2}");
        Console.WriteLine($"Quantidade: {produto2.Quantidade}");
        Console.WriteLine($"Valor de Estoque: R$ {produto2.ValorEstoque()}");

        Console.WriteLine("\nProduto 3");
        Console.WriteLine($"Código: {produto3.Codigo}");
        Console.WriteLine($"Nome: {produto3.Nome}");
        Console.WriteLine($"Preço: {produto3.Preco:F2}");
        Console.WriteLine($"Quantidade: {produto3.Quantidade}");
        Console.WriteLine($"Valor de Estoque: R$ {produto3.ValorEstoque()}");
    }

    public class Produto
    {
        public int Codigo {get; set;}
        public string Nome {get; set;}
        public double Preco {get; set;}
        public int Quantidade {get; set;}

        public double ValorEstoque()
        {
            return Preco * Quantidade; 
        }
    }
}