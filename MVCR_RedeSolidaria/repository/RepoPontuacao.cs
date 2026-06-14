using MySqlConnector;

namespace std;
    public class RepoPontuacao
    {
        static List<Pontuacao> pontuacao_db = [];
        private static MySqlConnection conexao;

        public static void InitConnection()
        {
            string info = "server=localhost;database=rede_solidaria;user id=root;password='root'";
            conexao = new MySqlConnection(info);

            try
            {
                conexao.Open();
                Console.WriteLine("- Conexão com o banco de dados estabelecida -");
            }
            catch
            {
                Console.WriteLine("Não foi possível conectar.");
            }
        }

        public static void Sincronizar()
        {
            InitConnection();
            string query = "select * from Pontuacao";
            MySqlCommand command = new MySqlCommand(query, conexao);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Pontuacao pontuacao = new Pontuacao();
                pontuacao.IdPontuacao = int.Parse(reader["id_pontuacao"].ToString());
                pontuacao.IdMercado = int.Parse(reader["id_mercado"].ToString());
                pontuacao.Pontos = int.Parse(reader["pontos"].ToString());
                pontuacao.DataPontuacao = DateTime.Parse(reader["data_pontuacao"].ToString());
                
                pontuacao_db.Add(pontuacao);
            }
            CloseConnection();
        }

        public static void Criar(Pontuacao pontuacao)
        {
            InitConnection();
            string insert = @"insert into Pontuacao (id_mercado, pontos, data_pontuacao) 
                             values (@IdMercado, @Pontos, @DataPont)";
            
            MySqlCommand command = new MySqlCommand(insert, conexao);
            command.Parameters.AddWithValue("@IdMercado", pontuacao.IdMercado);
            command.Parameters.AddWithValue("@Pontos", pontuacao.Pontos);
            command.Parameters.AddWithValue("@DataPont", pontuacao.DataPontuacao);

            int rowsAffected = command.ExecuteNonQuery();  
            if (rowsAffected > 0) 
            {  
                pontuacao.IdPontuacao = Convert.ToInt32(command.LastInsertedId);
                pontuacao_db.Add(pontuacao);
                Console.WriteLine("Pontuação registrada com sucesso!");
            } 
            else 
            {
                Console.WriteLine("Não foi possível registrar a pontuação.");
            }  
            CloseConnection();
        }

        public static List<Pontuacao> Listar()
        {
            return pontuacao_db;
        }

        public static void CloseConnection()
        {
            conexao.Close();
        } 
    }
