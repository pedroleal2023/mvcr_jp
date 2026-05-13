namespace program;

public class CachorroView {

 public static void Criar () {
    Console.WriteLine("- Cadastrando seu PET! - ");
    Console.WriteLine("Digite o nome completo do dono do PET: ");
    string nomeDono = Console.ReadLine();
    Console.WriteLine("Digite o nome do PET: ");
    string nome = Console.ReadLine();
    Console.WriteLine("Digite a raça do PET: ");
    string raça = Console.ReadLine();
    Console.WriteLine("Digite o peso do PET: ");
    double peso = Convert.ToDouble(Console.ReadLine());

    CachorroController.Criar(nomeDono, nome, raça, peso);
 }

 public static void Alterar () {
  Console.WriteLine("- Alterando os dados -");
  Console.WriteLine("Informe o Indice do pet para alterar: ");
  int index = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Digite o nome completo do dono do PET: ");
  string nomeDono = Console.ReadLine();
  Console.WriteLine("Digite o nome do PET: ");
  string nome = Console.ReadLine();
  Console.WriteLine("Digite a raça do PET: ");
  string raça = Console.ReadLine();
  Console.WriteLine("Digite o peso do PET: ");
  double peso = Convert.ToDouble(Console.ReadLine());

    CachorroController.Alterar(index, nomeDono, nome, raça, peso);
 }

 public static void Deletar(){
  Console.WriteLine("- Deletar o cadastro -");
  Console.WriteLine("Informe o indice do pet para apaga seu cadastro: ");
  int index = Convert.ToInt32(Console.ReadLine());  

  CachorroController.Deletar(index);
 }

 public static void Listar(){

  List<Cachorro> cachorros = CachorroController.Listar();

  foreach (Cachorro cachorro in cachorros){
    Console.WriteLine($"Nome do Dono: {cachorro.NomeDono} / Nome do Pet: {cachorro.Nome} / Raça: {cachorro.Raça} / Peso Atual: {cachorro.Peso}Kg.");
  }
 }
}