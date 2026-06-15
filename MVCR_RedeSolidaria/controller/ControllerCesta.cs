namespace std;

    public static class ControllerCesta {
        public static void Sincronizar()
        {
            RepoCesta.Sincronizar();
        }

       public static void Criar(int idMercado, string descricao, int quantidadeItens) {
        Cesta cesta = new Cesta(idMercado, descricao, quantidadeItens, DateTime.Now, "DISPONIVEL");
        RepoCesta.Criar(cesta);

        Pontuacao novaPontuacao = new Pontuacao();
        novaPontuacao.IdMercado = idMercado;     // Preenche o ID do mercado
        novaPontuacao.Pontos = 10;                // Define que vai ganhar 10 pontos
        novaPontuacao.DataPontuacao = DateTime.Now; // Coloca a data de agora, é o que faz .Now

        RepoPontuacao.Criar(novaPontuacao);
      }

        public static List<Cesta> Listar()
        {
            return RepoCesta.Listar();
        }

        public static void Alterar(int index, string descricao, int qtdItens)
        {
            RepoCesta.Alterar(index, descricao, qtdItens);
        }

        public static void Deletar(int index)
        {
            RepoCesta.Deletar(index);
        }
    }