internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Trabalhando com Dicionarios ===");
        // Sintexe Dictonary<chave, valor>
        Dictionary<string, string> dicionario = new Dictionary<string, string>();

        // 2 - Adicionar elementos no dicionario
        dicionario.Add("Hamburguer","Lanche feito tradicionalmente de pão e carne");
        dicionario.Add("Fernandão","O Melhor professor do Senai");
        dicionario.Add("Iscola","Local em que os alunos estão cedentos em conhecimento");
        dicionario.Add("Amizade","Uma Relação entre duas pessoas, que aproxima elas.");

        // 3 - Percorrer todos os elementos de um dicionario
        Console.WriteLine();
        foreach (var palavra in dicionario)
        {
            Console.WriteLine($"{palavra.Key} - {palavra.Value}");
        }

        // 4 - Alterar um elemento do dicionario
        dicionario["Fernandão"] = "O melhor professor do Senai";
        Console.WriteLine();
        foreach (var palavra in dicionario)
        {
            Console.WriteLine($"{palavra.Key} - {palavra.Value}");
        }

        // 5 - Verificar se uma chave (key) existe dentro do dicionario
        string termo;
        bool chaveExiste = dicionario.TryGetValue("Amizade", out termo);
        if (chaveExiste)
        {
            Console.WriteLine($"A palavra foi encontrada: {termo}");
        }
        else
        {
            Console.WriteLine($"A palavra não foi encontrada no dicionário");
        }

        // 6 - Excluir um elemento do dicionario
        dicionario.Remove("Casa");
        Console.WriteLine();
        foreach (var palavra in dicionario)
        {
            Console.WriteLine($"{palavra.Key} - {palavra.Value}");
        }

        // 7 - Ordenar um Dicionario por chave
        var DicionarioOrdenado = dicionario.OrderBy(i => i.Key);
        Console.WriteLine();
        foreach (var palavra in DicionarioOrdenado)
        {
            Console.WriteLine($"{palavra.Key} - {palavra.Value}");
        }



    }
}