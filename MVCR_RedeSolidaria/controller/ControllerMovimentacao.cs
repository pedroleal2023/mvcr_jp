namespace std;
    public static class ControllerMovimentacao
    {
        public static void Sincronizar()
        {
            RepoMovimentacao.Sincronizar();
        }

        public static void Criar(int idBeneficiario, int idMercado, int idCesta, string tipoMovimentacao, string descricao)
        {
            Movimentacao movimentacao = new Movimentacao(idBeneficiario, idMercado, idCesta, tipoMovimentacao, descricao, DateTime.Now);
            RepoMovimentacao.Criar(movimentacao);
        }

        public static List<Movimentacao> Listar()
        {
            return RepoMovimentacao.Listar();
        }
    }
