namespace std;

public class Program
{
    public static void Main()
    {
        ViewPessoa.Sincronizar();
        // precisa manter o estado
        int op = 0;
        do
        {
            Console.WriteLine("Selecione uma operação:");
            Console.WriteLine("[1] - Cadastrar pessoa:");
            Console.WriteLine("[2] - Listar pessoa:");
            Console.WriteLine("[3] - Alterar cadastro:");
            Console.WriteLine("[4] - Deletar cadastro:");
            Console.WriteLine("[5] - Encerrar Programa...");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1 :
                    ViewPessoa.Criar();
                    break;
                case 2 :
                    ViewPessoa.Listar();
                    break;
                case 3 :
                    ViewPessoa.Alterar();
                    break;
                case 4 :
                    ViewPessoa.Deletar();
                    break;
                case 5 :
                    Console.WriteLine("Encerrando programa.");
                    break;
                default :
                    Console.WriteLine("Opção Inválida");
                    break;
            }
            
        } while (op != 5);

    }

}