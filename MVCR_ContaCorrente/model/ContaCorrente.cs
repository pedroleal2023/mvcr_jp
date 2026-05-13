namespace Programa;

public class ContaCorrente {

  public string Nome { get; set; }
  public string Cpf { get; set; }

  public ContaCorrente(string nome, string cpf){
    this.Nome = nome;
    this.Cpf = cpf;

    RepoConta.contas.Add(this);
  }

  public static void Alterar(int index, string nome, string cpf){
      RepoConta.contas[index].Nome = nome;
      RepoConta.contas[index].Cpf = cpf;
      
  }

  public static void Deletar (int index){
    RepoConta.contas.RemoveAt(index);
  }

  public static List <ContaCorrente> Listar() {
    return RepoConta.contas;
  }

}