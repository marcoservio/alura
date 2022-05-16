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
    public partial class frm_Busca : Form
    {
        private List<List<string>> _listaBusca = new List<List<string>>();
        public string IdSelect { get; private set; }

        public frm_Busca(List<List<string>> listaBusca)
        {
            _listaBusca = listaBusca;

            InitializeComponent();

            this.Text = "Busca";

            tls_Principal.Items[0].ToolTipText = "Fechar a caixa de dialago";

            PreencherLista();

            lst_Busca.Sorted = true;
        }

        private void PreencherLista()
        {
            lst_Busca.Items.Clear();

            for(int i = 0; i < _listaBusca.Count; i++)
            {
                ItemBox x = new ItemBox();
                x.Id = _listaBusca[i][0];
                x.Nome = _listaBusca[i][1];

                lst_Busca.Items.Add(x);
            }
        }

        private void ApagatoolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void salvarToolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            ItemBox item = lst_Busca.Items[lst_Busca.SelectedIndex] as ItemBox;

            IdSelect = item.Id;
            this.Close();
        }

        private class ItemBox
        {
            public string Id { get; set; }
            public string Nome { get; set; }

            public override string ToString()
            {
                return Nome;
            }
        }
    }
}
