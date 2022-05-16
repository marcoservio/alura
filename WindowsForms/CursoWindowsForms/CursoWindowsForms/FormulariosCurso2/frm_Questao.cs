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
    public partial class frm_Questao : Form
    {
        public frm_Questao(string nomeImagem, string mensagem)
        {
            InitializeComponent();

            Image myImage = (Image) global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            pic_Imagem.Image = myImage;

            lbl_Questao.Text = mensagem;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
