namespace Programa;

public class ViewArg{

  public static void Criar(){
    Console.WriteLine("- Cadastrando um novo Agendamento -");
    Console.WriteLine("Digite o nome completo do cliente: ");
    string nomeCliente = Console.ReadLine() ?? "";
    Console.WriteLine("Digite o nome completo do fornecedor: ");
    string nomeFornecedor = Console.ReadLine() ?? "";
    Console.WriteLine("Digite o serviço solicitado: ");
    string serviço = Console.ReadLine() ?? "";
    Console.WriteLine("Digite o valor do serviço: ");
    int valorServiço = Convert.ToInt32(Console.ReadLine());
    
    ControllerArg.Criar(nomeCliente, nomeFornecedor, serviço, valorServiço);
  }

  public static void Alterar(){
    Console.WriteLine("- Alterando um cadastro de Agendamento -");
    Console.WriteLine("Digite o índice do agendamento: ");
    int index = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o nome completo do cliente: ");
    string nomeCliente = Console.ReadLine() ?? "";
    Console.WriteLine("Digite o nome completo do fornecedor: ");
    string nomeFornecedor = Console.ReadLine() ?? "";
    Console.WriteLine("Digite o serviço solicitado: ");
    string serviço = Console.ReadLine() ?? "";
    Console.WriteLine("Digite o valor do serviço: ");
    int valorServiço = Convert.ToInt32(Console.ReadLine());
    
    ControllerArg.Alterar(index, nomeCliente, nomeFornecedor, serviço, valorServiço);
  }
  
  public static void Deletar(){
    Console.WriteLine("- Deletando um cadastro de Agendamento -");
    Console.WriteLine("Digite o índice do agendamento: ");
    int index = Convert.ToInt32(Console.ReadLine());
  
  ControllerArg.Deletar(index);
  }

  public static void Listar () {
    List <Agendamento> agendamentos = ControllerArg.Listar();

    foreach (Agendamento agendamento in agendamentos){
      Console.WriteLine($"Nome: {agendamento.NomeCliente} - Fornecedor: {agendamento.NomeFornecedor} - Serviço a Prestar: {agendamento.Serviço} - Valor: {agendamento.ValorServiço}");
    }

  }

}