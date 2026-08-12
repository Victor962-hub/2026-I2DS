internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Trabalhando Com Pilhas (FILO) ===");

        // 1 - Criar uma nova pilha vazia
        Stack<string> pilhaLivros = new Stack<string>();

        // 2 - Adicionar elemento em uma pilha

        pilhaLivros.Push("Biblia Sagrada");
        pilhaLivros.Push("Diário de um Banana");
        pilhaLivros.Push("Você Sabia");

        // 3 - Percorrer todos os elementos de uma pilha
        Console.WriteLine();
        foreach(var item in pilhaLivros)
        {
            Console.WriteLine(item);
        }

        // 4 - Remover um elemento da pilha

        string livroRemovido = pilhaLivros.Pop();
        Console.WriteLine();
        Console.WriteLine($"O livro retirado foi: {livroRemovido}");

        pilhaLivros.Push("Dom casmurro");
        Console.WriteLine();
        foreach(var livro in pilhaLivros)
        {
            Console.WriteLine(livro);
        }



    }
}