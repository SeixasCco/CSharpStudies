using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploexplorando.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        private string _nome;
        private int _idade;
        public string Nome
        {
            get
            {
                return _nome.ToUpper();
            }

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }

        public string NomeCompleto => $"{Nome} {Sobrenome} ".ToUpper();

        public string Sobrenome {get; set;}

        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }

                _idade = value;
            }

        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá meu Nome é {NomeCompleto}e tenho {Idade} anos!");
        }
    }
}
