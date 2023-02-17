using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAula2
{
    public partial class FormPokémon : Form
    {
        public FormPokémon()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbtCharmander_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxPokemon.Image = Properties.Resources.zvu0wzu39r88dsds;
        }

        private void rbtSquartle_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxPokemon.Image = Properties.Resources.d9yaaj3_f7bc18c1_b559_40fe_880b_f5b3bff69a6d_removebg_preview;
        }

        private void rbtBubassauro_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxPokemon.Image = Properties.Resources.q17mxpzw8r881;
        }
    }
}
