internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Trabalhando Com Filas (FIFO) ===");

        // 1 - Criar uma nova fila vazia
        Queue<string> filaLoterica = new Queue<string>();

        // 2 - Adicionar elementos na fila
        filaLoterica.Enqueue("Jurema");             // 0
        filaLoterica.Enqueue("Jubescreuda");        // 1
        filaLoterica.Enqueue("Dom pedro I");        // 2
        filaLoterica.Enqueue("Joaquim");            // 3

        // 3 - Percorrer elementos de uma fila
        Console.WriteLine();
        foreach (var pessoa in filaLoterica)
        {
            Console.WriteLine(pessoa);
        }

        // 4 - Remover elementos de uma fila
    
        string pessoaRetirada = filaLoterica.Dequeue();
        Console.WriteLine();
        Console.WriteLine($"O Nome chamado foi: {pessoaRetirada}");

        filaLoterica.Enqueue("Fernandão");

        Console.WriteLine();
        foreach (var pessoa in filaLoterica)
        {
            Console.WriteLine(pessoa);
        }
        
        // 5 - Verificar se existe um determinado elemento na lista
        string procurar = "Fernandão";
        bool achou = filaLoterica.Contains(procurar);
        Console.WriteLine();
        if (achou)
        {
            Console.WriteLine($"{procurar} está na fila!");
        }
        else
        {
            Console.WriteLine($"{procurar} NÃO está na fila!");
            
        }

    }
}