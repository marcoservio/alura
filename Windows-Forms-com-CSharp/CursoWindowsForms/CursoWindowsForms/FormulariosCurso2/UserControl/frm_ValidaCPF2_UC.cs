using CursoWindowsFormsBiblioteca;

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
    public partial class frm_ValidaCPF2_UC : UserControl
    {
        public frm_ValidaCPF2_UC()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            msk_CPF.Text = "";
            msk_CPF.Focus();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void btn_Valida_Click(object sender, EventArgs e)
        {
            string vConteudo = msk_CPF.Text;
            vConteudo = vConteudo.Replace(".", "").Replace("-", "");
            vConteudo = vConteudo.Trim();

            if(vConteudo == "")
            {
                MessageBox.Show("Você deve digitar um CPF", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpaTela();
            }
            else
            {
                if(vConteudo.Length != 11)
                {
                    MessageBox.Show("CPF deve ter 11 digitos", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpaTela();
                }
                else
                {
                    frm_Questao db = new frm_Questao("Frm_ValidaCPF2", "Tem certeza em validar o CPF?");
                    db.ShowDialog();
                    
                    //if(MessageBox.Show("Você deseja realmente validar o CPF?", "Mensagem de Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    if(db.DialogResult == DialogResult.Yes)
                    {
                        bool validaCPF = false;
                        validaCPF = Uteis.Valida(msk_CPF.Text);

                        if(validaCPF)
                        {
                            MessageBox.Show("CPF VÁLIDO", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("CPF INVÁLIDO", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        LimpaTela();
                    }
                }
            }
        }
    }
}
