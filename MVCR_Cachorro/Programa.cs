namespace program;

public class Programa {

  public static void Main (){

      int op = 0;

      do {
          Console.WriteLine("- Ficha de Cadastro do seu PET -");
          Console.WriteLine("- Digite [1] para cadastrar seu cão -");
          Console.WriteLine("- Digite [2] para alterar os dados do seu cão -");
          Console.WriteLine("- Digite [3] para deletar os dados do seu cão -");
          Console.WriteLine("- Digite [4] para listar o cão desejado -");
          Console.WriteLine("- Digite [5] para sair do programa -");

           op = Convert.ToInt32(Console.ReadLine()); 

          switch (op) {
              case 1:
              CachorroView.Criar();
                break;
              case 2:
              CachorroView.Alterar();
                break;
              case 3:
              CachorroView.Deletar();
                break;
              case 4:
              CachorroView.Listar();
                break;
              case 5:
              Console.WriteLine("Encerrando o programa.");
                break;
              default:
              Console.WriteLine("opção inválida.");
                break;    
          }
            
      } while (op != 5);

  }
}