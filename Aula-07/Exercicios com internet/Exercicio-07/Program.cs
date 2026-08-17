internal class Program
{

     public class Produtos
    {
        public string? Nome {get; set; }
        public double Preco {get; set; }
        public int Id {get; set; }
         
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Trabalhando Com LINQS ===");

        Produtos produto1 = new Produtos
        {
            Nome = "Fardo de Brahma",
            Preco = 59.99,
            Id = 1234,
        };

        Produtos produto2 = new Produtos
        {
            Nome = "Bolo de Cenora C/ Chocolate",
            Preco = 69.89,
            Id = 4321

        };

        Produtos produto3 = new Produtos
        {
            Nome = "Cadeira de Praia",
            Preco = 45.99,
            Id = 5678

        };

        Produtos produto4 = new Produtos
        {
            Nome = "Caixa Térmica",
            Preco = 49.99,
            Id = 8765

        };

        Produtos produto5 = new Produtos
        {
            Nome = "Fardo de LN Heineken",
            Preco = 34.99,
            Id = 0169

        };

        List<Produtos> listaProdutos = new List<Produtos>();
        listaProdutos.Add(produto1);
        listaProdutos.Add(produto2);
        listaProdutos.Add(produto3);
        listaProdutos.Add(produto4);
        listaProdutos.Add(produto5);

        Console.WriteLine("\n=== LISTA DE COLABORADORES ===");
        ImprimirLista(listaProdutos);

        


        Console.WriteLine("\n=== LISTA DE PREÇOS MAIORES DO QUE R$ 50,00 ===");
        var listaValorAlto = listaProdutos
        .Where(colab => colab.Preco >= 50.00)
        
        .OrderBy(colab => colab.Preco)
        .ToList();
        
        ImprimirLista(listaValorAlto);
        }

        public static void ImprimirLista(List<Produtos> lista)
    {
        Console.WriteLine();
        foreach (var produto in lista)
        {
            Console.WriteLine($"Nome: {produto.Nome} - Preço R$: {produto.Preco:F2}");
        }
        Console.WriteLine();
    }
    

}