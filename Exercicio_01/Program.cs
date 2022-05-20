using GFT_Start_Poo.Exercicio_001;


Veiculo veiculo = new Veiculo();

string cor = "Azul";
veiculo.Pintar(cor);
Console.WriteLine("A cor é: " + veiculo.Cor);

int combustivel = 55;
veiculo.Abastecer(combustivel);
Console.WriteLine("O carro está com: " + veiculo.LitrosCombustivel + " Litros de combustível.");

veiculo.Ligar();
Console.WriteLine("O carro está ligado.");

veiculo.Acelerar();
Console.WriteLine("O carro está com: " + veiculo.Velocidade + " KM/H.");
veiculo.Acelerar();
Console.WriteLine("O carro está com: " + veiculo.Velocidade + " KM/H.");

veiculo.Frear();
Console.WriteLine("O carro está com: " + veiculo.Velocidade + " KM/H.");
veiculo.Frear();
Console.WriteLine("O carro está com: " + veiculo.Velocidade + " KM/H.");

veiculo.Desligar();
