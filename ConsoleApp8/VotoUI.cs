using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class VotoUI
    {
        private string tipo_voto;
        private int numero_candidato;
        private string cpf_eleitor;
        private string partido;

        public string Tipo_voto { get => tipo_voto; set => tipo_voto = value; }
        public int Numero_candidato { get => numero_candidato; set => numero_candidato = value; }
        public string Cpf_eleitor { get => cpf_eleitor; set => cpf_eleitor = value; }
        public string Partido { get => partido; set => partido = value; }
    }
}
