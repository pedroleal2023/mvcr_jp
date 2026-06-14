
namespace std;
    public class Mercado
    {
        public int IdMercado { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Endereco { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool StatusMercado { get; set; }

        // Construtor vazio necessário para o método Sincronizar
        public Mercado() { }

        // Construtor completo seguindo a risca o padrão do professor com 'this.'
        public Mercado(string NomeFantasia, string Cnpj, string Telefone, string Email, string Senha, string Endereco, DateTime DataCadastro, bool StatusMercado)
        {
            this.NomeFantasia = NomeFantasia;
            this.Cnpj = Cnpj;
            this.Telefone = Telefone;
            this.Email = Email;
            this.Senha = Senha;
            this.Endereco = Endereco;
            this.DataCadastro = DataCadastro;
            this.StatusMercado = StatusMercado;
        }
    }
