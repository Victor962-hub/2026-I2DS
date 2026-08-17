internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Tranbalhando Com Lambda ===");
    
        // 1. Criação da expressão lambda para multiplicação
        Func<int, int, int> multiplicar = (x, y) => x * y;

        
        int resultado1 = multiplicar(5, 4);
        int resultado2 = multiplicar(7, 3);
        int resultado3 = multiplicar(10, 12);

        
        Console.WriteLine($"Teste 1: 5 * 4 = {resultado1}");
        Console.WriteLine($"Teste 2: 7 * 3 = {resultado2}");
        Console.WriteLine($"Teste 3: 10 * 12 = {resultado3}");
    


    }
}