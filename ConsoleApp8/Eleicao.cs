
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Eleicao
    {
        private string tipo_eleicao;
        private string ambito_eleicao;
        private List<Candidato> candidatos = new List<Candidato>();
        private List<Voto> votos = new List<Voto>();

        public Eleicao(string tipo_eleicao, string ambito_eleicao)
        {
            this.tipo_eleicao = tipo_eleicao;
            this.ambito_eleicao = ambito_eleicao;
        }

        public string Tipo_eleicao { get => tipo_eleicao; set => tipo_eleicao = value; }
        public string Ambito_eleicao { get => ambito_eleicao; set => ambito_eleicao = value; }
        internal List<Candidato> Candidatos { get => candidatos; set => candidatos = value; }
        internal List<Voto> Votos { get => votos; set => votos = value; }
    }
}
