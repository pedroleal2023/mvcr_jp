namespace std;

public class Program {
  public static void Main () {

    int op = 0;

    do{
       Console.WriteLine("Selecione uma operação:");
       Console.WriteLine("1 - Criar Item");
       Console.WriteLine("2 - Listar Itens");
       Console.WriteLine("3 - Alterar Item");
       Console.WriteLine("4 - Deletar Item");
       Console.WriteLine("5 - Encerrar Programa");
        op = Int.Parse(Console.ReadLine());

        switch(op) {
          case 1:
            ViewPessoa.Criar();
            break;
          case 2:
            ViewPessoa.Listar();
            break;
          case 3:
            ViewPessoa.Alterar();
            break;
          case 4:
            ViewPessoa.Deletar();
            break;
          case 5:
            Console.WriteLine("Encerrando o programa...");
            break;
          default:
            Console.WriteLine("Digite uma opção válida.");  
              
        }
    } while (op != 6);
  }
}
