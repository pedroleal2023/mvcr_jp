namespace std;

    public static class ControllerCesta
    {
        public static void Sincronizar()
        {
            RepoCesta.Sincronizar();
        }

        public static void Criar(int idMercado, string descricao, int quantidadeItens)
        {
            Cesta cesta = new Cesta(idMercado, descricao, quantidadeItens, DateTime.Now, "DISPONIVEL");
            RepoCesta.Criar(cesta);
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
