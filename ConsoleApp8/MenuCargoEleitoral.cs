using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp8
{
    public partial class MenuCargoEleitoral : Form
    {
        EleicaoDAO eleicaoController = new EleicaoDAO();

        MenuAmbitoVotacao ambitoVotacao;

        Deputado_Estadual deputadoEstadual = new Deputado_Estadual();
        Deputado_Federal deputadoFederal = new Deputado_Federal();
        Vereador_Municipal vereadorMunicipal = new Vereador_Municipal();

        public MenuCargoEleitoral(MenuAmbitoVotacao ambitoVotacao)
        {
            this.ambitoVotacao = ambitoVotacao;
            InitializeComponent();
        }
        
        private void btnDepEstadual_Click(object sender, EventArgs e)
        {
            deputadoEstadual.Show();
            this.Hide();
        }

        private void btnDepFederal_Click(object sender, EventArgs e)
        {
            deputadoFederal.Show();
            this.Hide();
        }

        private void btnVerMunicipal_Click(object sender, EventArgs e)
        {
            vereadorMunicipal.Show();
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            ambitoVotacao.Show();
            this.Hide();
        }
    }
}
