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

        public Formulario_Partido()
        {
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
            eleicao.Partidos.Add(new Partido(tbNome.Text, tbSigla.Text, int.Parse(tbNumero.Text)));
        }

        private void Formulario_Partido_Load(object sender, EventArgs e)
        {

        }
    }
}
