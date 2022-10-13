using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CursoWindowsFormsBiblioteca.Classes;
using CursoWindowsFormsBiblioteca;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;
using CursoWindowsFormsBiblioteca.Databases;

namespace CursoWindowsForms
{
    public partial class frm_CadastroCliente_UC : UserControl
    {
        #region Variaveis 

        //private string conexao = "C:\\Users\\marco\\OneDrive\\git-marcoservio\\alura\\WindowsForms\\CursoWindowsForms\\Fichario";

        #endregion

        public frm_CadastroCliente_UC()
        {
            InitializeComponent();

            #region // Text Elementos do Form

            grp_Codigo.Text = "Código";
            grp_DadosPessoais.Text = "Dados Pessoais";
            grp_Endereco.Text = "Endereço";
            grp_Outros.Text = "Outros";
            grp_DataGrid.Text = "Clientes";
            lbl_Bairro.Text = "Bairro";
            lbl_CEP.Text = "CEP";
            lbl_Complemento.Text = "Complemento";
            lbl_CPF.Text = "CPF";
            lbl_Estado.Text = "Estado";
            lbl_Logradouro.Text = "Logradouro";
            lbl_Cidade.Text = "Cidade";
            lbl_NomeCliente.Text = "Nome";
            lbl_NomeMae.Text = "Nome da Mãe";
            lbl_NomePai.Text = "Nome do Pai";
            lbl_Profissao.Text = "Profissão";
            lbl_RendaFamiliar.Text = "Renda Familiar";
            lbl_Telefone.Text = "Telefone";
            chk_TemPai.Text = "Pai desconhecido";
            grp_Genero.Text = "Genero";
            rdb_Masculino.Text = "Masculino";
            rdb_Feminino.Text = "Feminino";
            rdb_Indefinido.Text = "Indefinodo";
            btn_Busca.Text = "Buscar";

            tls_Principal.Items[0].ToolTipText = "Incluir na base de dados um novo cliente.";
            tls_Principal.Items[1].ToolTipText = "Capturar um cliente já cadastrado na base.";
            tls_Principal.Items[2].ToolTipText = "Atualize o cliente já existente.";
            tls_Principal.Items[3].ToolTipText = "Apaga o cliente selecionado.";
            tls_Principal.Items[4].ToolTipText = "Limpa dados da tela de entrada de dados.";

            #endregion

            #region // Estados

            cmb_Estados.Items.Clear();
            cmb_Estados.Items.Add("Acre (AC)");
            cmb_Estados.Items.Add("Alagoas (AL)");
            cmb_Estados.Items.Add("Amapá (AP)");
            cmb_Estados.Items.Add("Amazonas (AM)");
            cmb_Estados.Items.Add("Bahia (BA)");
            cmb_Estados.Items.Add("Ceará (CE)");
            cmb_Estados.Items.Add("Distrito Federal (DF)");
            cmb_Estados.Items.Add("Espírito Santo (ES)");
            cmb_Estados.Items.Add("Goiás (GO)");
            cmb_Estados.Items.Add("Maranhão (MA)");
            cmb_Estados.Items.Add("Mato Grosso (MT)");
            cmb_Estados.Items.Add("Mato Grosso do Sul (MS)");
            cmb_Estados.Items.Add("Minas Gerais (MG)");
            cmb_Estados.Items.Add("Pará (PA)");
            cmb_Estados.Items.Add("Paraíba (PB)");
            cmb_Estados.Items.Add("Paraná (PR)");
            cmb_Estados.Items.Add("Pernambuco (PE)");
            cmb_Estados.Items.Add("Piauí (PI)");
            cmb_Estados.Items.Add("Rio de Janeiro (RJ)");
            cmb_Estados.Items.Add("Rio Grande do Norte (RN)");
            cmb_Estados.Items.Add("Rio Grande do Sul (RS)");
            cmb_Estados.Items.Add("Rondônia (RO)");
            cmb_Estados.Items.Add("Roraima (RR)");
            cmb_Estados.Items.Add("Santa Catarina (SC)");
            cmb_Estados.Items.Add("São Paulo (SP)");
            cmb_Estados.Items.Add("Sergipe (SE)");
            cmb_Estados.Items.Add("Tocantins (TO)");

            #endregion

            LimparTela();
            AtualizaGrid();
        }

        private void LimparTela()
        {
            txt_Codigo.Text = "";
            txt_Bairro.Text = "";
            txt_CEP.Text = "";
            txt_Complemento.Text = "";
            txt_CPF.Text = "";
            txt_Logradouro.Text = "";
            txt_Cidade.Text = "";
            txt_NomeCliente.Text = "";
            txt_NomeMae.Text = "";
            txt_NomePai.Text = "";
            txt_Profissao.Text = "";
            txt_RendaFamiliar.Text = "";
            txt_Telefone.Text = "";
            cmb_Estados.SelectedIndex = -1;
            rdb_Masculino.Checked = true;
            chk_TemPai.Checked = false;
        }

