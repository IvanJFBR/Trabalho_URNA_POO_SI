using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Voto
    {
        private string    tipo_voto;
        private Candidato candidato;
        private Eleitor   eleitor;

        public string Tipo_voto { get => tipo_voto;}
        public Candidato Candidato { get => candidato;}
        public Eleitor Eleitor { get => eleitor;}

        public Voto(string tipo_voto, Candidato candidato, Eleitor eleitor)
        {
            this.tipo_voto = tipo_voto;
            this.candidato = candidato;
            this.eleitor = eleitor;
        }

        public Voto(Eleitor eleitor)
        {
            this.tipo_voto = null;
            this.candidato = null;
            this.eleitor = eleitor;
        }
    }
}
