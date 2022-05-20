
namespace Exercicio_02.src.Entities
{
    public abstract class Produto:Iimposto
    {
        public string Nome  { get; set; }
        public double Preco { get;  set; }
        public int Qtd { get; set; }

      
        public Produto(string nome, double preco, int qtd)
        {
            Nome = nome;
            Preco = preco;
            Qtd = qtd;
        }

        public abstract double CalculaImposto();
    }
}