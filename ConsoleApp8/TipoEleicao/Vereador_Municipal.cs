using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Vereador_Municipal : IEleicao
    {
        private List<Candidato> candidatos = new List<Candidato>();
        private List<Voto> votos = new List<Voto>();
        private int digitos;

        public Vereador_Municipal(int digitos)
        {
            this.digitos = digitos;
        }

        public int Digitos { get => digitos; }

        void IEleicao.criaCandidato(Candidato candidato)
        {
            this.candidatos.Add(candidato);
        }

        List<Candidato> IEleicao.retornaCandidatos()
        {
            return this.candidatos;
        }

        void IEleicao.cadastrarVoto(Voto voto)
        {
            throw new NotImplementedException();
        }

        List<Voto> IEleicao.retornaVotos()
        {
            return this.votos;
        }
    }
}
