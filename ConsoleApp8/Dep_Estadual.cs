using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Dep_Estadual : IEleicao
    {
        ArrayList<Candidato> candidatos = new ArrayList<Candidato>();
        ArrayList<Voto> votos = new ArrayList<Voto>();
        private int digitos;
        public Dep_Estadual(int digitos)
        {
            this.digitos = digitos;
        }
        void criaCandidato(Candidato candidato)
        {
            this.candidatos.Add(candidato);
        }
        Candidato retornaCandidatos()
        {
            return this.candidatos;
        }
        void votar(Voto voto)
        {
            foreach (var candidato in this.candidatos)
            {
                if (candidato.Numero_candidato == numero_candidato) {
                    this.votos.Add(new Voto("valido", candidato, eleitor));
                } else if(numero_candidato == 0) {
                    this.votos.Add(new Voto("branco", null, eleitor));
                } else {
                    this.votos.Add(new Voto("nulo", null, eleitor));
                }
            }
        }
        Voto retornaVotos()
        {
            return this.votos;
        }
    }
}
