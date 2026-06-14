namespace std;

    public class ViewPontuacao {
        public static void Sincronizar()
        {
            ControllerPontuacao.Sincronizar();
        }

        public static void Criar()
        {
            Console.WriteLine("Digite o índice do mercado que receberá a pontuação:");
            int indexMercado = int.Parse(Console.ReadLine());

            Mercado mercadoSelecionado = ControllerMercado.Listar()[indexMercado];
            int idMercado = mercadoSelecionado.IdMercado;

            Console.WriteLine("Digite a quantidade de pontos a atribuir:");
            int pontos = int.Parse(Console.ReadLine());

            ControllerPontuacao.Criar(idMercado, pontos);
        }

        public static void Listar()
        {
            foreach (Pontuacao pontuacao in ControllerPontuacao.Listar())
            {
                Console.WriteLine($"ID Pontuação: {pontuacao.IdPontuacao} - ID Mercado: {pontuacao.IdMercado} - Pontos: {pontuacao.Pontos} - Data: {pontuacao.DataPontuacao}");
            }
        }

       public static void ExibirRanking()
        {
            Console.WriteLine("\n--- RANKING DE SOLIDARIEDADE (MERCADOS) ---");

            List<Mercado> todosMercados = ControllerMercado.Listar();
            List<Pontuacao> todasPontuacoes = ControllerPontuacao.Listar();

          foreach (Mercado mercado in todosMercados) {
                int totalPontosDoMercado = 0;

                foreach (Pontuacao pontuacao in todasPontuacoes) {
                    if (pontuacao.IdMercado == mercado.IdMercado) {
                        totalPontosDoMercado += pontuacao.Pontos;
                    }
                }
                Console.WriteLine($"Mercado: {mercado.NomeFantasia} | Total de Pontos: {totalPontosDoMercado} pontos.");
            }
            Console.WriteLine("----------------------------------------------");
        }
    }

    
