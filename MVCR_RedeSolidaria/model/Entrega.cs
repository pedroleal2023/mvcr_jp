namespace std;

    public class Entrega
    {
        public int IdEntrega { get; set; }
        public int IdCesta { get; set; }        // Chave estrangeira
        public int IdBeneficiario { get; set; } // Chave estrangeira
        public DateTime DataSolicitacao { get; set; }
        public DateTime DataEntrega { get; set; }
        public string StatusEntrega { get; set; } // Armazena 'PENDENTE', 'APROVADA', etc.
    
    public Entrega() {}
        public Entrega(int IdCesta, int IdBeneficiario, DateTime DataSolicitacao, DateTime DataEntrega, string StatusEntrega)
        {
            this.IdCesta = IdCesta;
            this.IdBeneficiario = IdBeneficiario;
            this.DataSolicitacao = DataSolicitacao;
            this.DataEntrega = DataEntrega;
            this.StatusEntrega = StatusEntrega;
        }    
    }
