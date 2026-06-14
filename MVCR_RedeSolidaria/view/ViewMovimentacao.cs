namespace std;
   public class ViewMovimentacao {
        public static void Sincronizar()
        {
            ControllerMovimentacao.Sincronizar();
        }

        public static void Criar()
        {
            Console.WriteLine("Digite o índice do beneficiário envolvido:");
            int indexBeneficiario = int.Parse(Console.ReadLine());

            Beneficiario beneficiarioSelecionado = ControllerBeneficiario.Listar()[indexBeneficiario];
            int idBeneficiario = beneficiarioSelecionado.IdBeneficiario;

            Console.WriteLine("Digite o índice do mercado envolvido:");
            int indexMercado = int.Parse(Console.ReadLine());

            Mercado mercadoSelecionado = ControllerMercado.Listar()[indexMercado];
            int idMercado = mercadoSelecionado.IdMercado;

            Console.WriteLine("Digite o índice da cesta envolvida:");
            int indexCesta = int.Parse(Console.ReadLine());

            Cesta cestaSelecionada = ControllerCesta.Listar()[indexCesta];
            int idCesta = cestaSelecionada.IdCesta;

            Console.WriteLine("Digite o tipo da movimentação (ex: CADASTRO_CESTA, RETIRADA):");
            string tipoMovimentacao = Console.ReadLine();

            Console.WriteLine("Digite uma breve descrição do que ocorreu:");
            string descricao = Console.ReadLine();

            ControllerMovimentacao.Criar(idBeneficiario, idMercado, idCesta, tipoMovimentacao, descricao);
        }

        public static void Listar()
        {
            foreach (Movimentacao movimentacao in ControllerMovimentacao.Listar())
            {
                Console.WriteLine($"ID Movimentação: {movimentacao.IdMovimentacao} | Tipo: {movimentacao.TipoMovimentacao} | Beneficiário: {movimentacao.IdBeneficiario} | Mercado: {movimentacao.IdMercado} | Cesta: {movimentacao.IdCesta} | Data: {movimentacao.DataMovimentacao}");
            }
        }
    }
