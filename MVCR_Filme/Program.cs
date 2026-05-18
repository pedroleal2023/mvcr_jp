namespace Programa;

public class Program{
  public static void Main() {

    int op = 0;

    do {
      Console.WriteLine("[1] - Para cadastrar o Filme.");
      Console.WriteLine("[2] - Para alterar o cadastro do Filme.");
      Console.WriteLine("[3] - Para deletar o Filme.");
      Console.WriteLine("[4] - Para listar o Filme cadastrado.");
      Console.WriteLine("[5] - Para sair/encerrar o programa.");
      op = Convert.ToInt32(Console.ReadLine());

      switch(op){
        case 1:
          ViewFilme.Criar();
          break;
        case 2:
          ViewFilme.Alterar();
          break;
        case 3:
          ViewFilme.Deletar();
          break;
        case 4:
          ViewFilme.Listar();
          break;
        case 5:
          Console.WriteLine("Encerrando o programa.");
          break;
        default:
          Console.WriteLine("Digite uma opção válida.");
          break;
      }

    } while (op != 5);
  }
}
