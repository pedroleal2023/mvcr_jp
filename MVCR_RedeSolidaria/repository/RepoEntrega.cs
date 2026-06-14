using MySqlConnector;

namespace std
{
    public class RepoEntrega
    {
        static List<Entrega> entrega_db = [];
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
                Console.WriteLine("Não foi possível conectar.");
            }
        }

        public static void Sincronizar()
        {
            InitConnection();
            entrega_db.Clear(); 
            string query = "select * from Entrega";
            MySqlCommand command = new MySqlCommand(query, conexao);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Entrega entrega = new Entrega();
                entrega.IdEntrega = int.Parse(reader["id_entrega"].ToString());
                entrega.IdCesta = int.Parse(reader["id_cesta"].ToString());
                entrega.IdBeneficiario = int.Parse(reader["id_beneficiario"].ToString());
                entrega.DataSolicitacao = DateTime.Parse(reader["data_solicitacao"].ToString());
                entrega.DataEntrega = DateTime.Parse(reader["data_entrega"].ToString()); 
                entrega.StatusEntrega = reader["status_entrega"].ToString();
                
                entrega_db.Add(entrega);
            }
            CloseConnection();
        }

        public static void Criar(Entrega entrega)
        {
            InitConnection();
            string insert = @"insert into Entrega (id_cesta, id_beneficiario, data_solicitacao, data_entrega, status_entrega) 
                             values (@IdCesta, @IdBeneficiario, @DataSol, @DataEnt, @Status)";
            
            MySqlCommand command = new MySqlCommand(insert, conexao);
            command.Parameters.AddWithValue("@IdCesta", entrega.IdCesta);
            command.Parameters.AddWithValue("@IdBeneficiario", entrega.IdBeneficiario);
            command.Parameters.AddWithValue("@DataSol", entrega.DataSolicitacao);
            command.Parameters.AddWithValue("@DataEnt", entrega.DataEntrega); 
            command.Parameters.AddWithValue("@Status", entrega.StatusEntrega);

            int rowsAffected = command.ExecuteNonQuery();  
            if (rowsAffected > 0) 
            {  
                entrega.IdEntrega = Convert.ToInt32(command.LastInsertedId);
                entrega_db.Add(entrega);
                Console.WriteLine("Solicitação de entrega registrada com sucesso!");
            } 
            else 
            {
                Console.WriteLine("Não foi possível registrar a entrega.");
            }  
            CloseConnection();
        }

        public static List<Entrega> Listar()
        {
            return entrega_db;
        }

        public static void Alterar(int index, string statusEntrega, DateTime dataEntrega)
        {
            InitConnection();
            string update = "update Entrega set status_entrega = @Status, data_entrega = @DataEnt WHERE id_entrega = @Id";
            MySqlCommand command = new MySqlCommand(update, conexao);
            
            command.Parameters.AddWithValue("@Id", entrega_db[index].IdEntrega);
            command.Parameters.AddWithValue("@Status", statusEntrega);
            command.Parameters.AddWithValue("@DataEnt", dataEntrega);

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0) 
            {
                entrega_db[index].StatusEntrega = statusEntrega;
                entrega_db[index].DataEntrega = dataEntrega;
            } 
            else 
            {
                Console.WriteLine("Não deu pra alterar a entrega.");
            }   
            CloseConnection();
        }
        
        public static void Deletar(int index)
        {
            InitConnection();
            string delete = "delete from Entrega where id_entrega = @Id";

            MySqlCommand command = new MySqlCommand(delete, conexao);
            command.Parameters.AddWithValue("@Id", entrega_db[index].IdEntrega);

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                entrega_db.RemoveAt(index);
            } 
            else 
            {
                Console.WriteLine("Não foi possível deletar a entrega.");
            }

            CloseConnection();
        }
        
        public static void CloseConnection()
        {
            conexao.Close();
        } 
    }
}