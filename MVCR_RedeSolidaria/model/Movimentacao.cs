
namespace std;
    public class Movimentacao
    {
        public int IdMovimentacao { get; set; }
        public int IdBeneficiario { get; set; } // Chave estrangeira
        public int IdMercado { get; set; }      // Chave estrangeira
        public int IdCesta { get; set; }        // Chave estrangeira
        public string TipoMovimentacao { get; set; } // 'CADASTRO_CESTA', 'SOLICITACAO', etc.
        public string Descricao { get; set; }
        public DateTime DataMovimentacao { get; set; }

        public Movimentacao() { }

        public Movimentacao(int IdBeneficiario, int IdMercado, int IdCesta, string TipoMovimentacao, string Descricao, DateTime DataMovimentacao)
        {
            this.IdBeneficiario = IdBeneficiario;
            this.IdMercado = IdMercado;
            this.IdCesta = IdCesta;
            this.TipoMovimentacao = TipoMovimentacao;
            this.Descricao = Descricao;
            this.DataMovimentacao = DataMovimentacao;
        }
    }
