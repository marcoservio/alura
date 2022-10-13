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
    public partial class frm_ValidaSenha_UC : UserControl
    {
        bool VerSenhaTxt = false;

        public frm_ValidaSenha_UC()
        {
            InitializeComponent();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Senha.Text = "";
            lbl_Resultado.Text = "";
            btn_VerSenha.Text = "Ver Senha";
            btn_VerSenha.Enabled = false;
        }

        private void btn_VerSenha_Click(object sender, EventArgs e)
        {
            if(VerSenhaTxt == false)
            {
                txt_Senha.PasswordChar = '\0';
                VerSenhaTxt = true;
                btn_VerSenha.Text = "Esconde Senha";
            }
            else
            {
                txt_Senha.PasswordChar = '*';
                VerSenhaTxt = false;
                btn_VerSenha.Text = "Ver Senha";
            }
        }

        private void txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            btn_VerSenha.Enabled = true;

            ChecaForcaSenha checa = new ChecaForcaSenha();

            ChecaForcaSenha.ForcaDaSenha forca;
            forca = checa.GetForcaDaSenha(txt_Senha.Text);

            lbl_Resultado.Text = forca.ToString();

            if(lbl_Resultado.Text == "Inaceitavel" || lbl_Resultado.Text == "Fraca")
            {
                lbl_Resultado.ForeColor = Color.Red;
            }
            if(lbl_Resultado.Text == "Aceitavel")
            {
                lbl_Resultado.ForeColor = Color.Blue;
            }
            if(lbl_Resultado.Text == "Forte" || lbl_Resultado.Text == "Segura")
            {
                lbl_Resultado.ForeColor = Color.Green;
            }
        }
    }
}
