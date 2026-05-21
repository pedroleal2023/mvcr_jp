maespace std;

public class ViewPessoa{

  public static void Criar(){
    Console.WriteLine("- Criando uma nova pessoa -");
    Console.WriteLine("Digite o nome: ");
    string nome = Console.ReadLine()?? "";
    Console.WriteLine("Digite o cpf: ");
    string cpf = Console.ReadLine()?? "";
    Console.WriteLine("Digite a idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());

    ControllerPessoa.Criar(nome, cpf, idade);    
  }

  public static void Alterar(){
    Console.WriteLine("- Alterando o cadastro de uma pessoa -");
    Console.WriteLine("Digite o índice: ");
    int index = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o nome: ");
    string nome = Console.ReadLine()?? "";
    Console.WriteLine("Digite o cpf: ");
    string cpf = Console.ReadLine()?? "";
    Console.WriteLine("Digite a idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());

    ControllerPessoa.Alterar(index, nome, cpf, idade);    
  }
  
  public static void Deletar(){
    Console.WriteLine("- Deletando o cadastro de uma pessoa -");
    Console.WriteLine("Digite o índice: ");
    int index = Convert.ToInt32(Console.ReadLine());
    
    ControllerPessoa.Deletar(index);
  }
  
  public static void Listar(){
    List <Pessoa> pessoa = Controller.Listar();

    foreach(Pessoa pessoa in pessoas){
      Console.WriteLine($"Nome: {pessoa.Nome} - CPF: {pessoa.Cpf} - Idade: {pessoa.Idade}");
    }
  }
  
}