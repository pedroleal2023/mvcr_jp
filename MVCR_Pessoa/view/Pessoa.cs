namespace std;

public class ViewPessoa
{
        public static void Sincronizar(){
            ControllerPessoa.Sincronizar();
        }
    public static void Criar()
    {
        Console.WriteLine("Digite o nome da pessoa");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o cpf da pessoa");
        string cpf = Console.ReadLine();
        Console.WriteLine("Digite a idade da pessoa");
        int idade = int.Parse(Console.ReadLine());
        // Enviar para o controller
       ControllerPessoa.Criar(nome, cpf, idade);
    }

    public static void Listar()
    {
        foreach (Pessoa pessoa in ControllerPessoa.Listar())
        {
            Console.WriteLine($"Nome: {pessoa.Nome} - CPF: {pessoa.Cpf} - Idade: {pessoa.Idade}");   
        }
    }

    public static void Alterar()
    {
        Console.WriteLine("Digite o índice do item a ser alterado");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o nome para alterar:");
        string nome = Console.ReadLine();

        ControllerPessoa.Alterar(index, nome);
    }

    public static void Deletar()
    {
        Console.WriteLine("Digite o índice do item a ser deletado:");
        int index = int.Parse(Console.ReadLine());
    
        ControllerPessoa.Deletar(index);
    }
}