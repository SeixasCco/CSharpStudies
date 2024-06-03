using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cSharpstudies.Models
{
    public class Corrent : Conta
    {
        public override void Creditar (decimal valor)
        {
            saldo += valor;
        }

    }
}
