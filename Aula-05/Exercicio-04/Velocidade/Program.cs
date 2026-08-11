internal class Program
{
    private static void Main(string[] args)
    {
        // Primeiro Carro
        Carro carro1 = new Carro();
        carro1.Marca = "Honda";
        carro1.Modelo = "G8";
        carro1.Velocidade = 215;

        // Primeiro Carro
        Carro carro2 = new Carro();
        carro2.Marca = "Honda";
        carro2.Modelo = "G10";
        carro2.Velocidade = 238;

        // Primeiro Carro
        Carro carro3 = new Carro();
        carro3.Marca = "Ford";
        carro3.Modelo = "Mustang GT";
        carro3.Velocidade = 250;

        // Exibindo as Informações dos Carros
        Console.WriteLine("\n = Carro 1 = " );
        Console.WriteLine($"Marca: {carro1.Marca}");
        Console.WriteLine($"Modelo: {carro1.Modelo}");
        Console.WriteLine($"Velocidade: {carro1.Velocidade}  Km/h  "); 
        Console.WriteLine($"Acelerar: {carro1.Acelerar()} Km/h "); 
        Console.WriteLine($"Desalerar: {carro1.Desacelerar()} Km/h ");

        Console.WriteLine("\n = Carro 2 = " );
        Console.WriteLine($"Marca: {carro2.Marca}");
        Console.WriteLine($"Modelo: {carro2.Modelo}");
        Console.WriteLine($"Velocidade: {carro2.Velocidade}  Km/h  "); 
        Console.WriteLine($"Acelerar: {carro2.Acelerar()} Km/h "); 
        Console.WriteLine($"Desalerar: {carro2.Desacelerar()} Km/h ");

        Console.WriteLine("\n = Carro 3 = " );
        Console.WriteLine($"Marca: {carro3.Marca}");
        Console.WriteLine($"Modelo: {carro3.Modelo}");
        Console.WriteLine($"Velocidade: {carro3.Velocidade}  Km/h  "); 
        Console.WriteLine($"Acelerar: {carro3.Acelerar()} Km/h ");  
        Console.WriteLine($"Desalerar: {carro3.Desacelerar()} Km/h ");

    }

    public class Carro
    {
        public string Marca {get; set;}
        public string Modelo {get; set;}
        public int Velocidade {get; set;}
    
        public int Acelerar()
        {
            return Velocidade + 10;
        }

        public int Desacelerar()
        {
            return Velocidade - 10;
        }
    }

}