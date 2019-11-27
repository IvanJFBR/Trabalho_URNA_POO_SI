using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Candidato : Pessoa
    {
        private Partido partido;
        private int numero_candidato;
        
        public Candidato(
            Partido partido,
            int numero_candidato,
            string nome,
            string cpf, 
            string titulo_eleitor
        ) : base(nome,cpf,titulo_eleitor)
        {           
            this.partido = partido;
            this.numero_candidato = numero_candidato;
        }

        public Partido Partido { get => partido;}
        public int Numero_candidato { get => numero_candidato;}

        public override void retorna_pessoa()
        {
            Console.WriteLine(
            "Nome: " + nome +
            "\nCPF: " + cpf +
            "\nTitulo de Eleitor: " + titulo_eleitor + 
            "\nNúmero Candidato: " + numero_candidato +
            "\nPartido: " + partido.Nome + "(" + partido.Sigla + ")" +
            " Número: " + partido.Numero);
        }
    }
}
