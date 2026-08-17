using System;
using System.Collections.Generic;
using System.Linq;

class Funcionario
{
    public int Matricula { get; set; }
    public string Nome { get; set; }
    public double Salario { get; set; }

    public Funcionario(int matricula, string nome, double salario)
    {
        Matricula = matricula;
        Nome = nome;
        Salario = salario;
    }
}

class Program
{
    static void Main()
    {
        Dictionary<int, Funcionario> funcionarios = new Dictionary<int, Funcionario>()
        {
            { 1, new Funcionario(101, "Ana", 3500.00) },
            { 2, new Funcionario(102, "Bruno", 2200.50) },
            { 3, new Funcionario(103, "Carla", 5000.00) },
            { 4, new Funcionario(104, "Daniel", 1900.00) },
            { 5, new Funcionario(105, "Eliana", 4100.00) }
        };

        var ordenados = funcionarios.Values.OrderBy(f => f.Salario);

        Console.WriteLine("Funcionários ordenados por salário (crescente):");
        foreach (var func in ordenados)
        {
            Console.WriteLine($"Matrícula: {func.Matricula} | Nome: {func.Nome} | Salário: R$ {func.Salario:F2}");
        }
    }
}
