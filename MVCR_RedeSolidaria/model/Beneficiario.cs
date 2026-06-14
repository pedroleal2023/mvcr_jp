namespace std;
public class Beneficiario
{
  public int IdBeneficiario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }
        public string Nis { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public int QuantidadeMoradores { get; set; }
        public bool StatusCadUnico { get; set; }
        public DateTime DataCadastro { get; set; }
  
  public Beneficiario() { }

      
        public Beneficiario(string Nome, string Email, string Senha, string Cpf, string Nis, string Telefone, string Endereco, int QuantidadeMoradores, bool StatusCadUnico, DateTime DataCadastro)
        {
            this.Nome = Nome;
            this.Email = Email;
            this.Senha = Senha;
            this.Cpf = Cpf;
            this.Nis = Nis;
            this.Telefone = Telefone;
            this.Endereco = Endereco;
            this.QuantidadeMoradores = QuantidadeMoradores;
            this.StatusCadUnico = StatusCadUnico;
            this.DataCadastro = DataCadastro;
        }
}