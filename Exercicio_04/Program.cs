using System.Collections.Generic;
using Exercicio_04.src.Entities;
using System.Linq;

List<Pessoa> listPessoa = new List<Pessoa>();

listPessoa.Add(new Pessoa("João", 15));
listPessoa.Add(new Pessoa("Leandro", 21));
listPessoa.Add(new Pessoa("Paulo", 17));
listPessoa.Add(new Pessoa("Jessica", 18));

var r1 = listPessoa.Max(p =>p.Idade);
System.Console.WriteLine("A idade a pessoa mais velha é: " + r1);





