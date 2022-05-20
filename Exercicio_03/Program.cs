using System.Collections.Generic;
using Exercicio_03.src.Entities;

Mago m1 = new Mago("Mago1", 100, 100, 25,60,10,8);
Guerreiro g1 = new Guerreiro("Guerreiro1", 100, 100, 30, 60, 60, 10);
Mago m2 = new Mago("Mago1", 100, 100, 25,60,10,8);
Guerreiro g2 = new Guerreiro("Guerreiro1", 100, 100, 30, 60, 60, 10);

m1.LvlUp();
m2.LvlUp();
g1.LvlUp();
g2.LvlUp();

m1.Attack();
m2.Attack();
g1.Attack();
g2.Attack();

m1.AprenderMagia("Magia para ficar invisível");
g1.AprenderHabilidade("Habilidade de ficar invisível");