        private void chk_TemPai_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_TemPai.Checked)
            {
                txt_NomePai.Enabled = false;
            }
            else
            {
                txt_NomePai.Enabled = true;
            }
        }

        private void novoToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente.Unit c = new Cliente.Unit();

                c = LeituraFormulario();
                c.ValidaClasse();
                c.ValidaComplemento();
                //c.IncluirFichario(conexao);
                //c.IncluirFicharioDB("Cliente");
                //c.IncluirFicharioSQL("Cliente");
                c.IncluirFicharioSQLRel();

                MessageBox.Show("OK: Indentificador incluido com sucesso", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparTela();
                AtualizaGrid();

                //string clienteJson = Cliente.SerializedClassUnit(c);

                //Fichario f = new Fichario(diretorio);

                //if(f.Status)
                //{
                //    f.Incluir(c.Id, clienteJson);
                //    if(f.Status)
                //    {
                //        MessageBox.Show("Ok: " + f.Mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        LimparTela();
                //    }
                //    else
                //    {
                //        MessageBox.Show("ERROR: " + f.Mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("ERROR: " + f.Mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            catch(ValidationException ex)
            {
                MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void abrirToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_Codigo.Text == "")
                {
                    MessageBox.Show("Codigo do Cliente Vazio", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Cliente.Unit c = new Cliente.Unit();

                    //c = c.BuscarFichario(txt_Codigo.Text, conexao);
                    //c = c.BuscarFicharioDB(txt_Codigo.Text, "Cliente");
                    //c = c.BuscarFicharioSQL(txt_Codigo.Text, "Cliente");
                    c = c.BuscarFicharioSQLRel(txt_Codigo.Text);

                    if(c == null)
                    {
                        MessageBox.Show("Identificador não encontrado.", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        EscreveFormulario(c);
                    }                    

                    //Fichario f = new Fichario("C:\\Users\\marco\\OneDrive\\git-marcoservio\\alura\\WindowsForms\\CursoWindowsForms\\Fichario");

                    //if(f.Status)
                    //{
                    //    string clienteJson = f.Buscar(txt_Codigo.Text);

                    //    if(clienteJson != "")
                    //    {
                    //        Cliente.Unit c = new Cliente.Unit();
                    //        c = Cliente.DesSerializedClassUnit(clienteJson);
                    //        EscreveFormulario(c);
                    //    }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("ERROR: " + f.Mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
            }
            catch(ValidationException ex)
            {
                MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvarToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_Codigo.Text == "")
                {
                    MessageBox.Show("Codigo do Cliente Vazio", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    Cliente.Unit c = new Cliente.Unit();

                    c = LeituraFormulario();
                    c.ValidaClasse();
                    c.ValidaComplemento();
                    //c.AlterarFichario(conexao);
                    //c.AlterarFicharioDB("Cliente");
                    //c.AlterarFicharioSQL("Cliente");
                    c.AlterarFicharioSQLRel();

                    MessageBox.Show("OK: Indentificador alterado com sucesso", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparTela();
                    AtualizaGrid();

                    //string clienteJson = Cliente.SerializedClassUnit(c);

                    //Fichario f = new Fichario("C:\\Users\\marco\\OneDrive\\git-marcoservio\\alura\\WindowsForms\\CursoWindowsForms\\Fichario");

                    //if(f.Status)
                    //{
                    //    f.Alterar(c.Id, clienteJson);

                    //    if(f.Status)
                    //    {
                    //        MessageBox.Show("Ok: " + f.Mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //        LimparTela();
                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show("ERROR: " + f.Mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("ERROR: " + f.Mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
            }
            catch(ValidationException ex)
            {
                MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApagatoolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_Codigo.Text == "")
                {
                    MessageBox.Show("Codigo do Cliente Vazio", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Cliente.Unit c = new Cliente.Unit();

                    //c = c.BuscarFichario(txt_Codigo.Text, conexao);
                    //c = c.BuscarFicharioDB(txt_Codigo.Text, "Cliente");
                    //c = c.BuscarFicharioSQL(txt_Codigo.Text, "Cliente");
                    c = c.BuscarFicharioSQLRel(txt_Codigo.Text);

                    if(c == null)
                    {
                        MessageBox.Show("Identificador não encontrado.", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        EscreveFormulario(c);

                        frm_Questao formulario = new frm_Questao("icons8_question_mark_64", "Você quer excluir o cliente?");
                        formulario.ShowDialog();

                        if(formulario.DialogResult == DialogResult.Yes)
                        {
                            //c.ExcluirFichario(conexao);
                            //c.ExcluirFicharioDB("Cliente");
                            //c.ExcluirFicharioSQL("Cliente");
                            c.ExcluirFicharioSQLRel();

                            MessageBox.Show("OK: Indentificador excluido com sucesso", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparTela();
                            AtualizaGrid();
                        }
                    }

                    //Fichario f = new Fichario("C:\\Users\\marco\\OneDrive\\git-marcoservio\\alura\\WindowsForms\\CursoWindowsForms\\Fichario");

                    //if(f.Status)
                    //{
                    //    abrirToolStripButton1_Click(sender, e);

                    //    frm_Questao formulario = new frm_Questao("icons8_question_mark_64", "Você quer excluir o cliente?");
                    //    formulario.ShowDialog();

                    //    if(formulario.DialogResult == DialogResult.Yes)
                    //    {
                    //        f.Excluir(txt_Codigo.Text);

                    //        if(f.Status)
                    //        {
                    //            MessageBox.Show("Ok: " + f.Mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //            LimparTela();
                    //        }
                    //        else
                    //        {
                    //            MessageBox.Show("ERROR: " + f.Mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //        }
                    //    }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("ERROR: " + f.Mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
            }
            catch(ValidationException ex)
            {
                MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpartoolStripButton_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        public void EscreveFormulario(Cliente.Unit c)
        {
            txt_Codigo.Text = c.Id;
            txt_NomeCliente.Text = c.Nome;
            txt_NomeMae.Text = c.NomeMae;
            txt_CPF.Text = c.Cpf;
            txt_CEP.Text = c.Cep;
            txt_Logradouro.Text = c.Logradouro;
            txt_Complemento.Text = c.Complemento;
            txt_Cidade.Text = c.Cidade;
            txt_Bairro.Text = c.Bairro;
            txt_Telefone.Text = c.Telefone;
            txt_Profissao.Text = c.Profissao;
            txt_RendaFamiliar.Text = c.RendaFamiliar.ToString();

            if(c.NaoTemPai == 1)
            {
                chk_TemPai.Checked = true;
                txt_NomePai.Text = "";
            }
            else
            {
                chk_TemPai.Checked = false;
                txt_NomePai.Text = c.NomePai;
            }

            if(c.Genero == 0)
                rdb_Masculino.Checked = true;
            if(c.Genero == 1)
                rdb_Feminino.Checked = true;
            if(c.Genero == 2)
                rdb_Indefinido.Checked = true;

            if(c.Estado == "")
                cmb_Estados.SelectedIndex = -1;
            else
            {
                for(int i = 0; i < cmb_Estados.Items.Count; i++)
                {
                    if(c.Estado == cmb_Estados.Items[i].ToString())
                    {
                        cmb_Estados.SelectedIndex = i;
                    }
                }
            }
        }

        public Cliente.Unit LeituraFormulario()
        {
            Cliente.Unit c = new Cliente.Unit();

            c.Id = txt_Codigo.Text;
            c.Nome = txt_NomeCliente.Text;
            c.NomeMae = txt_NomeMae.Text;
            c.NomePai = txt_NomePai.Text;
            if(chk_TemPai.Checked)
                c.NaoTemPai = 1;
            else
                c.NaoTemPai = 0;
            if(rdb_Masculino.Checked)
                c.Genero = 0;
            if(rdb_Feminino.Checked)
                c.Genero = 1;
            if(rdb_Indefinido.Checked)
                c.Genero = 2;
            c.Cpf = txt_CPF.Text;

            c.Cep = txt_CEP.Text;
            c.Logradouro = txt_Logradouro.Text;
            c.Complemento = txt_Complemento.Text;
            c.Cidade = txt_Cidade.Text;
            c.Bairro = txt_Bairro.Text;
            if(cmb_Estados.SelectedIndex < 0)
                c.Estado = "";
            else
                c.Estado = cmb_Estados.Items[cmb_Estados.SelectedIndex].ToString();

            c.Telefone = txt_Telefone.Text;
            c.Profissao = txt_Profissao.Text;
            if(Information.IsNumeric(txt_RendaFamiliar.Text))
            {
                double vRenda = Convert.ToDouble(txt_RendaFamiliar.Text);

                if(vRenda < 0)
                    c.RendaFamiliar = 0;
                else
                    c.RendaFamiliar = vRenda;
            }

            return c;
        }

        private void txt_CEP_Leave(object sender, EventArgs e)
        {
            string vCep = txt_CEP.Text;

            if(vCep == "")
            {
                return;
            }
            if(vCep.Length != 8)
            {
                return;
            }
            if(!Information.IsNumeric(vCep))
            {
                return;
            }

            var vJson = Uteis.GeraJSONCEP(vCep);
            Cep.Unit cep = new Cep.Unit();
            cep = Cep.DesSerializedClassUnit(vJson);

            txt_Cidade.Text = cep.localidade;
            txt_Logradouro.Text = cep.logradouro;
            txt_Bairro.Text = cep.bairro;

            cmb_Estados.SelectedIndex = -1;
            for(int i = 0; i < cmb_Estados.Items.Count; i++)
            {
                var vPos = Strings.InStr(cmb_Estados.Items[i].ToString(), "(" + cep.uf + ")");

                if(vPos > 0)
                {
                    cmb_Estados.SelectedIndex = i;
                }
            }
        }

        private void btn_Busca_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente.Unit c = new Cliente.Unit();
                //var listaBusca = c.BuscarFicharioTodos(conexao);
                //var listaBusca = c.BuscarFicharioDBTodos("Cliente");
                //var listaBusca = c.BuscarFicharioSQLTodos("Cliente");
                var listaBusca = c.BuscarFicharioSQLTodosRel();

                frm_Busca form = new frm_Busca(listaBusca);
                form.ShowDialog();
                
                if(form.DialogResult == DialogResult.OK)
                {
                    var idSelect = form.IdSelect;

                    //c = c.BuscarFichario(idSelect, conexao);
                    //c = c.BuscarFicharioDB(idSelect, "Cliente");
                    //c = c.BuscarFicharioSQL(idSelect, "Cliente");
                    c = c.BuscarFicharioSQLRel(idSelect);

                    if(c == null)
                    {
                        MessageBox.Show("Identificador não encontrado.", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        EscreveFormulario(c);
                    }
                }
            }
            catch(ValidationException ex)
            {
                MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Cliente.Unit c = new Cliente.Unit();
            //List<string> lista = new List<string>();

            //lista = c.ListaFichario(conexao);

            //if(lista == null || lista.Count == 0)
            //{
            //    MessageBox.Show("Base de dados esta vazia. Não existe nenhum identificador cadastrado", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    List<List<string>> listaBusca = new List<List<string>>();

            //    foreach(var i in lista)
            //    {
            //        c = Cliente.DesSerializedClassUnit(i);
            //        listaBusca.Add(new List<string> { c.Id, c.Nome });
            //    }

            //    frm_Busca form = new frm_Busca(listaBusca);
            //    form.ShowDialog();

            //    if(form.DialogResult == DialogResult.OK)
            //    {
            //        var idSelect = form.IdSelect;
            //        c = c.BuscarFichario(idSelect, conexao);

            //        if(c == null)
            //        {
            //            MessageBox.Show("Identificador não encontrado.", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //        else
            //        {
            //            EscreveFormulario(c);
            //        }
            //    }
            //}

            //Fichario f = new Fichario("C:\\Users\\marco\\OneDrive\\git-marcoservio\\alura\\WindowsForms\\CursoWindowsForms\\Fichario");

            //if(f.Status)
            //{
            //    List<string> lista = new List<string>();
            //    lista = f.BuscarTodos();

            //    if(f.Status)
            //    {
            //        List<List<string>> listaBusca = new List<List<string>>();

            //        foreach(var i in lista)
            //        {
            //            Cliente.Unit c = Cliente.DesSerializedClassUnit(i);
            //            listaBusca.Add(new List<string> { c.Id, c.Nome });
            //        }

            //        frm_Busca form = new frm_Busca(listaBusca);
            //        form.ShowDialog();

            //        if(form.DialogResult == DialogResult.OK)
            //        {
            //            var idSelect = form.IdSelect;
            //            string clienteJson = f.Buscar(idSelect);

            //            if(clienteJson != "")
            //            {
            //                Cliente.Unit c = new Cliente.Unit();
            //                c = Cliente.DesSerializedClassUnit(clienteJson);
            //                EscreveFormulario(c);
            //            }
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("ERROR: " + f.Mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("ERROR: " + f.Mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void AtualizaGrid()
        {
            try
            {
                Cliente.Unit c = new Cliente.Unit();
                var listaBusca = c.BuscarFicharioSQLTodosRel();

                dg_Clientes.Rows.Clear();

                for(int i = 0; i < listaBusca.Count; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dg_Clientes);
                    row.Cells[0].Value = listaBusca[i][0].ToString();
                    row.Cells[1].Value = listaBusca[i][1].ToString();
                    dg_Clientes.Rows.Add(row);
                }
            }
            catch(ValidationException ex)
            {
                MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dg_Clientes_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dg_Clientes.SelectedRows[0];
                string id = row.Cells[0].Value.ToString();

                Cliente.Unit c = new Cliente.Unit();

                c = c.BuscarFicharioSQLRel(id);

                if(c == null)
                {
                    MessageBox.Show("Identificador não encontrado.", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    EscreveFormulario(c);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
