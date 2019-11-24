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
            cargoEleitoral.Show();
            this.Hide();
        }
    }
}
