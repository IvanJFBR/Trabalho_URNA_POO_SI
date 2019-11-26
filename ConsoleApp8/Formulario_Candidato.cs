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
    public partial class Formulario_Candidato : Form
    {
        private Eleicao eleicao;

        public Formulario_Candidato()
        {
            InitializeComponent();
        }

        public Eleicao Eleicao { get => eleicao; set => eleicao = value; }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbNome.Text))
                MessageBox.Show("Nome é obrigatório!");

            else if (String.IsNullOrEmpty(tbNumero.Text))
                MessageBox.Show("Número é obrigatório!");

            else if (String.IsNullOrEmpty(tbCpf.Text))
                MessageBox.Show("CPF é obrigatório!");

            else if (String.IsNullOrEmpty(tbTituloEleitor.Text))
                MessageBox.Show("Titulo de eleitor é obrigatório!");

            else if (String.IsNullOrEmpty(cbPartido.Text))
                MessageBox.Show("Partido é obrigatório!");

            else
            {
                if (!validaExisteCandidato(eleicao.Candidatos))
                {
                    eleicao.Candidatos.Add(new Candidato(
                        eleicao.Partidos.Find(partido => partido.Sigla.Contains(cbPartido.Text)),
                        int.Parse(tbNumero.Text),
                        tbNome.Text,
                        tbCpf.Text,
                        tbTituloEleitor.Text));

                    MessageBox.Show("Salvo com sucesso!");
                    limpaCampos();
                }
                else
                    MessageBox.Show("Candidato já existe!");
            }
        }

        private bool validaExisteCandidato(List<Candidato> candidatos)
        {
            return candidatos.Exists(candidato => candidato.Nome.Contains(tbNome.Text)) ||
                candidatos.Exists(candidato => candidato.Numero_candidato == int.Parse(tbNumero.Text)) ||
                candidatos.Exists(candidato => candidato.Cpf.Contains(tbCpf.Text)) ||
                candidatos.Exists(candidato => candidato.Titulo_eleitor.Contains(tbTituloEleitor.Text));
        }

        private void limpaCampos()
        {
            tbNome.Text = "";
            tbNumero.Text = "";
            tbCpf.Text = "";
            tbTituloEleitor.Text = "";
            cbPartido.Text = "";
        }

        private void Formulario_Candidato_Load(object sender, EventArgs e)
        {
            if (eleicao.Partidos != null)
            {
                foreach (var partido in eleicao.Partidos)
                {
                    cbPartido.Items.Add(partido);
                }
            }
            else
            {
                MessageBox.Show("Não existem partidos cadastrados!");
            }
        }
    }
}
