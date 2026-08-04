internal class Program
{
    private static void Main(string[] args)
    {
        Ola("Victor");
        Ola("Vinicius");
        Ola("Valentina");

        Console.WriteLine("A soma de 5 e 3 é: " + Calcular(5,3,"+"));
        Console.WriteLine("A subtração de 5 e 3 é: " + Calcular(5,3,"-"));
        Console.WriteLine("A Multiplicação de 5 e 3 é: " + Calcular(5,3,"*"));
    }
    // public static void Ola()
    // {
    //     Console.WriteLine("Olá, seja bem-vendo!");
    // }


    // Função com parametro nome e sem retorno
    public static void Ola(string nome)
    {
        Console.WriteLine("Olá " + nome + ", seja bem-vindo(a)!"); 
    }

    public static double Calcular(double num1, double num2, string operador)
    {
        
        double resultado = 0; 

        switch (operador)
        {
            case "+":
                resultado = num1 + num2;
                break;

            case "-":
                resultado = num1 - num2;
                break;

            case "*":
                resultado = num1 * num2;
                break;

            case "/":
                resultado = num1 / num2;
                break;
            default:
                Console.WriteLine("Operador informado não é válido.");
                break;
        }
        return resultado;
    }
}