internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Trabalhando Com Filas (FIFO) ===");

        
        Queue<string> filaLoterica = new Queue<string>();

        
        filaLoterica.Enqueue("Jurema");             
        filaLoterica.Enqueue("Jubiscreuda");        
        filaLoterica.Enqueue("Dom pedro V");        
        filaLoterica.Enqueue("Maria");
        filaLoterica.Enqueue("Joaquina");

        Console.WriteLine();
        foreach (var pessoa in filaLoterica)
        {
            Console.WriteLine(pessoa);
        }

        
        string pessoaRetirada = filaLoterica.Dequeue();
        Console.WriteLine();
        Console.WriteLine($"O Nome chamado foi: {pessoaRetirada}");

        Console.WriteLine();
        foreach (var pessoa in filaLoterica)
        {
            Console.WriteLine(pessoa);
        }

        string pessoaRetirada2 = filaLoterica.Dequeue();
        Console.WriteLine();
        Console.WriteLine($"O Nome chamado foi: {pessoaRetirada2}");

         Console.WriteLine();
        foreach (var pessoa in filaLoterica)
        {
            Console.WriteLine(pessoa);
        }
        Console.WriteLine();
    }
}