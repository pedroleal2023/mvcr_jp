namespace programa;

public class ViewPessoa {
  public static void Criar(){
    Console.WriteLine("Criando uma pessoa ---");
    Console.WriteLine("Informe o nome da pessoa:  ");
    string nome = Console.ReadLine() ?? "";
    Console.WriteLine("informe a idade da passoa: ");
    int idade = Convert.ToInt32(Console.ReadLine());
    ControllerPessoa.Criar(nome, idade);

  }

  public static void Alterar(){
    Console.WriteLine("--- Alterar uma pessoa ---");
    Console.WriteLine("Informe o indice da pessoa para alterar: ");
    int index = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Informe o nome da pessoa:  ");
    string nome = Console.ReadLine() ?? "";
    Console.WriteLine("informe a idade da passoa: ");
    int idade = Convert.ToInt32(Console.ReadLine());
    ControllerPessoa.Alterar(index, nome, idade);
    
  }

  public static void Deletar(){
    Console.WriteLine("--- Deletar uma pessoa ---");
    Console.WriteLine("Informe o indice da pessoa para deletar: ");
    int index = Convert.ToInt32(Console.ReadLine());
     ControllerPessoa.Deletar(index);
  }

  public static void Listar(){
    List<Pessoa> pessoas = ControllerPessoa.Listar();

    foreach (Pessoa pessoa in pessoas){
      Console.WriteLine($"{pessoa.Nome} - {pessoa.Idade}");
   }
  }
}