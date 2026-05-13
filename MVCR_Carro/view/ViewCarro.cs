namespace program;

public class ViewCarro {

  public static void Criar(){
    Console.WriteLine("¨¨¨Criando o cadastro¨¨¨¨");
    Console.WriteLine("Insira o modelo do carro: ");
    string modelo = Console.ReadLine();
    Console.WriteLine("Insira o ano de fabricação: ");
    int ano = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Insira a placa (neste modelo: AAA1A22)");
    string placa = Console.ReadLine();
    
    ControllerCarro.Criar(modelo, ano, placa);
  }

  public static void Alterar(){
    Console.WriteLine("¨¨¨Alterando o cadastro¨¨¨¨");
    Console.WriteLine("Informe o índice do carro para alterar: ");
    int index = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Insira o modelo do carro: ");
    string modelo = Console.ReadLine();
    Console.WriteLine("Insira o ano de fabricação: ");
    int ano = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Insira a placa (neste modelo: AAA1A22)");
    string placa = Console.ReadLine();
    
    ControllerCarro.Alterar(index, modelo, ano, placa);
    
  }

  public static void Deletar(){
    Console.WriteLine("¨¨¨Deletando o cadastro¨¨¨¨");
    Console.WriteLine("Informe o índice do carro para deletar: ");
    int index = Convert.ToInt32(Console.ReadLine());

    ControllerCarro.Deletar(index);
  }

  public static void Listar(){
    List <Carro> carros = ControllerCarro.Listar();

    foreach(Carro carro in carros){
      Console.WriteLine($"{carro.Modelo} --- {carro.Ano} --- {carro.Placa}");
    }
  }
  

}