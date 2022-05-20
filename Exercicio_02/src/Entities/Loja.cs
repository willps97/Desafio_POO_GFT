using System.Collections.Generic;

namespace Exercicio_02.src.Entities
{
    public class Loja
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public Livro Livros { get; set; }
        public VideoGame VideoGames { get; set; }

        

        public Loja(string nome, string cnpj, Livro livros ,VideoGame videoGames)
        {
            Nome = nome;
            Cnpj = cnpj;
            Livros = livros;
            VideoGames = videoGames;
        }

        public void ListarLivros(){

            List<Livro> listLivros = new List<Livro>();
            listLivros.Add(new Livro("Flavio Augusto da Silva","Auto Ajuda", 300, "Geração de valor", 15.00, 200));
            listLivros.Add(new Livro("Flavio Augusto da Silva","Auto Ajuda", 250, "Geração de valor 2 ", 18.00, 100));

            foreach (var livro in listLivros)
            {
                System.Console.WriteLine(livro);
            }
        }

        public void ListarVideoGame(){

            List<VideoGame> listgames = new List<VideoGame>();
            listgames.Add(new VideoGame("Microsoft","Series X",false,"Xbox",5000.00, 2));
            listgames.Add(new VideoGame("Sony","5",false,"Play Station",4800.00, 2));
            
            foreach (var videoGames in listgames)
            {
                System.Console.WriteLine(videoGames);
            }
        }

       



        

        




    }
}