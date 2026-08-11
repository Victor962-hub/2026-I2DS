internal class Program
{
    private static void Main(string[] args)
    {
        // Primeiro Livro
        Livro livro1 = new Livro();
        livro1.Titulo = "Biblia";
        livro1.Autor = "Velho Testamento";
        livro1.Editora = "Deus";
        livro1.AnoLancamento = 2000 ;

        // Segundo Livro
        Livro livro2 = new Livro();
        livro2.Titulo = "Diario de um Banana";
        livro2.Autor = "Jeff Kinney";
        livro2.Editora = "Jeff Kinney";
        livro2.AnoLancamento = 2007 ;

        // Terceiro Livro
        Livro livro3 = new Livro();
        livro3.Titulo = "Você Sabia";
        livro3.Autor = "Daniel Molo";
        livro3.Editora = "Lukas Marques";
        livro3.AnoLancamento = 2018 ;

        // Exibindo os livros na Tela

        Console.WriteLine("==== LIVROS ====");
        Console.WriteLine($"\nLivro 01: {livro1.Titulo} | Autor: {livro1.Autor}");
        Console.WriteLine($"\nLivro 02: {livro2.Titulo} | Autor: {livro2.Autor}");
        Console.WriteLine($"\nLivro 03: {livro3.Titulo} | Autor: {livro3.Autor}");
    }

    public class Livro
    {
        public string Titulo {get; set;}
        public string Autor {get; set;}
        public string Editora {get; set;}
        public int AnoLancamento {get; set;}
    }
}