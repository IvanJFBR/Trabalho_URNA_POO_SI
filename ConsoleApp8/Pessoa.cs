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

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Titulo_eleitor { get => titulo_eleitor; set => titulo_eleitor = value; }

        public Pessoa(string nome, string cpf, string titulo_eleitor)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.titulo_eleitor = titulo_eleitor;
        }

        public abstract void retorna_pessoa();
    }
}
