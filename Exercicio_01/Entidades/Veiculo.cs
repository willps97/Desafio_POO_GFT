namespace GFT_Start_Poo.Exercicio_001
{
    public class Veiculo
    {
        public string Marca {get; set; }
        public string Modelo {get; set;}
        public string Placa {get; set;}
        public string Cor { get; set; }
        public float Km { get; set; }
        public bool IsLigado { get; set; }
        public int LitrosCombustivel { get; set; }
        public int Velocidade { get; set; }
        public double Preco { get; set; }

        public Veiculo( )
        {
             
        }


        public void Acelerar () 
        {
            Velocidade = Velocidade + 20;
        }

        public int Abastecer(int combustivel)
        {
            if(combustivel <= 60)
            {
                LitrosCombustivel = combustivel; 
            }
            else
            {
                Console.WriteLine("Capacidade máxima do tanque é de 60 litros!");
            }
            return LitrosCombustivel;
        }

        public void Frear()
        {
            if(Velocidade >= 0){

                Velocidade = Velocidade -20;
            }
            else{
                Console.WriteLine("Veículo em repouso!");
            }
        }

        public string Pintar(string cor){
            Cor = cor;
            return Cor;
        }

        public void Ligar(){
            if(IsLigado == false)
            {
                IsLigado = true;
            }
        }
        public void Desligar(){
            if(Velocidade == 0 && IsLigado == true){
                IsLigado = false;
                Console.WriteLine("O carro foi desligado.");
            }
            else{
                Console.WriteLine("O carro está em movimento!");
            }
        }

    }
}