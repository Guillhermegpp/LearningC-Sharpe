using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Program
    {
       
        static void Main(string[] args)
        {

            Console.Write("Nome: \n");
            string k = Console.ReadLine();
            Console.Write("Idade: \n");
            int i = int.Parse(Console.ReadLine());

            Pessoa p = new Pessoa(k,i);
            Console.Write($"Nome: {p.Nome}\tIdade: {p.Idade}\n");
            Console.Write(p.ToString());
            Console.ReadKey();
        }
    }
}
