internal class Program
{
    private static void Main(string[] args)
    {
        // Primeiro Aluno
        Aluno aluno01 = new Aluno();
        aluno01.RM = 4205;
        aluno01.Nome = "Lúcio Nascimento";
        aluno01.Nascimento = new DateOnly (1969,09,05);
        aluno01.Email = "LucioPanagare@gmail.com";

        // Segundo Aluno
        Aluno aluno02 = new Aluno();
        aluno02.RM = 5674;
        aluno02.Nome = "Glauber Jacinto";
        aluno02.Nascimento = new DateOnly (2000,05,14);
        aluno02.Email = "Jacinto@gmail.com";

        // terceiro Aluno
        Aluno aluno03 = new Aluno();
        aluno03.RM = 3267;
        aluno03.Nome = "Henzo Hernadez";
        aluno03.Nascimento = new DateOnly (2014,11,15);
        aluno03.Email = "HenzinDelas@gmail.com";

        // Exibindo os livros na Tela

        Console.WriteLine("==== ALUNOS ====");
        Console.WriteLine($"\nAluno 01: {aluno01.Nome} | Email: {aluno01.Email}");
        Console.WriteLine($"\nAluno 02: {aluno02.Nome} | Email: {aluno02.Email}");
        Console.WriteLine($"\nAluno 03: {aluno03.Nome} | Email: {aluno03.Email}");
    }

    public class Aluno
    {
        public int RM {get; set;}
        public string Nome {get; set;}
        public DateOnly Nascimento {get; set;}
        public string Email {get; set;}

    }
}