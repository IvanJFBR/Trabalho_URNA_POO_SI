using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    abstract class Pessoa
    {
        protected string nome;
        protected string cpf;
        protected string titulo_eleitor;

        public Pessoa(string nome, string cpf, string titulo_eleitor)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.titulo_eleitor = titulo_eleitor;
        }

        public abstract void retorna_pessoa();
    }
}
