namespace Exercicio_07.src.Entities
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, int idade, double salario)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
        }

        public virtual double Bonificacao(double salario){
            return salario;
        }

        public override string ToString(){
            return " Nome: " + Nome + " Idade: " + Idade  + " Salário: " + " " + Salario; 
        }

    
    }
}