namespace program;

public class Livro{

  public string NomeLivro {get; set; }

  public string Autor {get; set; }

  public int NumPaginas {get; set; }

  public Livro(string nomeLivro, string autor, int numPaginas){
    this.NomeLivro = nomeLivro;
    this.Autor = autor;
    this.NumPaginas = numPaginas; 

    RepoLivro.livros.Add(this);
  }

  public static void Alterar(int index, string nomeLivro, string autor, int numPaginas){
    RepoLivro.livros[index].NomeLivro = nomeLivro;
    RepoLivro.livros[index].Autor = autor;
    RepoLivro.livros[index].NumPaginas = numPaginas;
    
  }

  public static void Deletar(int index){
    RepoLivro.livros.RemoveAt(index);
  }

  public static List <Livro> Listar(){
    return RepoLivro.livros;
  }
  
}