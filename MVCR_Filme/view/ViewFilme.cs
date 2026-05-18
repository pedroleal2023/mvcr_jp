namespace Programa;

public class ViewFilme{

  public static void Criar(){
    Console.WriteLine("Cadastrando um novo Filme!");
    Console.WriteLine("Digite o nome do filme: ");
    string nome = Console.ReadLine() ?? "";
    Console.WriteLine("Qual a produtora do filme: ");
    string produtora = Console.ReadLine() ?? "";
    Console.WriteLine("Digite o ano de lançamento do filme: ");
    int anoLancamento = Convert.ToInt32(Console.ReadLine());

    ControllerFilme.Criar(nome, produtora, anoLancamento);
  }

  public static void Alterar(){
    Console.WriteLine("Alterando um novo Filme!");
    Console.WriteLine("Digite o índice do filme para alterar: ");
    int index = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o nome do filme: ");
    string nome = Console.ReadLine() ?? "";
    Console.WriteLine("Qual a produtora do filme: ");
    string produtora = Console.ReadLine() ?? "";
    Console.WriteLine("Digite o ano de lançamento do filme: ");
    int anoLancamento = Convert.ToInt32(Console.ReadLine());

    ControllerFilme.Alterar(index, nome, produtora, anoLancamento);
  }

  public static void Deletar(){
    Console.WriteLine("Excluindo um Filme!");
    Console.WriteLine("Digite o índice do filme para deletar: ");
    int index = Convert.ToInt32(Console.ReadLine());
    
    ControllerFilme.Deletar(index);
  }

  public static void Listar(){
    List <Filme> filmes = ControllerFilme.Listar();

    foreach(Filme filme in filmes){
      Console.WriteLine($"Filme: {filme.Nome} - Produtora: {filme.Produtora} - Ano de Lançamento: {filme.AnoLancamento}");
    }
  }   
}