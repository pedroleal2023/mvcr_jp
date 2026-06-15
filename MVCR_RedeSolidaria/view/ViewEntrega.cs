namespace std;
    public class ViewEntrega
    {
        public static void Sincronizar()
        {
            ControllerEntrega.Sincronizar();
        }

        public static void Criar()
        {
            Console.WriteLine("Digite o índice da Cesta:");
            int indexCesta = int.Parse(Console.ReadLine());

            Cesta cestaSelecionada = ControllerCesta.Listar()[indexCesta];
            int idCesta = cestaSelecionada.IdCesta;

            Console.WriteLine("Digite o índice do beneficiário na lista:");
            int indexBeneficiario = int.Parse(Console.ReadLine());

            Beneficiario beneficiarioSelecionado = ControllerBeneficiario.Listar()[indexBeneficiario];
            int idBeneficiario = beneficiarioSelecionado.IdBeneficiario;

            ControllerEntrega.Criar(idCesta, idBeneficiario);
        }

        public static void Alterar()
        {
            Console.WriteLine("Digite o índice da entrega a ser alterada:");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o novo status da entrega (ex: ENTREGUE, CANCELADA):");
            string statusEntrega = Console.ReadLine();

            ControllerEntrega.Alterar(index, statusEntrega, DateTime.Now);
        }

        public static void Deletar()
        {
            Console.WriteLine("Digite o índice da entrega a ser deletada:");
            int index = int.Parse(Console.ReadLine());

            ControllerEntrega.Deletar(index);
        }

        public static void Listar()
        {
            foreach (Entrega entrega in ControllerEntrega.Listar())
            {
                Console.WriteLine($"ID da Entrega: {entrega.IdEntrega} - ID da Cesta: {entrega.IdCesta} - ID do(a) Beneficiário(a): {entrega.IdBeneficiario} - Status: {entrega.StatusEntrega}");
            }
        }
    }
