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
    public partial class Formulario_Partido : Form
    {
        private Eleicao eleicao;
        MenuCadastros menuCadastros;

        public Formulario_Partido(MenuCadastros menuCadastros)
        {
            this.menuCadastros = menuCadastros;
            InitializeComponent();
        }

        public Eleicao Eleicao { get => eleicao; set => eleicao = value; }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbNome.Text))
                MessageBox.Show("Nome é obrigatório!");

            else if (String.IsNullOrEmpty(tbSigla.Text))
                MessageBox.Show("Sigla é obrigatório!");

            else if (String.IsNullOrEmpty(tbNumero.Text))
                MessageBox.Show("Número é obrigatório!");

            else
            {
                if (!validaExistePartido(eleicao.Partidos))
                {
                    eleicao.Partidos.Add(new Partido(tbNome.Text, tbSigla.Text, int.Parse(tbNumero.Text)));
                    MessageBox.Show("Salvo com sucesso!");
                    limpaCampos();
                }
                else
                    MessageBox.Show("Partido já existe!");
            }
        }

        private bool validaExistePartido(List<Partido> partidos)
        {
            return partidos.Exists(partido => partido.Sigla.Contains(tbSigla.Text)) ||
                partidos.Exists(partido => partido.Nome.Contains(tbNome.Text)) ||
                partidos.Exists(partido => partido.Numero == int.Parse(tbNumero.Text));
        }

        private void limpaCampos()
        {
            tbNome.Text = "";
            tbSigla.Text = "";
            tbNumero.Text = "";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            menuCadastros.Show();
            this.Hide();
        }
    }
}
