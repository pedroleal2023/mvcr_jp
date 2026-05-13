namespace programa;

  public class Program{
    public static void Main (){

      int op = 0;

      do {
        Console.WriteLine("[1] - para criar");
        Console.WriteLine("[2] - para alterar");
        Console.WriteLine("[3] - para deletar");
        Console.WriteLine("[4] - para listar");
        Console.WriteLine("[5] - para sair/encerrar o programa");

        op= Convert.ToInt32(Console.ReadLine());

        switch(op) {
            case 1:
                ViewPessoa.Criar();
                break;
            case 2:
                ViewPessoa.Alterar();
                break;
            case 3:
                ViewPessoa.Deletar();
                break;
            case 4:
                ViewPessoa.Listar();
                break;
            case 5:
            Console.WriteLine("Encerrando o programa.");
                break;
            default:
            Console.WriteLine("Opção inválida. ");
                break;
        }
      } while (op != 5);
    }
  }
