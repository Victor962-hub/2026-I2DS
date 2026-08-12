internal class Program
{
    private static void Main(string[] args)
    {
        /* Se (condição) for verdadeiro
                execute essa função
            Senão
                execute essa função

            if(confição)
            {
                codigo se verdadeiro
            }else{
                codigo se falso
            }
        */

        // Verificar se uma idade é maior que 18 anos
        int idade = 16;
        if(idade >= 18)
        {
            Console.WriteLine("Maior de Idade");
        }
        else
        {
            Console.WriteLine("Menor de Idade");
        }

        /****************************************************/

        Console.Write("Digite a nota: ");
        int nota = int.Parse(Console.ReadLine());

        if (nota >= 7)
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
            
        }

        /************************************/

        bool bloqueado = false;

        if (!bloqueado)
        {
            Console.WriteLine("Acesso Permitido");
        }

        /********************************************/

        Console.WriteLine("1 - Cadastrar");
        Console.WriteLine("2 - Consultar");
        Console.WriteLine("3 - Excluir");
        Console.WriteLine("4 - Sair");

        Console.WriteLine("Escolha uma opção");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Console.WriteLine("Cadastro selecionado");
                break;
            case 2:
                Console.WriteLine("Consulte Selecionada");
                break;
            case 3:
                Console.WriteLine("Exclusão selecionada");
                break;
            case 4:
                Console.WriteLine("Encerrando o Sistema");
                break;
            default:
                Console.WriteLine("Opção Inválida.");
                break;
        }
    }
}