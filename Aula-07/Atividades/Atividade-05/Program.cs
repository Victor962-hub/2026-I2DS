internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Trabalhando com Histórico ===");

        Stack<string> Historico = new Stack<string>();

        Historico.Push("google.com");
        Historico.Push("youtube.com");
        Historico.Push("github.com");
        Historico.Push("microsoft.com");
    }
}