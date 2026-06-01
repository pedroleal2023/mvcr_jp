namespace std;

public static class ControllerPessoa
{

    public static void Sincronizar(){
            RepositoryPessoa.Sincronizar();
        }

    public static void Criar(string nome, string cpf, int idade)
    {
        Pessoa pessoa = new Pessoa(nome, cpf, idade);
        RepositoryPessoa.Criar(pessoa);
    }

    public static List<Pessoa> Listar()
    {
        return RepositoryPessoa.Listar();
    }

    public static void Alterar(int index, string nome)
    {
        RepositoryPessoa.Alterar(index, nome);
    }

    public static void Deletar(int index)
    {
        RepositoryPessoa.Deletar(index);
    }
    
}


