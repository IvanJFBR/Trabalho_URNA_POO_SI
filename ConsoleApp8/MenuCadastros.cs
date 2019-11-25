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

        public string Tipo_eleicao { get => tipo_eleicao; set => tipo_eleicao = value; }

        public MenuCadastros()
        {
            InitializeComponent();
        }
    }
}
