internal class Program
{

    public class Cidade
    {
        public String Nome {get; set; }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Trabalhando Com Listas ===");

        List<Cidade> listaCidades = new List<Cidade>();

        Cidade cidade1 = new Cidade{Nome = "Brotas" };

        Cidade cidade2 = new Cidade{Nome = "Itapuí" };

        Cidade cidade3 = new Cidade{Nome = "Jaú" };

        Cidade cidade4 = new Cidade{Nome = "Mineiros do Tietê" };

        Cidade cidade5 = new Cidade{Nome = "Bauru" };

        listaCidades.Add(cidade1);

        listaCidades.Add(cidade2);

        listaCidades.Add(cidade3);

        listaCidades.Add(cidade4);

        listaCidades.Add(cidade5);

        foreach (var item in listaCidades)
        {
            Console.WriteLine($"{item.Nome} ");
        }

    }
}