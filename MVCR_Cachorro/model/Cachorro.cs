namespace program;

public class Cachorro {

  public string NomeDono {get; set; }

  public string Nome {get; set; }

  public string Raça {get; set; }

  public double Peso {get; set; }

  public Cachorro ( string nomeDono, string nome, string raça, double peso){
    this.NomeDono = nomeDono;
    this.Nome = nome;
    this.Raça = raça;
    this.Peso = peso;
    
    RepoCachorro.cachorros.Add(this);
  }

  public static void Alterar(int index, string nomeDono, string nome, string raça, double peso){
    RepoCachorro.cachorros[index].NomeDono = nomeDono;
    RepoCachorro.cachorros[index].Nome = nome;
    RepoCachorro.cachorros[index].Raça = raça;
    RepoCachorro.cachorros[index].Peso = peso;
    
  }

  public static List<Cachorro> Listar(){
    return RepoCachorro.cachorros;
  }

  public static void Deletar (int index) {
   RepoCachorro.cachorros.RemoveAt(index); 
  }
}