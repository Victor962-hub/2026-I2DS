internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Fila de Espera ===");

        Queue<string> filaLoterica = new Queue<string>();

        filaLoterica.Enqueue("João");             
        filaLoterica.Enqueue("Maria");        
        filaLoterica.Enqueue("Carlos");        
        filaLoterica.Enqueue("Ana");
        filaLoterica.Enqueue("Pedro");

        Console.WriteLine();
        foreach (var pessoa in filaLoterica)
        {
            Console.WriteLine(pessoa);
        }

        string pessoaRetirada = filaLoterica.Dequeue();
        Console.WriteLine();
        Console.WriteLine($"O Nome chamado foi: {pessoaRetirada}");

        filaLoterica.Enqueue("Fernandão");

        Console.WriteLine();
        foreach (var pessoa in filaLoterica)
        {
            Console.WriteLine(pessoa);
        }

        Console.WriteLine();

    }
}