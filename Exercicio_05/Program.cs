using System.Collections.Generic;
using Exercicio_05.src.Entities;
using System.Linq;

Pessoa p1 = new Pessoa("João", 15);
Pessoa p2 = new Pessoa("Leandro", 21);
Pessoa p3 = new Pessoa("Paulo", 17);
Pessoa p4 = new Pessoa("Jéssica", 18);


List<Pessoa> listaDePessoas = new List<Pessoa>();
listaDePessoas.Add(p1);
listaDePessoas.Add(p2);
listaDePessoas.Add(p3);
listaDePessoas.Add(p4);



int qtdElementos = listaDePessoas.Count();
Console.WriteLine("A lista antes das exclusões possuem " + qtdElementos + " pessoas");

listaDePessoas.Remove(p1);
listaDePessoas.Remove(p3);

int qtdElementos2 = listaDePessoas.Count();
Console.WriteLine("A lista após as exclusões possuem " + qtdElementos2 + " pessoas");









