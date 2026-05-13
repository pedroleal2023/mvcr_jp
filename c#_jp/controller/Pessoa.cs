namespace programa;

public class ControllerPessoa {
  public static void Criar(string nome, int idade){
    new Pessoa(nome, idade);
  }

  public static void Alterar(int index, string nome, int idade){
    Pessoa.Alterar(index, nome, idade);
  }

  public static void Deletar(int index){
    Pessoa.Deletar(index);
  }

  public static List <Pessoa> Listar(){
      return Pessoa.Listar(); 
  }
}