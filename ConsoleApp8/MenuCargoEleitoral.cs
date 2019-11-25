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

        MenuCadastros cadastros = new MenuCadastros();

        public MenuCargoEleitoral(MenuAmbitoVotacao ambitoVotacao)
        {
            this.ambitoVotacao = ambitoVotacao;
            InitializeComponent();
        }
        
        private void btnDepEstadual_Click(object sender, EventArgs e)
        {
            cadastros.Tipo_eleicao = "Deputado Estadual";
            cadastros.Show();
            this.Hide();
        }

        private void btnDepFederal_Click(object sender, EventArgs e)
        {
            cadastros.Tipo_eleicao = "Deputado Federal";
            cadastros.Show();
            this.Hide();
        }

        private void btnVerMunicipal_Click(object sender, EventArgs e)
        {
            cadastros.Tipo_eleicao = "Vereador Municipal";
            cadastros.Show();
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            ambitoVotacao.Show();
            this.Hide();
        }
    }
}
