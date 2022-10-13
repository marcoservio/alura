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
    public partial class frm_ArquivoImagem_UC : UserControl
    {
        public frm_ArquivoImagem_UC(string nomeArquivoImagem)
        {
            InitializeComponent();

            lbl_Arquivo_Imagem.Text = nomeArquivoImagem;
            pic_ArquivoImagem.Image = Image.FromFile(nomeArquivoImagem);
        }

        private void btn_Cor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if(cd.ShowDialog() == DialogResult.OK)
            {
                lbl_Arquivo_Imagem.ForeColor = cd.Color;
            }
        }

        private void btn_Fonte_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();

            if(fd.ShowDialog() == DialogResult.OK)
            {
                lbl_Arquivo_Imagem.Font = fd.Font;
            }
        }
    }
}
