internal class Program
{
    private static void Main(string[] args)
    {
        // Criar uma variavel
        //Sintexe: Tipo  da variavel nome variavel = valor variavel

        //Tipos de dados Primarios
        /*
        
            int -> Representação de Números Inteiros
        */

        int idade = 21;

        /* double -> Representação de Números Decimais */

        double salario =10352.25;
        float altura = 1.85f;
        decimal peso = 70.50m;

        /* string -> Representação de um texto alphanumerico */

        string nome = "Victor";
        string celular = "141122334455";
        string cpf = "123.456.789-05";

        /* bool -> Representação um Número Booleano (True or False) */

        bool estudante = true;
        bool temLimite = false; 

        /* DateTime -> Representação de data e Hora */
        
        DateTime cadastro = new DateTime(2026,08,04,09,15,32);
        DateOnly nascimento = new DateOnly(2010,01,20);


        /* ***************************************************************************** */
        /* Operadores Matemáticos 
        
            + -> Somar
            - -> Subtrair
            * -> Multiplicar
            / -> Divisão
            % -> Resto da Divisão
            ^ -> Exponenciação 5 ** 3 
            = -> Atrinuição
        
        */

        int n1 = 10;
        int n2 = 3;
        double resultado = 0;

        // Calcular a soma: 
        resultado = n1 + n2;
        Console.WriteLine("A soma dos dois numeros é " + resultado );

        // Calcular a subtracao: 
        resultado = n1 - n2;
        Console.WriteLine("A Subtração dos dois numeros é " + resultado );

        // Calcular a Multiplicação: 
        resultado = n1 * n2;
        Console.WriteLine("A Multiplicação dos dois numeros é " + resultado );

        // Calcular a Divisão: 
        resultado = n1 / n2;
        Console.WriteLine("A Divisão dos dois numeros é " + resultado );

        // Calcular o Resto da Divisão: 
        resultado = n1 % n2;
        Console.WriteLine("O Resto da Divisão dos dois numeros é " + resultado );

        // Calcular a Potência: 
        resultado = n1 ^ n2;
        Console.WriteLine("O numero 1 elevado ao numero 2 é " + resultado );

        /* Operador de Incremento */

        Console.Write("Valor de N1: " + n1);
        n1++; // Aumento o Número atual em + 1 
        Console.Write("Valor de N1: " + n1);

        /* Operador de Incremento */
        n1+=10; // n1 = n1 + 10;
            
        Console.WriteLine("Valor de N1: " + n1);

         /* Operador de Decremento -- */

        Console.Write("Valor de N1: " + n1);
        n1--; // Aumento o Número atual em - 1 
        Console.Write("Valor de N1: " + n1);

        /* Operador de Decremento -= */
        n1-=10; // n1 = n1 - 10;
        Console.WriteLine("Valor de N1: " + n1);

        /******************************************/

        /* Operadores Relacinais -> Realizam Comparações */
        /*  > -> Maior que 
            < -> Menor que
            >= -> Maior ou igual
            <= -> Menor ou igual
            == -> igual
            != -> Diferentes
        
         */
        idade = 19;
        Console.WriteLine("A idade informada é Maior que 18? " + (idade > 18));

        peso = 59;
        Console.WriteLine("O peso informado é menor que 60 kg? " +! (peso <= 60));

        estudante = false;
        Console.WriteLine("O nome informado é de um estudante? " + (estudante == true));


        /***********************************************************************************/

        /* Operadores Logicos -> Permitem combinar duas ou mais condições */


        /* && -> Operador logico "E" */
        /* || -> Operador Lógico "OU" */
        /*  ! -> Operador de Negação. */

        peso = 100 ;

        altura = 170;

        Console.WriteLine("Peso: " + peso + "Altura: " + altura);
        Console.WriteLine((peso <= 100) || (altura > 180)); 


    }

}