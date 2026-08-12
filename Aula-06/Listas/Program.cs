internal class Program
{
    public class Aluno
    {
        public int Id {get; set;}
        public string? Nome {get; set; }
        public string? Matricula {get; set; }
    }


    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM LISTAS ===");

        // 1 - Iniciar uma nova lista

        List<Aluno> listaAlunos = new List<Aluno>();

        Aluno aluno1 = new Aluno{Id = 1, Nome = "Senninha", Matricula = "12345"};

        Aluno aluno2 = new Aluno{Id = 2, Nome = "Jubiscreuda", Matricula = "54321"};

        Aluno aluno3 = new Aluno{Id = 3, Nome = "Valderlei", Matricula = "89464"};

        // 2 - Incluir Elementos na Lista 

        listaAlunos.Add(aluno1);

        listaAlunos.Add(aluno2);

        listaAlunos.Add(aluno3);

        // 3 - Percorrer todos os elementos da lista

        foreach (var item in listaAlunos)
        {
            Console.WriteLine($"{item.Nome} - {item.Matricula}");
        }

        // 4 - Alterar um elemento da lista
        listaAlunos[1].Matricula = "55555";
        listaAlunos[2].Nome = "Eleutério";
        Console.WriteLine();

        foreach (var aluno in listaAlunos)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Matricula}");
        }

        // 5 - Excluir um elemento da lista por indice
        listaAlunos.RemoveAt(0);
        Console.WriteLine();
        foreach (var aluno in listaAlunos)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Matricula}");
        }

        // 6 - Remover um elemento da lista por objeto
        listaAlunos.Remove(aluno3);
        Console.WriteLine();
        foreach (var aluno in listaAlunos)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Matricula}");
        }

        // 7 - Quantidade de elementos da lista
        Console.WriteLine();
        Console.WriteLine($"Quantidade de Elementos na lista {listaAlunos.Count()}");
        
        // 8 - Remover todos os elementos da lista
        listaAlunos.Clear();

        
    
        




    }
}