using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Pessoa
    {
        private string nome;
        private int idade;

        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public int Idade { get => idade; set => idade = value; }
        public string Nome { get => nome; set => nome = value; }

        public override string ToString()
        {
            return $"Hello {Nome}, welcome!!!";
        }

        public void print() => Console.WriteLine("Hello World!");
    }
}
