namespace program;

public class ViewLivro {

  public static void Criar(){
    Console.WriteLine("- Criando o Cadastro do Livro - ");
    Console.WriteLine("Digite o nome do Livro:");
    string nomeLivro = Console.ReadLine();
    Console.WriteLine("Digite o autor do Livro:");
    string autor = Console.ReadLine();
    Console.WriteLine("Digite a quantidade de páginas do Livro:");
    int numPaginas = Convert.ToInt32(Console.ReadLine());

    ControllerLivro.Criar(nomeLivro, autor, numPaginas);
  }

  public static void Alterar(){
    Console.WriteLine("Alterando o Cadastro do Livro:");
    Console.WriteLine("Digite o índice do Livro:");
    int index = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o nome do Livro:");
    string nomeLivro = Console.ReadLine();
    Console.WriteLine("Digite o autor do Livro:");
    string autor = Console.ReadLine();
    Console.WriteLine("Digite a quantidade de páginas do Livro:");
    int numPaginas = Convert.ToInt32(Console.ReadLine());

    ControllerLivro.Alterar(index, nomeLivro, autor, numPaginas);
  }

  public static void Deletar(){
    Console.WriteLine("Deletando o Cadastro do Livro:");
    Console.WriteLine("Digite o índice do Livro:");
    int index = Convert.ToInt32(Console.ReadLine());
    
    ControllerLivro.Deletar(index);
  }

  public static void Listar(){
    List <Livro> livros = ControllerLivro.Listar();
    
    foreach(Livro livro in livros){
      Console.WriteLine($"Livro: {livro.NomeLivro} - Autor: {livro.Autor} - Páginas: {livro.NumPaginas}.");
    }
  }
}