using Exercicio_07.src.Entities;

Gerente g = new Gerente("Marcelo", 35, 7000.00);
Supervisor s = new Supervisor("Alcides", 30, 5000.00);
Vendedor v = new Vendedor("Ricardo", 25, 2000.00);

g.Bonificacao();
System.Console.WriteLine(g);

s.Bonificacao();
System.Console.WriteLine(s);

v.Bonificacao();
System.Console.WriteLine(v);