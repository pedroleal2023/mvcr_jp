namespace std;

    public static class ControllerEntrega {
        public static void Sincronizar()
        {
            RepoEntrega.Sincronizar();
        }

        public static void Criar(int idCesta, int idBeneficiario)
        {
            DateTime dataEntregaPadrao = new DateTime(2020, 1, 1);
            Entrega entrega = new Entrega(idCesta, idBeneficiario, DateTime.Now, dataEntregaPadrao, "PENDENTE");
            RepoEntrega.Criar(entrega);
        }

        public static List<Entrega> Listar()
        {
            return RepoEntrega.Listar();
        }

        public static void Alterar(int index, string statusEntrega, DateTime dataEntrega)
        {
            RepoEntrega.Alterar(index, statusEntrega, dataEntrega);
        }

        public static void Deletar(int index)
        {
            RepoEntrega.Deletar(index);
        }
    }
