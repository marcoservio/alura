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
    public partial class frm_Principal_Menu_MDI : Form
    {
        public frm_Principal_Menu_MDI()
        {
            InitializeComponent();
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DemonstracaoKey f = new frm_DemonstracaoKey();
            f.MdiParent = this;
            f.Show();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_HelloWorld f = new frm_HelloWorld();
            f.MdiParent = this;
            f.Show();
        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Mascara f = new frm_Mascara();
            f.MdiParent = this;
            f.Show();
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ValidaCPF f = new frm_ValidaCPF();
            f.MdiParent = this;
            f.Show();
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ValidaCPF2 f = new frm_ValidaCPF2();
            f.MdiParent = this;
            f.Show();
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ValidaSenha f = new frm_ValidaSenha();
            f.MdiParent = this;
            f.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }
    }
}
