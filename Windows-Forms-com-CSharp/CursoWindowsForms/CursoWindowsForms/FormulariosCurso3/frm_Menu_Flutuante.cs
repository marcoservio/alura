using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Net.Mime.MediaTypeNames;

using Image = System.Drawing.Image;

namespace CursoWindowsForms
{
    public partial class frm_Menu_Flutuante : Form
    {
        public frm_Menu_Flutuante()
        {
            InitializeComponent();
        }

        private void frm_Menu_Flutuante_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                //var posicaoX = e.X;
                //var posicaoY = e.Y;
                //MessageBox.Show($"Cliquei com o botão da direita do mouse. " +
                //                $"\nA posição relativa foi ({posicaoX.ToString()}, {posicaoY.ToString()})");

                var contexMenu = new ContextMenuStrip();

                var vToolTip1 = DesenhaItemMenu("Item do menu 1", "key");
                vToolTip1.DropDownItems.Add("Menu 1.1");
                vToolTip1.DropDownItems.Add("Menu 1.2");

                var vToolTip2 = DesenhaItemMenu("Item do menu 2", "Frm_ValidaSenha");

                contexMenu.Items.Add(vToolTip1);
                contexMenu.Items.Add(vToolTip2);

                contexMenu.Show(this, new Point(e.X, e.Y));

                vToolTip1.Click += new EventHandler(vToolTip1_Click);
                vToolTip2.Click += new EventHandler(vToolTip2_Click);
            }
        }

        public void vToolTip1_Click(object sender1, EventArgs e1)
        {
            MessageBox.Show("Selecionei a opção do menu 001");
        }

        public void vToolTip2_Click(object sender1, EventArgs e1)
        {
            MessageBox.Show("Selecionei a opção do menu 002");
        }

        public ToolStripMenuItem DesenhaItemMenu(string text, string nomeImagem)
        {
            var vToolTip = new ToolStripMenuItem();
            vToolTip.Text = text;

            Image myImage = (Image) global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);

            vToolTip.Image = myImage;

            return vToolTip;
        }
    }
}
