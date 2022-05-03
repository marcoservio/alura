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
    public partial class frm_DemonstracaoKey : Form
    {
        public frm_DemonstracaoKey()
        {
            InitializeComponent();
        }

        private void txt_Imput_KeyDown(object sender, KeyEventArgs e)
        {
            txt_Msg.AppendText("\r\n" + "Pressionei uma tecla: " + e.KeyCode + "\r\n");
            txt_Msg.AppendText("\t" + "Codigo da tecla: " + (int)e.KeyCode + "\r\n");
            txt_Msg.AppendText("\t" + "Nome da tecla: " + e.KeyData + "\r\n");
            
            lbl_Lower.Text = e.KeyCode.ToString().ToLower();
            lbl_Uper.Text = e.KeyData.ToString().ToUpper();

            txt_Imput.Text = "";
            txt_Imput.Focus();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Msg.Text = "";
            txt_Imput.Text = "";
            lbl_Uper.Text = "";
            lbl_Lower.Text = "";

            txt_Imput.Focus();
        }
    }
}
