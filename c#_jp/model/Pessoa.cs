namespace programa;

public class Pessoa {
  
  public string Nome {get; set; }

  public int Idade {get; set; }

  public Pessoa(string nome, int idade) {
      this.Nome = nome;
      this.Idade = idade;

      RepoPessoa.pessoas.Add(this);
  }

  public static void Alterar(int index, string nome, int idade){
    RepoPessoa.pessoas[index].Nome = nome;
    RepoPessoa.pessoas[index].Idade = idade;
    
  }

  public static void Deletar (int index){
    RepoPessoa.pessoas.RemoveAt(index);
  }

   public static List<Pessoa> Listar() {
    return RepoPessoa.pessoas;
  }


}