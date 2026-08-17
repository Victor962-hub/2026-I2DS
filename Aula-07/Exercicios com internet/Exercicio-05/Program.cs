internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Trabalhando com Pilhas ===");
        Stack<string> pilhaAcoes = new Stack<string>();

        pilhaAcoes.Push("Digitar");
        pilhaAcoes.Push("Apagar");
        pilhaAcoes.Push("Negrito");
        pilhaAcoes.Push("Colar");
        
        Console.WriteLine();
        foreach(var item in pilhaAcoes)
        {
            Console.WriteLine(item);
        }

        string AcaoRemovida = pilhaAcoes.Pop();
        Console.WriteLine();
        Console.WriteLine($"A Ação Removida foi: {AcaoRemovida}");

        
        Console.WriteLine();
        foreach(var item in pilhaAcoes)
        {
            Console.WriteLine(item);
        }

        string AcaoRemovida2 = pilhaAcoes.Pop();
        Console.WriteLine();
        Console.WriteLine($"A Ação Removida foi: {AcaoRemovida2}");

        Console.WriteLine();
        foreach(var item in pilhaAcoes)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();



    }
}