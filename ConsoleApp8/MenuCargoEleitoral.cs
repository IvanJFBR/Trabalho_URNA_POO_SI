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

        MenuCadastros cadastros;

        public MenuCargoEleitoral(MenuAmbitoVotacao ambitoVotacao)
        {
            this.ambitoVotacao = ambitoVotacao;
            InitializeComponent();
        }

        private void btnPrimeiraOpcao_Click(object sender, EventArgs e)
        {
            abrirOpcaoMenu(btnPrimeiraOpcao.Text);
        }

        private void btnSegundaOpcao_Click(object sender, EventArgs e)
        {
            abrirOpcaoMenu(btnSegundaOpcao.Text);
        }

        private void btnTerceiraOpcao_Click(object sender, EventArgs e)
        {
            abrirOpcaoMenu(btnTerceiraOpcao.Text);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            ambitoVotacao.Show();
            this.Hide();
        }

        private void abrirOpcaoMenu(string cargo)
        {
            cadastros.Tipo_eleicao = cargo;
            cadastros.Ambito_eleicao = ambitoVotacao.Ambito_atual;
            cadastros.Show();
            this.Hide();
        }

        private void MenuCargoEleitoral_Load(object sender, EventArgs e)
        {
            cadastros = new MenuCadastros(this);
        }
    }
}
