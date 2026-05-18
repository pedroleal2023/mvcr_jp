namespace Programa;

public class ControllerFilme{

  public static void Criar (string nome, string produtora, int anoLancamento){
 new Filme(nome, produtora, anoLancamento);
  }

  public static void Alterar (int index, string nome, string produtora, int anoLancamento){
    Filme.Alterar(index, nome, produtora, anoLancamento);
  }

  public static void Deletar (int index){
    Filme.Deletar(index);
  }

  public static List <Filme> Listar(){
    return Filme.Listar();
  }
}