namespace std;
    public static class ControllerBeneficiario
    {
        public static void Sincronizar()
        {
            RepoBeneficiario.Sincronizar();
        }

        public static void Criar(string nome, string email, string senha, string cpf, string nis, string telefone, string endereco, int quantidadeMoradores)
        {
            bool statusCadUnico = (nis.Length == 11);
            Beneficiario beneficiario = new Beneficiario(nome, email, senha, cpf, nis, telefone, endereco, quantidadeMoradores, statusCadUnico, DateTime.Now);

            RepoBeneficiario.Criar(beneficiario);
        }

        public static List<Beneficiario> Listar()
        {
            return RepoBeneficiario.Listar();
        }

        public static void Alterar(int index, string nome, string telefone, string endereco, int qtdMoradores)
        {
            RepoBeneficiario.Alterar(index, nome, telefone, endereco, qtdMoradores);
        }

        public static void Deletar(int index)
        {
            RepoBeneficiario.Deletar(index);
        }
    }
