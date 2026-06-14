using MySqlConnector;

namespace std;
    public class RepoMovimentacao
    {
        static List<Movimentacao> movimentacao_db = [];
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
            string query = "select * from Movimentacao";
            MySqlCommand command = new MySqlCommand(query, conexao);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Movimentacao movimentacao = new Movimentacao();
                movimentacao.IdMovimentacao = int.Parse(reader["id_movimentacao"].ToString());
                movimentacao.IdBeneficiario = int.Parse(reader["id_beneficiario"].ToString());
                movimentacao.IdMercado = int.Parse(reader["id_mercado"].ToString());
                movimentacao.IdCesta = int.Parse(reader["id_cesta"].ToString());
                movimentacao.TipoMovimentacao = reader["tipo_movimentacao"].ToString();
                movimentacao.Descricao = reader["descricao"].ToString();
                movimentacao.DataMovimentacao = DateTime.Parse(reader["data_movimentacao"].ToString());
                
                movimentacao_db.Add(movimentacao);
            }
            CloseConnection();
        }

        public static void Criar(Movimentacao movimentacao)
        {
            InitConnection();
            string insert = @"insert into Movimentacao (id_beneficiario, id_mercado, id_cesta, tipo_movimentacao, descricao, data_movimentacao) 
                             values (@IdBeneficiario, @IdMercado, @IdCesta, @Tipo, @Descricao, @DataMov)";
            
            MySqlCommand command = new MySqlCommand(insert, conexao);
            command.Parameters.AddWithValue("@IdBeneficiario", movimentacao.IdBeneficiario);
            command.Parameters.AddWithValue("@IdMercado", movimentacao.IdMercado);
            command.Parameters.AddWithValue("@IdCesta", movimentacao.IdCesta);
            command.Parameters.AddWithValue("@Tipo", movimentacao.TipoMovimentacao);
            command.Parameters.AddWithValue("@Descricao", movimentacao.Descricao);
            command.Parameters.AddWithValue("@DataMov", movimentacao.DataMovimentacao);

            int rowsAffected = command.ExecuteNonQuery();  
            if (rowsAffected > 0) 
            {  
                movimentacao.IdMovimentacao = Convert.ToInt32(command.LastInsertedId);
                movimentacao_db.Add(movimentacao);
                Console.WriteLine("Movimentação registrada com sucesso!");
            } 
            else 
            {
                Console.WriteLine("Não foi possível registrar a movimentação.");
            }  
            CloseConnection();
        }

        public static List<Movimentacao> Listar()
        {
            return movimentacao_db;
        }

        public static void CloseConnection()
        {
            conexao.Close();
        } 
    }
