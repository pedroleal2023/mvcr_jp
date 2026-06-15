namespace std;

    public static class ControllerEntrega {
        public static void Sincronizar()
        {
            RepoEntrega.Sincronizar();
        }

        public static void Criar(int indexCesta, int indexBeneficiario)
        {
            Cesta cestaEscolhida = RepoCesta.Listar()[indexCesta];
            Beneficiario beneficiarioLogado = RepoBeneficiario.Listar()[indexBeneficiario];

           if (beneficiarioLogado.QuantidadeMoradores >= 5 && cestaEscolhida.QuantidadeItens < 15) {
                Console.WriteLine("\n[AVISO] Esta cesta tem poucos itens para o tamanho da sua família!");
                Console.WriteLine("Por favor, selecione uma cesta maior.");
                return;
            } else {
            DateTime dataEntregaPadrao = new DateTime(2020, 1, 1);
            Entrega entrega = new Entrega(cestaEscolhida.IdCesta, beneficiarioLogado.IdBeneficiario, DateTime.Now, dataEntregaPadrao, "PENDENTE");
            RepoEntrega.Criar(entrega);
            }
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
