using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        // Primeiro Funcionario
        Funcionario funcionario1 = new Funcionario();
        funcionario1.Nome = "Raimundo Nascimento";
        funcionario1.IdadeAtual = 42;
        funcionario1.Salario = 2750.00;
        funcionario1.Resgistro = 225;

        // Primeiro Funcionario
        Funcionario funcionario2 = new Funcionario();
        funcionario2.Nome = "Maria Joaquina";
        funcionario2.IdadeAtual = 35;
        funcionario2.Salario = 4000.00;
        funcionario2.Resgistro = 505;

        // Primeiro Funcionario
        Funcionario funcionario3 = new Funcionario();
        funcionario3.Nome = "Valderlan Rodriguez";
        funcionario3.IdadeAtual = 37;
        funcionario3.Salario = 4750.00;
        funcionario3.Resgistro = 462;

        //Exibindo Funcionarios
        Console.WriteLine("=== FUNCIONÁRIOS ===");

        Console.WriteLine("\nFuncionário 1");
        Console.WriteLine($"Nome: {funcionario1.Nome}");
        Console.WriteLine($"Idade: {funcionario1.IdadeAtual}");
        Console.WriteLine($"Salário: R$ {funcionario1.Salario}F2");
        Console.WriteLine($"Resgistro: {funcionario1.Resgistro}");

        Console.WriteLine("\nFuncionário 2");
        Console.WriteLine($"Nome: {funcionario2.Nome}");
        Console.WriteLine($"Idade: {funcionario2.IdadeAtual}");
        Console.WriteLine($"Salário: R$ {funcionario2.Salario}F2");
        Console.WriteLine($"Resgistro: {funcionario2.Resgistro}");

        Console.WriteLine("\nFuncionário 3");
        Console.WriteLine($"Nome: {funcionario3.Nome}");
        Console.WriteLine($"Idade: {funcionario3.IdadeAtual}");
        Console.WriteLine($"Salário: R$ {funcionario3.Salario}F2");
        Console.WriteLine($"Resgistro: {funcionario3.Resgistro}");

        // Envelhecendo os Funcionários 
        funcionario1.Envelhecer(13);
        funcionario2.Envelhecer(12);
        funcionario3.Envelhecer(11);

        //Exibindo a Idade Novas

        Console.WriteLine("\n === Após Envelhecer  ===");

        Console.WriteLine($"{funcionario1.Nome}: {funcionario1.IdadeAtual} anos");
        Console.WriteLine($"{funcionario2.Nome}: {funcionario2.IdadeAtual} anos");
        Console.WriteLine($"{funcionario3.Nome}: {funcionario3.IdadeAtual} anos");
    }

    public class Pessoa
    {
        public string Nome {get; set; }
        public int IdadeAtual {get; set;}

        public void Envelhecer(int anos)
        {
            IdadeAtual += anos; // IdadeAtual = IdadeAtual + anos
        }
    }

    public class Funcionario : Pessoa
    {
        public double Salario {get; set; }
        public int Resgistro {get; set; }
    }
}