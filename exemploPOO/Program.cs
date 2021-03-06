using exemploPOO.Interfaces;
using exemploPOO.Models;

System.Console.WriteLine("-----------inteface:-----------");

ICalculadora calc = new Calculadora();
System.Console.WriteLine(calc.Somar(10, 20));


System.Console.WriteLine("-----------Classe Object:-----------");

Computador comp = new Computador();
System.Console.WriteLine(comp.ToString());


System.Console.WriteLine("-----------Classes abstratas:-----------");

Corrente c = new Corrente();
c.Creditar(100);

c.ExibirSaldo();

System.Console.WriteLine("-------HERANÇA e POLIFORMISMO:---------");

// Calculadora calc = new Calculadora();
// System.Console.WriteLine("resultado da primeira soma: " + calc.Somar(1, 2));
// System.Console.WriteLine("resultado da segunda soma: " + calc.Somar(1, 2, 5));

Aluno p2 = new Aluno();

p2.Nota = 8;

p2.Nome = "BobAluno";
p2.Idade = 15;

p2.Apresentar();



Professor p3 = new Professor();

p3.Salario = 3000;
p3.Nome = "BobProfessor";
p3.Idade = 35;

p3.Apresentar();



System.Console.WriteLine("-----------ENCAPSULAMENTO:--------------");

Retangulo r = new Retangulo();
r.DefinirMedidas(30, 30);
System.Console.WriteLine($"Área: {r.ObterArea()}");



System.Console.WriteLine("-----------ABSTRAÇÂO:--------------");
Pessoa nova = new Pessoa();

nova.Nome = "Bob";
nova.Idade = 20;

nova.Apresentar();
