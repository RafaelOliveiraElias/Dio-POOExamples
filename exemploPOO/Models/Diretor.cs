using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploPOO.Models
{
    public class Diretor : Professor
    {
        public sealed override void Apresentar()
        {
            System.Console.WriteLine($"Olá meu nome é {this.Nome}, tenho {this.Idade} anos e sou um Diret@r");
        }
    }
}