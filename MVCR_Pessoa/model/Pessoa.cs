namespace std;

public class Pessoa {

  public int Id { get; set; }
  public string Nome { get; set; }
  public string Cpf { get; set; }
  public int Idade  { get; set; }
  
  public Pessoa(){ }

  public Pessoa (string nome, string cpf, int idade){
    this.Nome = nome;
    this.Cpf = cpf;
    this.Idade = idade;
  }
}