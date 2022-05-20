namespace Exercicio_03.src.Entities
{
    public class Mago: Personagem
    {
        private static int totalDeMagos = 0;
        
        public Mago(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) : base(nome, vida, mana, xp, inteligencia,forca,level)
        {
            
            Mago.totalDeMagos++;
            
        }

        public  override void LvlUp(){

            Mana = Mana + 10;
            Inteligencia = Inteligencia + 15;
            Console.WriteLine("A mana aumentou para " + Mana +" E a inteligência para " + Inteligencia);
        }

        public void Attack(){
            Random random = new Random();
            int magoAttack = random.Next(0, 300);

            int attack = (Inteligencia * Level) + magoAttack;

            Console.WriteLine("O ataque do:  " + this.Nome + "foi de: "+ attack + "pontos. ");
        }

        public string AprenderMagia(string magia){

            return magia +" será aprendida!";
            
        }
    }
}