using System;

namespace std
{
    public class Program {
        public static void Main()
        {
            ViewMercado.Sincronizar();
            ViewBeneficiario.Sincronizar();
            ViewCesta.Sincronizar();
            ViewEntrega.Sincronizar();
            ViewPontuacao.Sincronizar();
            ViewMovimentacao.Sincronizar();

            int op = 0;

            do {
                Console.WriteLine("\n=== SISTEMA REDE SOLIDÁRIA ===");
                Console.WriteLine("Escolha o seu perfil de acesso:");
                Console.WriteLine("[1] - Sou um Mercado Parceiro!");
                Console.WriteLine("[2] - Sou um Beneficiário!");
                Console.WriteLine("[3] - Administrativo / Relatórios");
                Console.WriteLine("[4] - Encerrar o programa...");
                Console.Write("Opção: ");
                op = int.Parse(Console.ReadLine());

                switch(op) {
                    case 1:
                        int op_mercado = 0;
                        do {
                            Console.WriteLine("\n--- PAINEL DO MERCADO PARCEIRO ---");
                            Console.WriteLine("[1] - Cadastrar Mercado");
                            Console.WriteLine("[2] - Cadastrar Nova Cesta");
                            Console.WriteLine("[3] - Listar Cestas");
                            Console.WriteLine("[4] - Voltar ao Menu Anterior");
                            Console.Write("Opção: ");
                            op_mercado = int.Parse(Console.ReadLine());

                            switch (op_mercado) {
                                case 1:
                                    ViewMercado.Criar();
                                    break;
                                case 2:
                                    ViewCesta.Criar();
                                    break;
                                case 3:
                                    ViewCesta.Listar();
                                    break;
                                case 4:
                                    Console.WriteLine("Voltando ao Menu Principal...");
                                    break;
                                default:
                                    Console.WriteLine("Digite uma opção válida!");
                                    break;
                            }
                        } while (op_mercado != 4);
                        break;

                    case 2:
                        int op_beneficiario = 0;
                        do {
                            Console.WriteLine("\n--- PAINEL DO BENEFICIÁRIO ---");
                            Console.WriteLine("[1] - Realizar Meu Cadastro");
                            Console.WriteLine("[2] - Solicitar Cesta Básica");
                            Console.WriteLine("[3] - Confirmar que Recebi a Cesta"); 
                            Console.WriteLine("[4] - Voltar ao Menu Anterior");
                            
                            op_beneficiario = int.Parse(Console.ReadLine());

                            switch (op_beneficiario) {
                                case 1:
                                    ViewBeneficiario.Criar();
                                    break;
                                case 2:
                                    ViewEntrega.Criar();
                                    break;
                                case 3:
                                    ViewEntrega.Alterar();
                                    break;
                                case 4:
                                    Console.WriteLine("Voltando ao Menu Principal...");
                                    break;
                                default:
                                    Console.WriteLine("Digite uma opção válida!");
                                    break;
                            }
                        } while (op_beneficiario != 4);
                        break;

                    case 3:
                        int op_admin = 0;
                        do {
                            Console.WriteLine("\n--- PAINEL ADMINISTRATIVO ---");
                            Console.WriteLine("[1] - Listar Mercados");
                            Console.WriteLine("[2] - Alterar Mercado");
                            Console.WriteLine("[3] - Deletar Mercado");
                            Console.WriteLine("[4] - Listar Beneficiários");
                            Console.WriteLine("[5] - Confirmar/Alterar Entrega");
                            Console.WriteLine("[6] - Ver Histórico de Solicitações");
                            Console.WriteLine("[7] - Ver Ranking de Solidariedade");
                            Console.WriteLine("[8] - Voltar ao Menu Anterior");
                            op_admin = int.Parse(Console.ReadLine());

                            switch (op_admin) {
                                case 1:
                                    ViewMercado.Listar();
                                    break;
                                case 2:
                                    ViewMercado.Alterar();
                                    break;
                                case 3:
                                    ViewMercado.Deletar();
                                    break;
                                case 4:
                                    ViewBeneficiario.Listar();
                                    break;
                                case 5:
                                    ViewEntrega.Alterar();
                                    break;
                                case 6:
                                    ViewMovimentacao.Listar();
                                    break;
                                case 7:
                                    ViewPontuacao.ExibirRanking();
                                    break;
                                case 8:
                                    Console.WriteLine("Voltando ao Menu Principal.");
                                    break;
                                default:
                                    Console.WriteLine("Digite uma opção válida!");
                                    break;
                            }
                        } while (op_admin != 8);
                        break;

                    case 4:
                        Console.WriteLine("Encerrando o programa.");
                        break;

                    default:
                        Console.WriteLine("Digite uma opção válida!");
                        break;
                }
            } while(op != 4); 
        }
    }
}