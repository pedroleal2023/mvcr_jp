namespace std;

    public static class ControllerPontuacao
    {
        public static void Sincronizar()
        {
            RepoPontuacao.Sincronizar();
        }

        public static void Criar(int idMercado, int pontos)
        {
            Pontuacao pontuacao = new Pontuacao(idMercado, pontos, DateTime.Now);
            RepoPontuacao.Criar(pontuacao);
        }

        public static List<Pontuacao> Listar()
        {
            return RepoPontuacao.Listar();
        }
    }
