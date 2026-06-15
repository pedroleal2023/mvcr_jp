namespace std;

    public class ViewBeneficiario
    {
        public static void Sincronizar()
        {
            ControllerBeneficiario.Sincronizar();
        }
        public static void Criar()
        {
            Console.WriteLine("Digite o nome do beneficiário:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o e-mail do beneficiário:");
            string email = Console.ReadLine();

            Console.WriteLine("Digite a senha do beneficiário:");
            string senha = Console.ReadLine();

            Console.WriteLine("Digite o CPF do beneficiário:");
            string cpf = Console.ReadLine();

            Console.WriteLine("Digite o NIS(CadÚnico) do beneficiário:");
            string nis = Console.ReadLine(); 
            
            Console.WriteLine("Digite o telefone do beneficiário:");
            string telefone = Console.ReadLine();

            Console.WriteLine("Digite o endereço completo do beneficiário:");
            string endereco = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de moradores na residência:");
            int quantidadeMoradores = int.Parse(Console.ReadLine());

            ControllerBeneficiario.Criar(nome, email, senha, cpf, nis, telefone, endereco, quantidadeMoradores);
        }

        public static void Alterar()
        {
            Console.WriteLine("Digite o índice do beneficiário a ser alterado:");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o novo nome para alterar:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o novo telefone para alterar:");
            string telefone = Console.ReadLine();

            Console.WriteLine("Digite o novo endereço para alterar:");
            string endereco = Console.ReadLine();

            Console.WriteLine("Digite a nova quantidade de moradores:");
            int qtdMoradores = int.Parse(Console.ReadLine());

            ControllerBeneficiario.Alterar(index, nome, telefone, endereco, qtdMoradores);
        }

        public static void Deletar()
        {
            Console.WriteLine("Digite o índice do beneficiário a ser deletado:");
            int index = int.Parse(Console.ReadLine());

            ControllerBeneficiario.Deletar(index);
        }

        public static void Listar()
        {
            foreach (Beneficiario beneficiario in ControllerBeneficiario.Listar())
            {
              string statusTexto = "";

                if (beneficiario.StatusCadUnico == true) {
                    statusTexto = "Ativo";
                }
                else {
                    statusTexto = "Inativo";
                }
                Console.WriteLine($"Nome: {beneficiario.Nome} - CPF: {beneficiario.Cpf} - Tel: {beneficiario.Telefone} - NIS: {beneficiario.Nis} - CadÚnico: {statusTexto}");
        }
      }
    }
