using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Eleitor : Pessoa
    {
        public Eleitor(string nome, string cpf, string titulo_eleitor)
            : base (nome,cpf,titulo_eleitor){}

        public override void retorna_pessoa()
        {
            Console.WriteLine(
            "Nome: " + nome +
            "\nCPF: " + cpf +
            "\nTitulo de Eleitor: " + titulo_eleitor);
        }
    }
}
