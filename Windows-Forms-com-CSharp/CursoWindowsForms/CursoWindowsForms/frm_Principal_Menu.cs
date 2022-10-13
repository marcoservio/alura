using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class frm_Principal_Menu : Form
    {
        public frm_Principal_Menu()
        {
            InitializeComponent();
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DemonstracaoKey f = new frm_DemonstracaoKey();
            f.ShowDialog();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_HelloWorld f = new frm_HelloWorld();
            f.ShowDialog();
        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Mascara f = new frm_Mascara();
            f.ShowDialog();
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ValidaCPF f = new frm_ValidaCPF();
            f.ShowDialog();
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ValidaCPF2 f = new frm_ValidaCPF2();
            f.ShowDialog();
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ValidaSenha f = new frm_ValidaSenha();
            f.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
