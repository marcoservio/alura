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
    public partial class frm_MouseEventos : Form
    {
        public frm_MouseEventos()
        {
            InitializeComponent();
        }

        private void btn_Mouse_MouseEnter(object sender, EventArgs e)
        {
            btn_Mouse.Text = "Mouse Enter";
        }

        private void btn_Mouse_MouseLeave(object sender, EventArgs e)
        {
            btn_Mouse.Text = "Mouse Leave";
        }

        private void btn_Mouse_MouseHover(object sender, EventArgs e)
        {
            btn_Mouse.Text = "Mouse Hover";
        }

        private void btn_Mouse_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Mouse.Text = "Mouse Down";
        }

        private void btn_Mouse_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Mouse.Text = "Mouse Up";
        }
    }
}
