namespace Programa;

public class Filme {

  public string Nome { get; set; }
  public string Produtora { get; set; }
  public int AnoLancamento { get; set; }

  public Filme (string nome, string produtora, int anoLancamento){
    this.Nome = nome;
    this.Produtora = produtora;
    this.AnoLancamento = anoLancamento;

    RepoFilme.filmes.Add(this);
  }

  public static void Alterar (int index, string nome, string produtora, int anoLancamento){
    RepoFilme.filmes[index].Nome = nome;
    RepoFilme.filmes[index].Produtora = produtora;
    RepoFilme.filmes[index].AnoLancamento = anoLancamento;
  }

  public static void Deletar (int index){
    
    RepoFilme.filmes.RemoveAt(index);
  }

public static List<Filme> Listar (){
  return RepoFilme.filmes;
}
    
}