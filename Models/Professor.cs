using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exemploexplorando.Models;

namespace cSharpstudies.Models
{
    public class  Professor : Pessoa
    {
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou um professor e ganho {Salario}");
        }
    }
}
