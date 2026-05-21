namespace std;

public class ControllerPessoa{

  public static void Criar(string nome, string cpf, int idade){
    new Pessoa(nome, cpf, cpf, idade);
  }
    
  public static void Alterar(int index, string nome, string cpf, int idade){
    Pessoa.Alterar(index, nome, cpf, idade);
  }

  public static void Deletar(ind index){
    Pessoa.Deletar(index);
  }

  public static List<Pessoa> Listar(){
    return Pessoa.Listar();
  }
  
}