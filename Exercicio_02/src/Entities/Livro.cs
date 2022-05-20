namespace Exercicio_02.src.Entities
{
    public class Livro : Produto
    {
        public string Autor { get; set; }
        public string Tema { get; set; }
        public int QtdPag { get; set; }
        
        public Livro(string autor, string tema, int qtdPag,string nome, double preco, int qtd): base(nome, preco, qtd)
        {
            Autor = autor;
            Tema = tema;
            QtdPag = qtdPag;
        }

        public override double CalculaImposto(){
            return 0;
        }
        
        


    
    }
}