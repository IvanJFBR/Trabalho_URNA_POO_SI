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
    public partial class Formulario_Votacao : Form
    {
        private Eleicao eleicao;

        public Formulario_Votacao()
        {
            InitializeComponent();
        }

        public Eleicao Eleicao { get => eleicao; set => eleicao = value; }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                if (validaExisteCandidato(eleicao.Candidatos))
                {
                    var candidato_votado = eleicao.Candidatos.Find(candidato => candidato.Numero_candidato == int.Parse(tbNumero.Text));

                    var confirmResult = MessageBox.Show(
                        "Candidato: " + candidato_votado,
                        "Confirmar Voto?",
                        MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {
                        eleicao.Votos.Add(new Voto(
                            "valido", candidato_votado, 
                            new Eleitor(tbNome.Text, tbCpf.Text, tbTituloEleitor.Text)));

                        MessageBox.Show("CONFIRMADO!");
                        limpaCampos();
                    }
                }
                else
                {
                    var confirmResult = MessageBox.Show(
                        "Número inválido!",
                        "Votar Nulo?",
                                     MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        eleicao.Votos.Add(new Voto(
                            "nulo",
                            null,
                            new Eleitor(tbNome.Text, tbCpf.Text, tbTituloEleitor.Text)));

                        MessageBox.Show("CONFIRMADO!");
                        limpaCampos();
                    }
                }
            }
        }

        private bool validaExisteCandidato(List<Candidato> candidatos)
        {
            return candidatos.Exists(candidato => candidato.Numero_candidato == int.Parse(tbNumero.Text));
        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            tbNumero.Text = "";
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                var confirmResult = MessageBox.Show(
                "",
                "Votar em Branco?",
                MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    eleicao.Votos.Add(new Voto(
                        "branco",
                        null,
                        new Eleitor(tbNome.Text, tbCpf.Text, tbTituloEleitor.Text)));

                    MessageBox.Show("CONFIRMADO!");
                    limpaCampos();
                }
            }
        }

        private void limpaCampos()
        {
            tbNome.Text = "";
            tbNumero.Text = "";
            tbCpf.Text = "";
            tbTituloEleitor.Text = "";
        }

        private bool validaCampos()
        {
            bool validacao = false;

            if (String.IsNullOrEmpty(tbNome.Text))
                MessageBox.Show("Nome é obrigatório!");

            else if (String.IsNullOrEmpty(tbCpf.Text))
                MessageBox.Show("CPF é obrigatório!");

            else if (String.IsNullOrEmpty(tbTituloEleitor.Text))
                MessageBox.Show("Titulo de Eleitor é obrigatório!");

            else if (String.IsNullOrEmpty(tbNumero.Text))
                MessageBox.Show("Número do candidato é obrigatório!");
            else
                validacao = true;

            return validacao;
        }
    }
}
