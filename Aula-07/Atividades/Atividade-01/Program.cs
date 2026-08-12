internal class Program
{

    public class frutas
    {
        public int Id {get; set;}
        public string? Nome {get; set; }
        
        
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Lista de Frutas ===");

        List<frutas> listaFrutas = new List<frutas>();
        frutas fruta1 = new frutas{Id = 1, Nome = "Laranja"};

        frutas fruta2 = new frutas{Id = 2, Nome = "Pera"};

        frutas fruta3 = new frutas{Id = 3, Nome = "Maça"};

        frutas fruta4 = new frutas{Id = 4, Nome = "Banana"};

        frutas fruta5 = new frutas{Id = 5, Nome = "Tomate"};

        frutas fruta6 = new frutas{Id = 6, Nome = "Caqui"};


        

        listaFrutas.Add(fruta1);

        listaFrutas.Add(fruta2);

        listaFrutas.Add(fruta3);

        listaFrutas.Add(fruta4);

        listaFrutas.Add(fruta5);

        foreach (var fruta in listaFrutas)
        {
            Console.WriteLine($"{fruta.Nome}");
        }

        
        listaFrutas[1].Nome = "Romã";
        Console.WriteLine();

        foreach (var fruta in listaFrutas)
        {
            Console.WriteLine($"{fruta.Nome}");
        }
        Console.WriteLine();
        Console.WriteLine("=== Nova fruta Adicionada ===");

        Console.WriteLine();

        listaFrutas.Add(fruta6);
        foreach (var fruta in listaFrutas)
        {
            Console.WriteLine($"{fruta.Nome}");

        }
        Console.WriteLine();


    }
}