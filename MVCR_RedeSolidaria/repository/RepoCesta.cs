using MySqlConnector;

namespace std;
    public class RepoCesta
    {
        // Lista static que serve como a cópia do banco em memória
        static List<Cesta> cesta_db = [];
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
                Console.WriteLine("Não foi possível se conectar.");
            }
        }

        public static void Sincronizar()
        {
            InitConnection();
            string query = "select * from Cesta";
            MySqlCommand command = new MySqlCommand(query, conexao);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Cesta cesta = new Cesta();
                cesta.IdCesta = int.Parse(reader["id_cesta"].ToString());
                cesta.IdMercado = int.Parse(reader["id_mercado"].ToString());
                cesta.Descricao = reader["descricao"].ToString();
                cesta.QuantidadeItens = int.Parse(reader["quantidade_itens"].ToString());
                cesta.DataDisponibilizacao = DateTime.Parse(reader["data_disponibilizacao"].ToString());
                cesta.StatusCesta = reader["status_cesta"].ToString();
                
                cesta_db.Add(cesta);
            }
            CloseConnection();
        }

        public static void Criar(Cesta cesta)
        {
            InitConnection();
            string insert = @"insert into Cesta (id_mercado, descricao, quantidade_itens, data_disponibilizacao, status_cesta) 
                             values (@IdMercado, @Descricao, @QtdItens, @DataDisp, @Status)";
            
            MySqlCommand command = new MySqlCommand(insert, conexao);
            command.Parameters.AddWithValue("@IdMercado", cesta.IdMercado);
            command.Parameters.AddWithValue("@Descricao", cesta.Descricao);
            command.Parameters.AddWithValue("@QtdItens", cesta.QuantidadeItens);
            command.Parameters.AddWithValue("@DataDisp", cesta.DataDisponibilizacao);
            command.Parameters.AddWithValue("@Status", cesta.StatusCesta);

            int rowsAffected = command.ExecuteNonQuery();  
            if (rowsAffected > 0) 
            {  
                cesta.IdCesta = Convert.ToInt32(command.LastInsertedId);
                cesta_db.Add(cesta);
                Console.WriteLine("Cesta cadastrada com sucesso!");
            } 
            else 
            {
                Console.WriteLine("Não rolou cadastrar a cesta man!");
            }  
            CloseConnection();
        }

        public static List<Cesta> Listar()
        {
            return cesta_db;
        }

        public static void Alterar(int index, string descricao, int qtdItens)
        {
            InitConnection();
            string update = "update Cesta set descricao = @Descricao, quantidade_itens = @Qtd WHERE id_cesta = @Id";
            MySqlCommand command = new MySqlCommand(update, conexao);
            
            command.Parameters.AddWithValue("@Id", cesta_db[index].IdCesta);
            command.Parameters.AddWithValue("@Descricao", descricao);
            command.Parameters.AddWithValue("@Qtd", qtdItens);

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0) 
            {
                cesta_db[index].Descricao = descricao;
                cesta_db[index].QuantidadeItens = qtdItens;
            } 
            else 
            {
                Console.WriteLine("Não deu pra alterar a cesta man :/");
            }   
            CloseConnection();
        }
        
        public static void Deletar(int index)
        {
            InitConnection();
            string delete = "delete from Cesta where id_cesta = @Id";

            MySqlCommand command = new MySqlCommand(delete, conexao);
            command.Parameters.AddWithValue("@Id", cesta_db[index].IdCesta);

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                cesta_db.RemoveAt(index);
            } 
            else 
            {
                Console.WriteLine("Não foi possível deletar a cesta.");
            }

            CloseConnection();
        }

        
        public static void AtualizarStatus(int index, string novoStatus)
        {
            InitConnection();
            string update = "update Cesta set status_cesta = @Status WHERE id_cesta = @Id";
            MySqlCommand command = new MySqlCommand(update, conexao);
            
            command.Parameters.AddWithValue("@Id", cesta_db[index].IdCesta);
            command.Parameters.AddWithValue("@Status", novoStatus);

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0) 
            {
                cesta_db[index].StatusCesta = novoStatus;
            }   
            CloseConnection();
        }
        
        
        public static void CloseConnection()
        {
            conexao.Close();
        } 
    }
