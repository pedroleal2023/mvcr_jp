namespace Programa;

public class Program{

  public static void Main (){

    int op = 0;

    do {

      Console.WriteLine("[1] Para criar sua conta:");
      Console.WriteLine("[2] Para alterar sua conta:");
      Console.WriteLine("[3] Para deletar sua conta:");
      Console.WriteLine("[4] Para listar a conta:");
      Console.WriteLine("[5] Para sair/encerrar o programa:");
      op = Convert.ToInt32(Console.ReadLine());  

      switch(op) {
        case 1:
          ViewConta.Criar();
          break;
        case 2:
          ViewConta.Alterar();
          break;
        case 3:
          ViewConta.Deletar();
          break;
        case 4:
          ViewConta.Listar();
          break;
        case 5:
          Console.WriteLine("- Encerrando o programa -");
          break;
        default:
          Console.WriteLine("Digite uma opçã válida.");
          break;          
      }
    } while (op != 5);
  }
}