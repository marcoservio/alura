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
    public partial class frm_Login : Form
    {
        public string Senha { get; set; }
        public string Login { get; set; }

        public frm_Login()
        {
            InitializeComponent();

            lbl_Login.Text = "Usuario:";
            lbl_Password.Text = "Senha:";
            btn_OK.Text = "OK";
            btn_Cancel.Text = "Cancel";
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Login = txt_Login.Text;
            Senha = txt_Password.Text;

            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Application.Exit();
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_OK_Click(sender, e);
            }
        }
    }
}
