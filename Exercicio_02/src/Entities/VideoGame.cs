namespace Exercicio_02.src.Entities
{
    public class VideoGame : Produto
    {

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool IsUsado { get; set; }

        public VideoGame(string marca, string modelo, bool isUsado, string nome, double preco, int qtd) : base(nome, preco, qtd)
        {
            Marca = marca;
            Modelo = modelo;
            IsUsado = isUsado;
        }

        public override double CalculaImposto()
        {
            return 1;
        }
    }
}