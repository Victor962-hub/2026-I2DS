using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        /* 
            Sintaxe:
                Enquanto uma condição for verdadeira

                    execute um conjunto de comndos

            for -> Quando sabemos a quantidade de repetições
            While -> Quando a repetição depende de uma condição.
            do ... while -> Quando precisa executar ao menos uma vez o bloco de codigodw

         */


         /* Laço for: imprimir numeros de 1 até o 10 */

        Console.WriteLine("Imprimir numeros de 1 até 10, utilizando o laço for.");
        for (int numero = 1; numero <= 10; numero++)
        {
            Console.WriteLine(numero);
        }


         /* Laço for: contagem Regressiva de 10 até o 0 */

        Console.WriteLine("Imprimir Contagem Regressiva");
        for (int numero = 10; numero >= 0; numero--)
        {
            Console.WriteLine(numero);
        }

        /****************************************************/

        Console.WriteLine("Imprimir numeros de 1 até 10, utilizando o laço while.");

        int contador = 1;
        while (contador <= 10)
        {
            Console.WriteLine(contador);
            contador++;
        }

        /* Solicitar a senha até acertar */

        string senha = "";

        while(senha != "1234")
        {
            Console.Write ("Digite a Senha: ");

            senha = Console.ReadLine();
              
            
        }

        Console.WriteLine("Acesso Permitido");

        /*****************************************************/
        int num;
        do
        {
        Console.WriteLine("Digite um Número Positivo: ");
        num = int.Parse(Console.ReadLine());  
        }while(num <=0);
    }
    
}