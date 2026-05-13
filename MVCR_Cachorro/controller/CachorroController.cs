namespace program;

public class CachorroController {

  public static void Criar(string nomeDono, string nome, string raça, double peso){
    new Cachorro (nomeDono, nome, raça, peso);
  }

  public static void Alterar(int index, string nomeDono, string nome, string raça, double peso){
    Cachorro.Alterar(index, nomeDono, nome, raça, peso);
  }

  public static void Deletar(int index){
    Cachorro.Deletar(index);
  }

  public static List<Cachorro> Listar(){
    return Cachorro.Listar();
  }
}