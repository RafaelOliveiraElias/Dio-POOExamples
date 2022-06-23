using exemploPOO.Models;

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
