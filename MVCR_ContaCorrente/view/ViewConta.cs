namespace Programa;

public class ViewConta{

  public static void Criar () {
    Console.WriteLine("- Criando sua Conta Corrente -");
    Console.WriteLine("Insira seu nome completo: ");
    string nome = Console.ReadLine()?? "";
    Console.WriteLine("Insira seu CPF (Neste Formato - 111.111.111-11): ");
    string cpf = Console.ReadLine();
    
    ControllerConta.Criar(nome, cpf);
  }

  public static void Alterar () {
    Console.WriteLine("- Alterando sua Conta Corrente -");
    Console.WriteLine("Insira o índice da sua conta: ");
    int index = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Insira seu nome completo: ");
    string nome = Console.ReadLine()?? "";
    Console.WriteLine("Insira seu CPF (Neste Formato - 111.111.111-11): ");
    string cpf = Console.ReadLine();
    
    ControllerConta.Alterar(index, nome, cpf);
  }

  public static void Deletar () {
    Console.WriteLine("- Deletando sua Conta Corrente -");
    Console.WriteLine("Insira o índice da conta: ");
    int index = Convert.ToInt32(Console.ReadLine());
    
    ControllerConta.Deletar(index);
  }    

  public static void Listar(){
    List<ContaCorrente> contas = ControllerConta.Listar();

    foreach(ContaCorrente conta in contas){
      Console.WriteLine($"Os dados da sua Conta: Nome - {conta.Nome} | CPF - {conta.Cpf}.");
    }

  }
}