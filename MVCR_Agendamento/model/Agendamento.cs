namespace Programa;

public class Agendamento{

  public string NomeCliente { get; set; }
  public string NomeFornecedor { get; set; }
  public string Serviço { get; set; }
  public int ValorServiço { get; set; }

  public Agendamento (string nomeCliente, string nomeFornecedor, string serviço, int valorServiço) {
    this.NomeCliente = nomeCliente;
    this.NomeFornecedor = nomeFornecedor;
    this.Serviço = serviço;
    this.ValorServiço = valorServiço;

    RepoArg.agendamentos.Add(this);
  }

  public static void Alterar (int index, string nomeCliente, string nomeFornecedor, string serviço, int valorServiço) {
    RepoArg.agendamentos[index].NomeCliente = nomeCliente;
    RepoArg.agendamentos[index].NomeFornecedor = nomeFornecedor;
    RepoArg.agendamentos[index].Serviço = serviço;
    RepoArg.agendamentos[index].ValorServiço = valorServiço;

  }

  public static void Deletar (int index){
    RepoArg.agendamentos.RemoveAt(index);
  }

  public static List <Agendamento> Listar(){
    return RepoArg.agendamentos;
  }

  

}