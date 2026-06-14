namespace std
{
    public static class ControllerMercado
    {
        public static void Sincronizar()
        {
            RepoMercado.Sincronizar();
        }

        public static void Criar(string nomeFantasia, string cnpj, string telefone, string email, string senha, string endereco)
        {
            Mercado mercado = new Mercado(nomeFantasia, cnpj, telefone, email, senha, endereco, DateTime.Now, true);
            RepoMercado.Criar(mercado);
        }

        public static List<Mercado> Listar()
        {
            return RepoMercado.Listar();
        }

        public static void Alterar(int index, string nome, string telefone, string endereco)
        {
            RepoMercado.Alterar(index, nome, telefone, endereco);
        }

        public static void Deletar(int index)
        {
            RepoMercado.Deletar(index);
        }
    }
}