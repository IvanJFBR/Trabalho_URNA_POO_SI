using System.Collections.Generic;

namespace ConsoleApp8
{
    internal interface IEleicao
    {
        void criaCandidato(Candidato candidato);

        List<Candidato> retornaCandidatos();

        void cadastrarVoto(Voto voto);

        List<Voto> retornaVotos();
    }
}