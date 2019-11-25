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
    public partial class MenuAmbitoVotacao : Form
    {
        MenuCargoEleitoral cargoEleitoral;
        private string ambito_atual;
        private List<string> tipos_eleicoes = new List<string>();

        public string Ambito_atual { get => ambito_atual; set => ambito_atual = value; }

        public MenuAmbitoVotacao()
        {
            InitializeComponent();
        }

        private void MenuAmbitoVotacao_Load(object sender, EventArgs e)
        {
            cargoEleitoral = new MenuCargoEleitoral(this);
        }

        private void btnLegislativo_Click(object sender, EventArgs e)
        {
            ambito_atual = "Legislativo";

            cargoEleitoral.BtnPrimeiraOpcao.Text = "Deputado Estadual";
            cargoEleitoral.BtnSegundaOpcao.Text = "Deputado Federal";
            cargoEleitoral.BtnTerceiraOpcao.Text = "Vereador Municipal";

            cargoEleitoral.Show();
            this.Hide();
        }

        private void btnExecutivo_Click(object sender, EventArgs e)
        {
            ambito_atual = "Executivo";

            cargoEleitoral.BtnPrimeiraOpcao.Text = "Presidente";
            cargoEleitoral.BtnSegundaOpcao.Text = "Governador de Estado";
            cargoEleitoral.BtnTerceiraOpcao.Text = "Prefeito Municipal";

            cargoEleitoral.Show();
            this.Hide();
        }
    }
}
