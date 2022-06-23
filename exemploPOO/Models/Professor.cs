using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploPOO.Models
{
    public class Professor : Pessoa
    {
        public int Salario { get; set; }
        public override void Apresentar()
        {
            System.Console.WriteLine($"Olá meu nome é {this.Nome}, tenho {this.Idade} anos e sou um Professor@");
        }
    }
}