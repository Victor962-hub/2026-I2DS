internal class Program
{

    public class Aluno
    {
        public string Nome {get; set; }
        public int Idade {get; set; }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Trabalhando com Listas ===");

        List<Aluno> listaAluno = new List<Aluno>();

        Aluno aluno1 = new Aluno{Idade = 15, Nome = "Senninha" };

        Aluno aluno2 = new Aluno{Idade = 13, Nome = "Jubiscreuda" };

        Aluno aluno3 = new Aluno{Idade = 14, Nome = "Valderlei" };

        Aluno aluno4 = new Aluno{Idade = 16, Nome = "Sibele" };

        Aluno aluno5 = new Aluno{Idade = 17, Nome = "Henzo" };

        listaAluno.Add(aluno1);

        listaAluno.Add(aluno2);

        listaAluno.Add(aluno3);

        listaAluno.Add(aluno4);

        listaAluno.Add(aluno5);


        foreach (var item in listaAluno)
        {
            Console.WriteLine($"{item.Nome} - {item.Idade}");
        }

        Console.WriteLine();

        listaAluno[3].Idade = 15;

        foreach (var item in listaAluno)
        {
            Console.WriteLine($"{item.Nome} - {item.Idade}");
        }

        listaAluno.Remove(aluno3);
        Console.WriteLine();
        foreach (var aluno in listaAluno)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Idade}");
        }

    }
}