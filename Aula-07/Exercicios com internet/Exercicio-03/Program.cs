internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Trabalhando Com Cardapio ===");

        Dictionary<int, string> Cardapio = new Dictionary<int, string>();

        Cardapio.Add(12345,"X-Bacon");
        Cardapio.Add(54321,"X-Ratão");
        Cardapio.Add(56789,"X-Tudo");
        Cardapio.Add(98765,"X-Salada");

         Console.WriteLine();
        foreach (var palavra in Cardapio)
        {
            Console.WriteLine($"{palavra.Key} - {palavra.Value}");
        }
        Console.WriteLine();

    }
}