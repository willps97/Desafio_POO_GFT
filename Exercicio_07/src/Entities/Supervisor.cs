namespace Exercicio_07.src.Entities
{
    public class Supervisor:Funcionario
    {
        public Supervisor(string nome, int idade, double salario): base(nome, idade, salario)
        {
           
        }

        public  void Bonificacao(){
            Salario = Salario + 5000.00;

        }

        public override string ToString(){
            return " Nome: " + Nome + " Idade: " + Idade  + " Salário: " + " " + Salario; 
        }
    }
}