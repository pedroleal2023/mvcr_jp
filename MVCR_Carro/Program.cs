namespace program;

public class Program {

  public static void Main(){

    int op = 0;

    do {
      Console.WriteLine("Acessando o programa!");
      Console.WriteLine("[1] Para cadastrar o carro: ");
      Console.WriteLine("[2] Para alterar os dados: ");
      Console.WriteLine("[3] Para deletar o cadastro: ");
      Console.WriteLine("[4] Para listar o carro: ");
      Console.WriteLine("[5] Para sair/encerrar o programa.");

        op = Convert.ToInt32(Console.ReadLine());
        switch (op) {
          case 1:
           ViewCarro.Criar();             
             break;
          case 2:
           ViewCarro.Alterar();
             break;
          case 3:
           ViewCarro.Deletar();
             break;
          case 4:
           ViewCarro.Listar();
             break;
          case 5:
           Console.WriteLine("- ENCERRANDO O PROGRAMA - ");
             break;
          default:
            Console.WriteLine("Opção Inválida.");
             break;     
        } 
    } while (op != 5);
  }
}