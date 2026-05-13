namespace Programa;

public class ControllerConta{

  public static void Criar (string nome, string cpf){
    new ContaCorrente(nome, cpf);
  }

  public static void Alterar (int index, string nome, string cpf){
    ContaCorrente.Alterar(index, nome, cpf);
  }
public static void Deletar(int index){
   ContaCorrente.Deletar(index);
  }
public static List <ContaCorrente> Listar(){
   return  ContaCorrente.Listar();
  }
}