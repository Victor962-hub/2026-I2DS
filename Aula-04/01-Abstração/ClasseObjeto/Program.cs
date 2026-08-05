internal class Program
{
    private static void Main(string[] args)
    {
        /*
            Classe -> é a abstração de um objeto do mundo 
            real para o mundo computacional.
            Objeto -> É a instância de uma classe.
        */

        // Instanciar um objeto do Tipo Aluno 
        Aluno aluno01 = new Aluno();
        Aluno aluno02 = new Aluno();
        
        // Atribuir Valores
        aluno01.Nome = "Joaquim";
        aluno01.RM = 2441;
        aluno01.DataNascimento = new DateOnly(2010,01,21);

        aluno02.Nome = "Ronaldo Nazario";
        aluno02.RM = 2002;
        aluno02.DataNascimento = new DateOnly(1973,02,09);


        //Executar os Métodos
        aluno01.ApresentarSe();
        aluno02.ApresentarSe();
    }

    public class Aluno // Declaração de uma classe
    {
        // Atributos -> Caracteristicas
        public string Nome {get; set; }
        public int RM {get; set; }
        public DateOnly DataNascimento {get; set; }

        // Métodos -> ou Funcionalidades
        public void ApresentarSe()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, meu RM é {RM}, nasci na data {DataNascimento}.");
        }
    }
}