namespace program;

public class ControllerCarro{

  public static void Criar (string modelo, int ano, string placa){
    new Carro(modelo, ano, placa);
  }

  public static void Alterar (int index, string modelo, int ano, string placa){
    Carro.Alterar(index, modelo, ano, placa);
  }

  public static void Deletar (int index){
    Carro.Deletar(index);
  }

  public static List <Carro> Listar() {
    return Carro.Listar();
  }

}