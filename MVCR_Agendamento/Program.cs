namespace Programa;

public class Program {
  public static void Main(){

    int op = 0;

    do {
      Console.WriteLine("[1] - Para cadastrar um novo agendamento.");
      Console.WriteLine("[2] - Para alterar um novo agendamento.");
      Console.WriteLine("[3] - Para deletar um agendamento.");
      Console.WriteLine("[4] - Para listar um agendamento.");
      Console.WriteLine("[5] - Para sair/encerrar o programa.");
      op = Convert.ToInt32(Console.ReadLine());

      switch (op) {
        case 1:
          ViewArg.Criar();
           break;
        case 2:
          ViewArg.Alterar();
           break;
        case 3:
          ViewArg.Deletar();
           break;
        case 4:
          ViewArg.Listar();
           break;
        case 5:
          Console.WriteLine("Encerrando o Programa...");
           break;
        default:
          Console.WriteLine("Digite uma opção Válida.");
           break;
                                  
      }
    } while (op != 5); 
  }
}