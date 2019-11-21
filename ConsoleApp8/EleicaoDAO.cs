using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class EleicaoDAO : IEleicao
    {
        public void cadastrarCandidato(Eleicao eleicao, Candidato candidato)
        {
            eleicao.Candidatos.Add(candidato);
        }

        public Eleicao criarEleicao(string tipo_eleicao, string ambito_eleicao)
        {
            return new Eleicao(tipo_eleicao, ambito_eleicao);
        }

        public void votar(Eleicao eleicao, Eleitor eleitor, int numeroCandidato)
        {
            foreach (var candidato in eleicao.Candidatos)
            {
                if (candidato.Numero_candidato == numeroCandidato)
                {
                    eleicao.Votos.Add(new Voto("valido", candidato, eleitor));
                    break;
                }
            }
        }
    }
}
