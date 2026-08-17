internal class Program
{

    public class Numero
    {
        public int Numeros {get; set; }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Trabalhando com Listas ===");
        


        List<Numero> listaNumeros = new List<Numero>();

        Numero numero1 = new Numero{Numeros = 10 };

        Numero numero2 = new Numero{Numeros = 25 };

        Numero numero3 = new Numero{Numeros = 8 };

        Numero numero4 = new Numero{Numeros = 42 };

        Numero numero5 = new Numero{Numeros = 15 };
        
        Numero numero6 = new Numero{Numeros = 30 }; 
        


        listaNumeros.Add(numero1);

        listaNumeros.Add(numero2);

        listaNumeros.Add(numero3);

        listaNumeros.Add(numero4);

        listaNumeros.Add(numero5);

        listaNumeros.Add(numero6);
        


        Console.WriteLine();

        foreach (var item in listaNumeros)
        {
            Console.WriteLine($"{item.Numeros} ");
        }
        Console.WriteLine();

        Console.WriteLine("Segundo Número Alterado Com Sucesso!");

        listaNumeros[1].Numeros = 100;
        Console.WriteLine();


        foreach (var item in listaNumeros)
        {
            Console.WriteLine($"{item.Numeros} ");
        }
        Console.WriteLine();
        


        listaNumeros.RemoveAt(5);
       

        
        Console.WriteLine("Quinto Número Retirado!");
        Console.WriteLine();
        foreach (var item in listaNumeros)
        {
            Console.WriteLine($"{item.Numeros} ");
        }
        Console.WriteLine();



    }
}