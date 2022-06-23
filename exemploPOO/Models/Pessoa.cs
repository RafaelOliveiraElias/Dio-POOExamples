using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploPOO.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }

        public int Idade { get; set; }

        public void Apresentar()
        {
            System.Console.WriteLine($"Olá meu nome é {this.Nome}, tenho {this.Idade} anos");
        }

    }
}