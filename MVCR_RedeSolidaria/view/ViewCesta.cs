using System;

namespace std
{
    public class ViewCesta
    {
        public static void Sincronizar()
        {
            ControllerCesta.Sincronizar();
        }

        public static void Criar()
        {
            Console.WriteLine("Digite o índice do Mercado Doador:");
            int indexMercado = int.Parse(Console.ReadLine());

            Mercado mercadoSelecionado = ControllerMercado.Listar()[indexMercado];
            int idMercado = mercadoSelecionado.IdMercado;

            Console.WriteLine("Digite a descrição da Cesta:");
            string descricao = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de itens na Cesta [15 / 20 / 25]:");
            int quantidadeItens = int.Parse(Console.ReadLine());

            ControllerCesta.Criar(idMercado, descricao, quantidadeItens);
        }

        public static void Alterar()
        {
            Console.WriteLine("Digite o índice da Cesta a ser alterada:");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da Cesta:");
            string descricao = Console.ReadLine();

            Console.WriteLine("Digite a nova quantidade de itens:");
            int qtdItens = int.Parse(Console.ReadLine());

            ControllerCesta.Alterar(index, descricao, qtdItens);
        }

        public static void Deletar()
        {
            Console.WriteLine("Digite o índice da Cesta a ser deletada:");
            int index = int.Parse(Console.ReadLine());

            ControllerCesta.Deletar(index);
        }

        public static void Listar()
        {
            foreach (Cesta cesta in ControllerCesta.Listar())
            {
                Console.WriteLine($"ID Cesta: {cesta.IdCesta} - ID Mercado: {cesta.IdMercado} - Descrição: {cesta.Descricao} - Itens: {cesta.QuantidadeItens} - Status: {cesta.StatusCesta}");
            }
        }
    }
}