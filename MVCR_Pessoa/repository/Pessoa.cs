using MySqlConnector;

namespace std;

public class RepositoryPessoa
{
    static List<Pessoa> pessoas = [];
    
    private static MySqlConnection conexao;

    public static void InitConexao() {
        string info = "server=localhost;database=exemplo;user id=root;password='root'";
        conexao = new MySqlConnection(info);
        try 
        {
            conexao.Open();
            Console.WriteLine("Conexão com o banco estabelecida com sucesso.");
        } catch
        {
            Console.WriteLine("Deu ruim!");
        }
    }

    public static void Sincronizar()
    {
        // copiar os dados qu eestão no banco e colocar na Lista
        // abrir conexão
            // - buscar os dados da tabela-> select * from pessoas;
            // - colocar na lista;
        // fechar conexão
        
        InitConexao();
            string query = "select * from pessoas";
            MySqlCommand command = new MySqlCommand(query, conexao);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read()){
                Pessoa pessoa = new Pessoa();
                pessoa.Id = int.Parse(reader["id_pessoas"].ToString());
                pessoa.Nome = reader["nome"].ToString();
                pessoa.Cpf = reader["cpf"].ToString();
                pessoa.Idade = int.Parse(reader["idade"].ToString());
                pessoas.Add(pessoa);
            }
        CloseConexao();
    }

    public static void Criar(Pessoa pessoa)
    {
        //inicia a conxexão
         //string query
         // commando
         // da enter
         // RowsAffected
         // adiciona na lista
        //fechar conexao

        InitConexao();
        string insert = "INSERT INTO pessoas (nome, cpf, idade) VALUES (@Nome, @Cpf, @Idade)";
        MySqlCommand command = new MySqlCommand(insert, conexao);
        command.Parameters.AddWithValue("@Nome", pessoa.Nome);
        command.Parameters.AddWithValue("@Cpf", pessoa.Cpf);
        command.Parameters.AddWithValue("@Idade", pessoa.Idade);
         // deveria ser o cpf, mas como não tem na classe, coloquei o nome.
        int rowsAffected = command.ExecuteNonQuery();
        if (rowsAffected > 0){
            pessoa.Id = Convert.ToInt32(command.LastInsertedId);
            pessoas.Add(pessoa);
        } else {
            Console.WriteLine("Não deu pra criar carai!");
        }
        CloseConexao();
    }

    public static List<Pessoa> Listar()
    {
        return pessoas;
    }

    public static void Alterar(int index, string nome)
    {
        // iniciar conexao
            // string query
            // comando
            // da enter < 2 coisas
            // RowsAffected < linhas afetadas
            // alterar na lista
        //fechar conexao
        
        InitConexao();
        string query = "UPDATE pessoas SET nome = @Nome WHERE id_pessoas = @Id";
        MySqlCommand command = new MySqlCommand(query, conexao);
        command.Parameters.AddWithValue("@Id", pessoas[index].Id);
        command.Parameters.AddWithValue("@Nome", nome);

        int rowsAffected = command.ExecuteNonQuery();
        if (rowsAffected > 0){
        pessoas[index].Nome = nome;
        } else {
            Console.WriteLine("Não deu pra alterar carai!");
        }
        CloseConexao();
    }

    public static void Deletar(int index)
    {
        // iniciar conexao
            // string query - delete
            // comando
            // da enter < 2 coisas
            // RowsAffected < linhas afetadas
            // deletar na lista
        //fechar conexao

        InitConexao();
            string delete = "DELETE FROM pessoas WHERE id_pessoas = @Id";
            MySqlCommand command = new MySqlCommand(delete, conexao);
            command.Parameters.AddWithValue("@Id", pessoas[index].Id);
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0){
        pessoas.RemoveAt(index);
        } else {
            Console.WriteLine("Não deu pra deletar carai!");
        }
        CloseConexao();
    }

    public static void CloseConexao() {
        conexao.Close();
    }
}




