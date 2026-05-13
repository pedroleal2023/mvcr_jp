namespace program;

public class Program {
 public static void Main (){
 
  int op = 0;

  do { 
      Console.WriteLine("- Ficha de Cadastro de Livros -");
      Console.WriteLine("[1] Para criar um novo cadastro: ");
      Console.WriteLine("[2] Para alterar um cadastro: ");
      Console.WriteLine("[3] Para deletar um cadastro: ");
      Console.WriteLine("[4] Para visualizar um cadastro: ");
      Console.WriteLine("[5] Para encerrar o programa. ");
      
      op = Convert.ToInt32(Console.ReadLine());
      switch (op){
        case 1:
          ViewLivro.Criar();
          break;
        case 2:
          ViewLivro.Alterar();
          break;
        case 3:
          ViewLivro.Deletar();
          break;
        case 4:
          ViewLivro.Listar();
          break;
        case 5:
          Console.WriteLine("¨ENCERRANDO O PROGRAMA¨");
          break;
        default:
            Console.WriteLine("Insira uma Opção Válida.");
           break;          
      }

  } while (op != 5);
 }
}