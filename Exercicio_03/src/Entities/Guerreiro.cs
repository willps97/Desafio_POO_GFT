using System.Collections.Generic;

namespace Exercicio_03.src.Entities
{
    
    public class Guerreiro : Personagem
    {
        private static int totalDeGuerreiros = 0;
        
        public Guerreiro(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) : base(nome, vida, mana, xp, inteligencia,forca,level)
        {
            
            Guerreiro.totalDeGuerreiros++;
            
        }

        public override void LvlUp(){
            Forca = Forca + 10;
            Vida = Vida + 15;
            Console.WriteLine("A força aumentou para " + Forca +"E a vida para " + Vida);
        }
        public void Attack(){
            Random random = new Random();
            int guerreiroAttack = random.Next(0, 300);

            int attack = (Forca * Level) + guerreiroAttack;

            Console.WriteLine("O ataque do:  " + this.Nome + "foi de: "+ attack + "pontos. ");
        }

        public string AprenderHabilidade(string habilidade){
            
            return habilidade +" será aprendida!";
            
        }
    }
}