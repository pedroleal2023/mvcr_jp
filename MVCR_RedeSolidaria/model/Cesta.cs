namespace std;

public class Cesta
    {
        public int IdCesta { get; set; }
        public int IdMercado { get; set; } // Chave estrangeira que liga ao Mercado
        public string Descricao { get; set; }
        public int QuantidadeItens { get; set; }
        public DateTime DataDisponibilizacao { get; set; }
        public string StatusCesta { get; set; } // Armazena 'DISPONIVEL', 'RESERVADA', etc.
    
    public Cesta() { }
    public Cesta(int IdMercado, string Descricao, int QuantidadeItens, DateTime DataDisponibilizacao, string StatusCesta)
        {
            this.IdMercado = IdMercado;
            this.Descricao = Descricao;
            this.QuantidadeItens = QuantidadeItens;
            this.DataDisponibilizacao = DataDisponibilizacao;
            this.StatusCesta = StatusCesta;
        }
}
