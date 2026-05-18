namespace Programa;

public class ControllerArg{

  public static void Criar (string nomeCliente, string nomeFornecedor, string serviço, int valor){
    new Agendamento(nomeCliente, nomeFornecedor, serviço, valor);
  }

  public static void Alterar(int index, string nomeCliente, string nomeFornecedor, string serviço, int valor){
    Agendamento.Alterar(index, nomeCliente, nomeFornecedor, serviço, valor);
  }

  public static void Deletar(int index){
    Agendamento.Deletar(index);
  }

  public static List<Agendamento> Listar(){
    return Agendamento.Listar();
  }
}