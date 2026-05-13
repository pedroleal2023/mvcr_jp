namespace program;

public class Carro {

  public string Modelo {get; set; }

  public int Ano {get; set; }

  public string Placa {get; set; }

  public Carro(string modelo, int ano, string placa){
    this.Modelo = modelo;
    this.Ano = ano;
    this.Placa = placa;

    RepoCarro.carros.Add(this);
  }

  public static void Alterar(int index, string modelo, int ano, string placa){
    RepoCarro.carros[index].Modelo = modelo;
    RepoCarro.carros[index].Ano = ano;
    RepoCarro.carros[index].Placa = placa;
  }

  public static void Deletar (int index){
    RepoCarro.carros.RemoveAt(index);
  }

  public static List <Carro> Listar(){   
    return RepoCarro.carros;
  }
 

}