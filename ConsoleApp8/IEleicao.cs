using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    interface IEleicao
    {
        Eleicao criarEleicao(string tipo_eleicao, string ambito_eleicao);

        void cadastrarCandidato(Eleicao eleicao, Candidato candidato);

        void votar(Eleicao eleicao, Eleitor eleitor, int numeroCandidato);
    }
}
