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
    public partial class frm_Principal_Menu_UC : Form
    {
        #region // Variaveis globais

        private int ControleHelloWorld = 0;
        private int ControleDemonstracaoKey = 0;
        private int ControleMascara = 0;
        private int ControleValidaCPF = 0;
        private int ControleValidaCPF2 = 0;
        private int ControleValidaSenha = 0;
        private int ControleArquivoImagem = 0;
        private int ControleCadastroClientes = 0;

        #endregion

        public frm_Principal_Menu_UC()
        {
            InitializeComponent();

            novoToolStripMenuItem.Enabled = false;
            apagarAbaToolStripMenuItem.Enabled = false;
            açõesToolStripMenuItem.Enabled = false;
            windowsToolStripMenuItem.Visible = false;
            desconectarToolStripMenuItem.Enabled = false;

            mnu_Principal.Visible = false;
        }

        public void LimpaAba()
        {
            ControleHelloWorld = 0;
            ControleDemonstracaoKey = 0;
            ControleMascara = 0;
            ControleValidaCPF = 0;
            ControleValidaCPF2 = 0;
            ControleValidaSenha = 0;
            ControleCadastroClientes = 0;

            if(tbc_Aplicacoes.TabCount == 0)
                lbl_Fechar.Visible = false;
        }

        public void ApagaAba(TabPage tabPage)
        {
            if(!(tabPage == null))
            {
                tbc_Aplicacoes.TabPages.Remove(tabPage);

                LimpaAba();
            }
        }

        public void ApagaDireita(int itemSelecionado)
        {
            if(!(tbc_Aplicacoes.SelectedTab == null))
            {
                for(int i = tbc_Aplicacoes.TabCount - 1; i > itemSelecionado; i--)
                {
                    tbc_Aplicacoes.TabPages.Remove(tbc_Aplicacoes.TabPages[i]);

                    LimpaAba();
                }
            }
        }

        public void ApagaEsqueda(int itemSelecionado)
        {
            if(!(tbc_Aplicacoes.SelectedTab == null))
            {
                for(int i = itemSelecionado - 1; i >= 0; i--)
                {
                    tbc_Aplicacoes.TabPages.Remove(tbc_Aplicacoes.TabPages[i]);

                    LimpaAba();
                }
            }
        }

        public void ApagaTodasAbas()
        {
            if(!(tbc_Aplicacoes.SelectedTab == null))
            {
                for(int i = tbc_Aplicacoes.TabPages.Count - 1; i >= 0; i += -1)
                {
                    tbc_Aplicacoes.TabPages.Remove(tbc_Aplicacoes.TabPages[i]);
                }
            }
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_Fechar.Visible = true;
            frm_DemostracaoKey_UC f = new frm_DemostracaoKey_UC();
            f.Dock = DockStyle.Fill;
            TabPage tb = new TabPage();

            if(ControleDemonstracaoKey == 0)
            {
                tb.Name = "Demonstração Key";
                tb.Text = "Demonstração Key";
            }
            else
            {
                tb.Name = "Demonstração Key" + " (" + ControleDemonstracaoKey + ")";
                tb.Text = "Demonstração Key" + " (" + ControleDemonstracaoKey + ")";
            }

            tb.ImageIndex = 0;
            tb.Controls.Add(f);
            tbc_Aplicacoes.TabPages.Add(tb);

            ControleDemonstracaoKey++;
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_Fechar.Visible = true;
            frm_HelloWorld_UC f = new frm_HelloWorld_UC();
            f.Dock = DockStyle.Fill;
            TabPage tb = new TabPage();

            if(ControleHelloWorld == 0)
            {
                tb.Name = "Hello World";
                tb.Text = "Hello World";
            }
            else
            {
                tb.Name = "Hello World" + " (" + ControleHelloWorld + ")";
                tb.Text = "Hello World" + " (" + ControleHelloWorld + ")";
            }

            tb.ImageIndex = 1;
            tb.Controls.Add(f);
            tbc_Aplicacoes.TabPages.Add(tb);

            ControleHelloWorld++;
        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_Fechar.Visible = true;
            frm_Mascara_UC f = new frm_Mascara_UC();
            f.Dock = DockStyle.Fill;
            TabPage tb = new TabPage();

            if(ControleMascara == 0)
            {
                tb.Name = "Mascara";
                tb.Text = "Mascara";
            }
            else
            {
                tb.Name = "Mascara" + " (" + ControleMascara + ")";
                tb.Text = "Mascara" + " (" + ControleMascara + ")";
            }

            tb.ImageIndex = 2;
            tb.Controls.Add(f);
            tbc_Aplicacoes.TabPages.Add(tb);

            ControleMascara++;
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_Fechar.Visible = true;
            frm_ValidaCPF_UC f = new frm_ValidaCPF_UC();
            f.Dock = DockStyle.Fill;
            TabPage tb = new TabPage();

            if(ControleValidaCPF == 0)
            {
                tb.Name = "Valida CPF";
                tb.Text = "Valida CPF";
            }
            else
            {
                tb.Name = "Valida CPF" + " (" + ControleValidaCPF + ")";
                tb.Text = "Valida CPF" + " (" + ControleValidaCPF + ")";
            }

            tb.ImageIndex = 3;
            tb.Controls.Add(f);
            tbc_Aplicacoes.TabPages.Add(tb);

            ControleValidaCPF++;
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_Fechar.Visible = true;
            frm_ValidaCPF2_UC f = new frm_ValidaCPF2_UC();
            f.Dock = DockStyle.Fill;
            TabPage tb = new TabPage();

            if(ControleValidaCPF2 == 0)
            {
                tb.Name = "Valida CPF2";
                tb.Text = "Valida CPF2";
            }
            else
            {
                tb.Name = "Valida CPF2" + " (" + ControleValidaCPF2 + ")";
                tb.Text = "Valida CPF2" + " (" + ControleValidaCPF2 + ")";
            }

            tb.ImageIndex = 4;
            tb.Controls.Add(f);
            tbc_Aplicacoes.TabPages.Add(tb);

            ControleValidaCPF2++;
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_Fechar.Visible = true;
            frm_ValidaSenha_UC f = new frm_ValidaSenha_UC();
            f.Dock = DockStyle.Fill;
            TabPage tb = new TabPage();

            if(ControleValidaSenha == 0)
            {
                tb.Name = "Valida CPF";
                tb.Text = "Valida CPF";
            }
            else
            {
                tb.Name = "Valida CPF" + " (" + ControleValidaSenha + ")";
                tb.Text = "Valida CPF" + " (" + ControleValidaSenha + ")";
            }

            tb.ImageIndex = 5;
            tb.Controls.Add(f);
            tbc_Aplicacoes.TabPages.Add(tb);

            ControleValidaSenha++;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApagaAba(tbc_Aplicacoes.SelectedTab);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ApagaAba(tbc_Aplicacoes.SelectedTab);
        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.InitialDirectory = "C:\\Users\\marco\\OneDrive\\git-marcoservio\\alura\\WindowsForms\\CursoWindowsForms\\CursoWindowsForms\\Imagens";
            fd.Filter = ".png|*.png";
            fd.Title = "Escolha a Imagem";

            if(fd.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivoImagem = fd.FileName;


                lbl_Fechar.Visible = true;
                frm_ArquivoImagem_UC f = new frm_ArquivoImagem_UC(nomeArquivoImagem);
                f.Dock = DockStyle.Fill;
                TabPage tb = new TabPage();

                if(ControleArquivoImagem == 0)
                {
                    tb.Name = "Aquivo Imagem";
                    tb.Text = "Aquivo Imagem";
                }
                else
                {
                    tb.Name = "Aquivo Imagem" + " (" + ControleArquivoImagem + ")";
                    tb.Text = "Aquivo Imagem" + " (" + ControleArquivoImagem + ")";
                }

                tb.ImageIndex = 6;
                tb.Controls.Add(f);
                tbc_Aplicacoes.TabPages.Add(tb);

                ControleArquivoImagem++;
            }
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Login f = new frm_Login();
            f.ShowDialog();

            if(f.DialogResult == DialogResult.OK)
            {
                string login = f.Login.ToString();
                string senha = f.Senha.ToString();

                if(Uteis.ValidaSenhaLogin(login, senha) == true)
                {
                    novoToolStripMenuItem.Enabled = true;
                    apagarAbaToolStripMenuItem.Enabled = true;
                    açõesToolStripMenuItem.Enabled = true;
                    windowsToolStripMenuItem.Visible = false;
                    conectarToolStripMenuItem.Enabled = false;
                    desconectarToolStripMenuItem.Enabled = true;

                    mnu_Principal.Visible = true;

                    //MessageBox.Show("Bem vindo " + login + "!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario ou senha invalido!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Questao db = new frm_Questao("icons8_question_mark_64", "Você deseja se desconectar?");
            db.ShowDialog();

            if(db.DialogResult == DialogResult.Yes)
            {
                for(int i = tbc_Aplicacoes.TabPages.Count; i > 0; i--)
                {
                    tbc_Aplicacoes.TabPages.Remove(tbc_Aplicacoes.TabPages[0]);
                }

                novoToolStripMenuItem.Enabled = false;
                apagarAbaToolStripMenuItem.Enabled = false;
                açõesToolStripMenuItem.Enabled = false;
                windowsToolStripMenuItem.Visible = false;
                desconectarToolStripMenuItem.Enabled = false;
                conectarToolStripMenuItem.Enabled = true;
                lbl_Fechar.Visible = false;

                mnu_Principal.Visible = false;

                frm_Principal_Menu_UC_Load(sender, e);
            }
        }

        private void tbc_Aplicacoes_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                var contexMenu = new ContextMenuStrip();

                var vToolTip1 = DesenhaItemMenu("Apagar a aba", "DeleteTab");
                var vToolTip2 = DesenhaItemMenu("Apagar todas as esquerda", "DeleteLeft");
                var vToolTip3 = DesenhaItemMenu("Apagar todas as direita", "DeleteRight");
                var vToolTip4 = DesenhaItemMenu("Apagar todas menos esta", "DeleteAll");

                contexMenu.Items.Add(vToolTip1);
                contexMenu.Items.Add(vToolTip2);
                contexMenu.Items.Add(vToolTip3);
                contexMenu.Items.Add(vToolTip4);

                contexMenu.Show(this, new Point(e.X, e.Y));

                vToolTip1.Click += new EventHandler(vToolTip1_Click);
                vToolTip2.Click += new EventHandler(vToolTip2_Click);
                vToolTip3.Click += new EventHandler(vToolTip3_Click);
                vToolTip4.Click += new EventHandler(vToolTip4_Click);
            }
            if(e.Button == MouseButtons.Middle)
            {
                ApagaAba(tbc_Aplicacoes.SelectedTab);
            }
        }

        public void vToolTip1_Click(object sender1, EventArgs e1)
        {
            ApagaAba(tbc_Aplicacoes.SelectedTab);
        }

        public void vToolTip2_Click(object sender1, EventArgs e1)
        {
            ApagaEsqueda(tbc_Aplicacoes.SelectedIndex);
        }

        public void vToolTip3_Click(object sender1, EventArgs e1)
        {
            ApagaDireita(tbc_Aplicacoes.SelectedIndex);
        }

        public void vToolTip4_Click(object sender1, EventArgs e1)
        {
            ApagaEsqueda(tbc_Aplicacoes.SelectedIndex);
            ApagaDireita(tbc_Aplicacoes.SelectedIndex);
        }

        public ToolStripMenuItem DesenhaItemMenu(string text, string nomeImagem)
        {
            var vToolTip = new ToolStripMenuItem();
            vToolTip.Text = text;

            Image myImage = (Image) global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);

            vToolTip.Image = myImage;

            return vToolTip;
        }

        private void frm_Principal_Menu_UC_Load(object sender, EventArgs e)
        {
            frm_Login f = new frm_Login();
            f.ShowDialog();

            if(f.DialogResult == DialogResult.OK)
            {
                string login = f.Login.ToString();
                string senha = f.Senha.ToString();

                if(Uteis.ValidaSenhaLogin(login, senha) == true)
                {
                    novoToolStripMenuItem.Enabled = true;
                    apagarAbaToolStripMenuItem.Enabled = true;
                    açõesToolStripMenuItem.Enabled = true;
                    windowsToolStripMenuItem.Visible = false;
                    conectarToolStripMenuItem.Enabled = false;
                    desconectarToolStripMenuItem.Enabled = true;

                    mnu_Principal.Visible = true;

                    conectarToolStripMenuItem.Visible = false;

                    //MessageBox.Show("Bem vindo " + login + "!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario ou senha invalido!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm_Principal_Menu_UC_Load(sender, e);
                }
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ControleCadastroClientes == 0)
            {
                lbl_Fechar.Visible = true;
                frm_CadastroCliente_UC f = new frm_CadastroCliente_UC();
                f.Dock = DockStyle.Fill;
                TabPage tb = new TabPage();

                tb.Name = "Cadastro de Cliente";
                tb.Text = "Cadastro de Cliente";

                tb.ImageIndex = 7;
                tb.Controls.Add(f);
                tbc_Aplicacoes.TabPages.Add(tb);

                ControleCadastroClientes++;
            }
            else
            {
                MessageBox.Show("Não posso abrir o Cadastro de Clientes porque já está aberto.", "Banco ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void agênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Agencia f = new frm_Agencia();
            f.ShowDialog();
        }
    }
}