internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Trabalhando com Contatos ===");
        Dictionary<string, string> contatos = new Dictionary<string, string>();

        contatos.Add("Lukas","(14)99892-7564");
        contatos.Add("Felipe","(14)99063-7244");
        contatos.Add("Bombeiros","(11)97541-1243");
        contatos.Add("Juju Doces","(15)91541-0357.");
        contatos.Add("Polícia","(31)98310-1309.");

        Console.WriteLine();
        foreach (var numero in contatos)
        {
            Console.WriteLine($"{numero.Key} - {numero.Value}");
        }

        Console.WriteLine();

        bool chaveExiste = contatos.ContainsKey("Juju Doces");
        if (chaveExiste)
        {
            Console.WriteLine($"A Juju Doces foi encontrada ");
        }
        else
        {
            Console.WriteLine($"Esse contato não foi encontrado(a)");
        }

        Console.WriteLine();

        Console.WriteLine("=== Alterando Número da Polícia ===");
        contatos["Polícia"] = "190";
        Console.WriteLine();
        foreach (var palavra in contatos)
        {
            Console.WriteLine($"{palavra.Key} - {palavra.Value}");
        }

        Console.WriteLine();

        Console.WriteLine("=== Removendo Felipe ===");
        contatos.Remove("Felipe");
        Console.WriteLine();
        foreach (var palavra in contatos)
        {
            Console.WriteLine($"{palavra.Key} - {palavra.Value}");
        }

        Console.WriteLine();

        

    }
}