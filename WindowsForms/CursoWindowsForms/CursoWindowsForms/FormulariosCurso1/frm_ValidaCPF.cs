using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CursoWindowsFormsBiblioteca;

namespace CursoWindowsForms
{
    public partial class frm_ValidaCPF : Form
    {
        public frm_ValidaCPF()
        {
            InitializeComponent();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = "";
            msk_CPF.Text = "";
        }

        private void btn_Valida_Click(object sender, EventArgs e)
        {
            bool validaCPF = false;
            validaCPF = Uteis.Valida(msk_CPF.Text);

            if(validaCPF)
            {
                lbl_Resultado.Text = "CPF VÁLIDO";
                lbl_Resultado.ForeColor = Color.Green;
            }
            else
            {
                lbl_Resultado.Text = "CPF INVÁLIDO";
                lbl_Resultado.ForeColor = Color.Red;
            }
        }
    }
}
