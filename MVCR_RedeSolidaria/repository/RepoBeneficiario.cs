using MySqlConnector;

namespace std
{
    public class RepoBeneficiario
    {
        static List<Beneficiario> beneficiario_db = [];
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
            string query = "select * from Beneficiario";
            MySqlCommand command = new MySqlCommand(query, conexao);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Beneficiario beneficiario = new Beneficiario();
                beneficiario.IdBeneficiario = int.Parse(reader["id_Beneficiario"].ToString());
                beneficiario.Nome = reader["nome"].ToString();
                beneficiario.Email = reader["email"].ToString();
                beneficiario.Senha = reader["senha"].ToString();
                beneficiario.Cpf = reader["cpf"].ToString();
                beneficiario.Nis = reader["nis"].ToString();
                beneficiario.Telefone = reader["telefone"].ToString();
                beneficiario.Endereco = reader["endereco"].ToString();
                beneficiario.QuantidadeMoradores = int.Parse(reader["quantidade_moradores"].ToString());
                beneficiario.StatusCadUnico = Convert.ToBoolean(reader["status_cadunico"]);
                beneficiario.DataCadastro = DateTime.Parse(reader["data_cadastro"].ToString());
                
                beneficiario_db.Add(beneficiario);
            }
            CloseConnection();
        }

        public static void Criar(Beneficiario beneficiario)
        {
            InitConnection();
            string insert = @"insert into Beneficiario (nome, email, senha, cpf, nis, telefone, endereco, quantidade_moradores, status_cadunico, data_cadastro) 
                             values (@Nome, @Email, @Senha, @Cpf, @Nis, @Telefone, @Endereco, @QtdMoradores, @StatusCad, @Data)";
            
            MySqlCommand command = new MySqlCommand(insert, conexao);
            command.Parameters.AddWithValue("@Nome", beneficiario.Nome);
            command.Parameters.AddWithValue("@Email", beneficiario.Email);
            command.Parameters.AddWithValue("@Senha", beneficiario.Senha);
            command.Parameters.AddWithValue("@Cpf", beneficiario.Cpf);
            command.Parameters.AddWithValue("@Nis", beneficiario.Nis);
            command.Parameters.AddWithValue("@Telefone", beneficiario.Telefone);
            command.Parameters.AddWithValue("@Endereco", beneficiario.Endereco);
            command.Parameters.AddWithValue("@QtdMoradores", beneficiario.QuantidadeMoradores);
            command.Parameters.AddWithValue("@StatusCad", beneficiario.StatusCadUnico);
            command.Parameters.AddWithValue("@Data", beneficiario.DataCadastro);

            int rowsAffected = command.ExecuteNonQuery();  
            if (rowsAffected > 0) 
            {  
                beneficiario.IdBeneficiario = Convert.ToInt32(command.LastInsertedId);
                beneficiario_db.Add(beneficiario);
                Console.WriteLine("Beneficiário cadastrado com sucesso!");
            } 
            else 
            {
                Console.WriteLine("Não foi possível criar o Beneficiário!");
            }  
            CloseConnection();
        }

        public static List<Beneficiario> Listar()
        {
            return beneficiario_db;
        }

        public static void Alterar(int index, string nome, string telefone, string endereco, int qtdMoradores)
        {
            InitConnection();
            string update = "update Beneficiario set nome = @Nome, telefone = @Telefone, endereco = @Endereco, quantidade_moradores = @Qtd WHERE id_Beneficiario = @Id";
            MySqlCommand command = new MySqlCommand(update, conexao);
            
            command.Parameters.AddWithValue("@Id", beneficiario_db[index].IdBeneficiario);
            command.Parameters.AddWithValue("@Nome", nome);
            command.Parameters.AddWithValue("@Telefone", telefone);
            command.Parameters.AddWithValue("@Endereco", endereco);
            command.Parameters.AddWithValue("@Qtd", qtdMoradores);

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0) 
            {
                beneficiario_db[index].Nome = nome;
                beneficiario_db[index].Telefone = telefone;
                beneficiario_db[index].Endereco = endereco;
                beneficiario_db[index].QuantidadeMoradores = qtdMoradores;
            } 
            else 
            {
                Console.WriteLine("Não deu pra alterar o beneficiário man :/");
            }   
            CloseConnection();
        }
        
        public static void Deletar(int index)
        {
            InitConnection();
            string delete = "delete from Beneficiario where id_Beneficiario = @Id";

            MySqlCommand command = new MySqlCommand(delete, conexao);
            command.Parameters.AddWithValue("@Id", beneficiario_db[index].IdBeneficiario);

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                beneficiario_db.RemoveAt(index);
            } 
            else 
            {
                Console.WriteLine("Não foi possível deletar o beneficiário.");
            }

            CloseConnection();
        }
        
        public static void CloseConnection()
        {
            conexao.Close();
        } 
    }
}