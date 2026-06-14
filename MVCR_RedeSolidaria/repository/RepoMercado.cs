using MySqlConnector;

namespace std
{
    public class RepoMercado
    {
        static List<Mercado> mercado_db = [];
        private static MySqlConnection conexao;

        public static void InitConnection()
        {
            string info = "server=localhost;database=rede_solidaria;user id=root;password=''";
            conexao = new MySqlConnection(info);

            try
            {
                conexao.Open();
                Console.WriteLine("- Conexão com o banco de dados estabelecida -");
            }
            catch
            {
                Console.WriteLine("Conexão NÃO Estabelecida.");
            }
        }

        public static void Sincronizar()
        {
            InitConnection();
            string query = "select * from Mercado";
            MySqlCommand command = new MySqlCommand(query, conexao);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Mercado mercado = new Mercado();
                mercado.IdMercado = int.Parse(reader["id_Mercado"].ToString());
                mercado.NomeFantasia = reader["nome_fantasia"].ToString();
                mercado.Cnpj = reader["cnpj"].ToString();
                mercado.Telefone = reader["telefone"].ToString();
                mercado.Email = reader["email"].ToString();
                mercado.Senha = reader["senha"].ToString();
                mercado.Endereco = reader["endereco"].ToString();
                mercado.DataCadastro = DateTime.Parse(reader["data_cadastro"].ToString());
                mercado.StatusMercado = Convert.ToBoolean(reader["status_mercado"]);
                
                mercado_db.Add(mercado);
            }
            CloseConnection();
        }

        public static void Criar(Mercado mercado)
        {
            InitConnection();
            string insert = @"insert into Mercado (nome_fantasia, cnpj, telefone, email, senha, endereco, data_cadastro, status_mercado) 
                             values (@Nome, @Cnpj, @Telefone, @Email, @Senha, @Endereco, @Data, @Status)";
            
            MySqlCommand command = new MySqlCommand(insert, conexao);
            command.Parameters.AddWithValue("@Nome", mercado.NomeFantasia);
            command.Parameters.AddWithValue("@Cnpj", mercado.Cnpj);
            command.Parameters.AddWithValue("@Telefone", mercado.Telefone);
            command.Parameters.AddWithValue("@Email", mercado.Email);
            command.Parameters.AddWithValue("@Senha", mercado.Senha);
            command.Parameters.AddWithValue("@Endereco", mercado.Endereco);
            command.Parameters.AddWithValue("@Data", mercado.DataCadastro);
            command.Parameters.AddWithValue("@Status", mercado.StatusMercado);

            int rowsAffected = command.ExecuteNonQuery();  
            if (rowsAffected > 0) 
            {  
                mercado.IdMercado = Convert.ToInt32(command.LastInsertedId);
                mercado_db.Add(mercado);
                Console.WriteLine("Mercado cadastrado com sucesso!");
            } 
            else 
            {
                Console.WriteLine("Não rolou criar o mercado man!");
            }  
            CloseConnection();
        }

        public static List<Mercado> Listar()
        {
            return mercado_db;
        }

        public static void Alterar(int index, string nome, string telefone, string endereco)
        {
            InitConnection();
            string update = "update Mercado set nome_fantasia = @Nome, telefone = @Telefone, endereco = @Endereco WHERE id_Mercado = @Id";
            MySqlCommand command = new MySqlCommand(update, conexao);
            
            command.Parameters.AddWithValue("@Id", mercado_db[index].IdMercado);
            command.Parameters.AddWithValue("@Nome", nome);
            command.Parameters.AddWithValue("@Telefone", telefone);
            command.Parameters.AddWithValue("@Endereco", endereco);

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0) 
            {
                mercado_db[index].NomeFantasia = nome;
                mercado_db[index].Telefone = telefone;
                mercado_db[index].Endereco = endereco;
            } 
            else 
            {
                Console.WriteLine("Não deu pra alterar o mercado.");
            }   
            CloseConnection();
        }
        
        public static void Deletar(int index)
        {
            InitConnection();
            string delete = "delete from Mercado where id_Mercado = @Id";

            MySqlCommand command = new MySqlCommand(delete, conexao);
            command.Parameters.AddWithValue("@Id", mercado_db[index].IdMercado);

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                mercado_db.RemoveAt(index);
            } 
            else 
            {
                Console.WriteLine("Não foi possível deletar o mercado.");
            }

            CloseConnection();
        }
        
        public static void CloseConnection()
        {
          conexao.Close();
        } 
    }
}