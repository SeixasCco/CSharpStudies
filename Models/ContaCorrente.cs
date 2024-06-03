using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploexplorando.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }

        private readonly decimal saldo;

        public void Sacar(decimal Valor)
        {
            if (saldo >= valor)
            {
                saldo -= Valor;
                Console.WriteLine("Saque realizado com sucesso");
            }
            else
            {
                Console.WriteLine("Valor desejado é maior que o saldo disponivel");
            }
        }

        public void ExibirSaldo()
        {
            Console.write("Seu saldo disponivel é: " + saldo);
        }

    }
}
