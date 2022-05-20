using Exercicio_07.src.Entities;

namespace Exercicio_07.src.Entities
{
    public class Gerente:Funcionario
    {
        public Gerente(string nome, int idade, double salario): base(nome, idade, salario)
        {
           
        }

        public  void Bonificacao(){
            Salario = Salario + 10000.00;

            
        }

        public override string ToString(){
            return " Nome: " + Nome + " Idade: " + Idade  + " Salário: " + " " + Salario; 
        }
    }
}