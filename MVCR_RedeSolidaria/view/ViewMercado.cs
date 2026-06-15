namespace std;

    public class ViewMercado
    {
        public static void Sincronizar()
        {
            ControllerMercado.Sincronizar();
        }

        public static void Criar()
        {
            Console.WriteLine("Digite o Nome Fantasia do mercado:");
            string nomeFantasia = Console.ReadLine();

            Console.WriteLine("Digite o CNPJ do mercado:");
            string cnpj = Console.ReadLine();

            Console.WriteLine("Digite o telefone do mercado:");
            string telefone = Console.ReadLine();

            Console.WriteLine("Digite o e-mail do mercado:");
            string email = Console.ReadLine();

            Console.WriteLine("Digite a senha do mercado:");
            string senha = Console.ReadLine();

            Console.WriteLine("Digite o endereço completo do mercado:");
            string endereco = Console.ReadLine();

         ControllerMercado.Criar(nomeFantasia, cnpj, telefone, email, senha, endereco);
        }

        public static void Alterar()
        {
            Console.WriteLine("Digite o índice do mercado a ser alterado:");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o novo Nome Fantasia para alterar:");
            string nomeFantasia = Console.ReadLine();

            Console.WriteLine("Digite o novo telefone para alterar:");
            string telefone = Console.ReadLine();

            Console.WriteLine("Digite o novo endereço para alterar:");
            string endereco = Console.ReadLine();

            ControllerMercado.Alterar(index, nomeFantasia, telefone, endereco);
        }

        public static void Deletar()
        {
            Console.WriteLine("Digite o índice do mercado a ser deletado:");
            int index = int.Parse(Console.ReadLine());

            ControllerMercado.Deletar(index);
        }

        public static void Listar()
        {
            foreach (Mercado mercado in ControllerMercado.Listar())
            {
               Console.WriteLine($"Nome: {mercado.NomeFantasia} - CNPJ: {mercado.Cnpj} - Tel: {mercado.Telefone} - Endereço: {mercado.Endereco}");
            }
        }
    }
