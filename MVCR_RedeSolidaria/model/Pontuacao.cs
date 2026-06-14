namespace std;

    public class Pontuacao
    {
        public int IdPontuacao { get; set; }
        public int IdMercado { get; set; } // Chave estrangeira que liga ao Mercado que pontuou
        public int Pontos { get; set; }
        public DateTime DataPontuacao { get; set; }

        public Pontuacao() { }

        public Pontuacao(int IdMercado, int Pontos, DateTime DataPontuacao)
        {
            this.IdMercado = IdMercado;
            this.Pontos = Pontos;
            this.DataPontuacao = DataPontuacao;
        }
    }
