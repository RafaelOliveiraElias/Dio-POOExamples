using exemploPOO.Models;

Retangulo r = new Retangulo();
r.DefinirMedidas(30, 30);
System.Console.WriteLine($"Área: {r.ObterArea()}");



System.Console.WriteLine("-------------------------");
Pessoa nova = new Pessoa();

nova.Nome = "Bob";
nova.Idade = 20;

nova.Apresentar();
