namespace std;

public class Pessoa {

  public string Nome { get; set; }
  public string Cpf { get; set; }
  public int Idade  { get; set; }
  public 

  public Pessoa (string nome, string cpf, int idade){
    this.Nome = nome;
    this.Cpf = cpf;
    this.Idade = idade;

    RepoPessoa.pessoas.Add(this);
  }

  public static void Alterar(int index, string nome, string cpf, int idade){
    RepoPessoa.pessoas[index].Nome = nome;
    RepoPessoa.pessoas[index].Cpf = cpf;
    RepoPessoa.pessoas[index].Idade = idade;
  }

  public static void Deletar(int index){
    RepoPessoa.pessoas.RemoveAt(index);
  }

  public static List <Pessoa> Listar(){
    return RepoPessoa.pessoas;    
  }
}