using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp8
{
    class EleicaoDAO : IEleicao
    {
        List<VotoUI> votos;

        public EleicaoDAO()
        {
            this.votos = new List<VotoUI>();
        }

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

        public void salvarVoto(Voto voto)
        {
            VotoUI votoXML = new VotoUI()
            {
                Tipo_voto = voto.Tipo_voto,
                Numero_candidato = voto.Candidato != null ? voto.Candidato.Numero_candidato : 0,
                Cpf_eleitor = voto.Eleitor.Cpf,
                Partido = voto.Candidato.Partido.Sigla
            };

            this.votos.Add(votoXML);

            XmlSerializer ser = new XmlSerializer(typeof(List<VotoUI>));
            FileStream fs = new FileStream("D://Temp/arquivo.xml", FileMode.OpenOrCreate);
            ser.Serialize(fs, this.votos);
            fs.Close();
        }
    }
}
