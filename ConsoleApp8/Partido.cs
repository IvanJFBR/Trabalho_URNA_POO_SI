using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Partido
    {
        private string nome;
        private string sigla;
        private int numero;

        public Partido(string nome, string sigla, int numero)
        {
            this.nome = nome;
            this.sigla = sigla;
            this.numero = numero;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Sigla { get => sigla; set => sigla = value; }
        public int Numero { get => numero; set => numero = value; }
    }
}
