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
    public partial class MenuCadastros : Form
    {
        private string tipo_eleicao;
        private string ambito_eleicao;
        private Eleicao eleicao = new Eleicao("", "");
        MenuCargoEleitoral cargoEleitoral;

        public string Tipo_eleicao { get => tipo_eleicao; set => tipo_eleicao = value; }
        public string Ambito_eleicao { get => ambito_eleicao; set => ambito_eleicao = value; }
        public Eleicao Eleicao { get => eleicao; set => eleicao = value; }

        public MenuCadastros(MenuCargoEleitoral cargoEleitoral)
        {
            this.cargoEleitoral = cargoEleitoral;
            InitializeComponent();
        }

        private void btnCadastrarPartido_Click(object sender, EventArgs e)
        {
            Formulario_Partido formulario = new Formulario_Partido(this);
            formulario.Eleicao = eleicao;
            formulario.Show();
            this.Hide();
        }

        private void btnCadastrarCandidato_Click(object sender, EventArgs e)
        {
            Formulario_Candidato formulario = new Formulario_Candidato(this);
            formulario.Eleicao = eleicao;
            formulario.Show();
            this.Hide();
        }

        private void btnIniciarVotacao_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Iniciar a votação inibe a criação de novos partidos, assim como de novos candidatos",
                "Confirmar Inicio da Votação?",
                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                Formulario_Votacao formulario = new Formulario_Votacao();
                formulario.Eleicao = eleicao;
                formulario.Show();
                this.Hide();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            cargoEleitoral.Show();
            this.Hide();
        }
    }
}
