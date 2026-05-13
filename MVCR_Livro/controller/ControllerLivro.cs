namespace program;

public class ControllerLivro{

  public static void Criar(string nomeLivro, string autor, int numPaginas){
    new Livro (nomeLivro, autor, numPaginas);
  }

  public static void Alterar(int index, string nomeLivro, string autor, int numPaginas){
    Livro.Alterar(index, nomeLivro, autor, numPaginas);
  }

  public static void Deletar(int index){
    Livro.Deletar(index);
  }

  public static List <Livro> Listar(){
    return Livro.Listar();
  }
}