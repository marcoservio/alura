namespace CursoWindowsForms
{
    partial class frm_CadastroCliente_UC
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CadastroCliente_UC));
            this.lbl_CPF = new System.Windows.Forms.Label();
            this.txt_CPF = new System.Windows.Forms.TextBox();
            this.txt_NomeCliente = new System.Windows.Forms.TextBox();
            this.lbl_NomeCliente = new System.Windows.Forms.Label();
            this.txt_NomePai = new System.Windows.Forms.TextBox();
            this.lbl_NomePai = new System.Windows.Forms.Label();
            this.txt_NomeMae = new System.Windows.Forms.TextBox();
            this.lbl_NomeMae = new System.Windows.Forms.Label();
            this.txt_CEP = new System.Windows.Forms.TextBox();
            this.lbl_CEP = new System.Windows.Forms.Label();
            this.txt_Logradouro = new System.Windows.Forms.TextBox();
            this.lbl_Logradouro = new System.Windows.Forms.Label();
            this.txt_Complemento = new System.Windows.Forms.TextBox();
            this.lbl_Complemento = new System.Windows.Forms.Label();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.lbl_Bairro = new System.Windows.Forms.Label();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.txt_Telefone = new System.Windows.Forms.TextBox();
            this.lbl_Telefone = new System.Windows.Forms.Label();
            this.txt_Profissao = new System.Windows.Forms.TextBox();
            this.lbl_Profissao = new System.Windows.Forms.Label();
            this.txt_RendaFamiliar = new System.Windows.Forms.TextBox();
            this.lbl_RendaFamiliar = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.grp_Codigo = new System.Windows.Forms.GroupBox();
            this.btn_Busca = new System.Windows.Forms.Button();
            this.grp_DadosPessoais = new System.Windows.Forms.GroupBox();
            this.grp_Genero = new System.Windows.Forms.GroupBox();
            this.rdb_Indefinido = new System.Windows.Forms.RadioButton();
            this.rdb_Feminino = new System.Windows.Forms.RadioButton();
            this.rdb_Masculino = new System.Windows.Forms.RadioButton();
            this.grp_TemPai = new System.Windows.Forms.GroupBox();
            this.chk_TemPai = new System.Windows.Forms.CheckBox();
            this.grp_Endereco = new System.Windows.Forms.GroupBox();
            this.cmb_Estados = new System.Windows.Forms.ComboBox();
            this.lbl_Cidade = new System.Windows.Forms.Label();
            this.txt_Cidade = new System.Windows.Forms.TextBox();
            this.grp_Outros = new System.Windows.Forms.GroupBox();
            this.tls_Principal = new System.Windows.Forms.ToolStrip();
            this.novoToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.abrirToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.salvarToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ApagatoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LimpartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.imprimirToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.recortarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copiarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.colarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ajudaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.grp_DataGrid = new System.Windows.Forms.GroupBox();
            this.dg_Clientes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_Codigo.SuspendLayout();
            this.grp_DadosPessoais.SuspendLayout();
            this.grp_Genero.SuspendLayout();
            this.grp_TemPai.SuspendLayout();
            this.grp_Endereco.SuspendLayout();
            this.grp_Outros.SuspendLayout();
            this.tls_Principal.SuspendLayout();
            this.grp_DataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_CPF
            // 
            this.lbl_CPF.AutoSize = true;
            this.lbl_CPF.Location = new System.Drawing.Point(6, 140);
            this.lbl_CPF.Name = "lbl_CPF";
            this.lbl_CPF.Size = new System.Drawing.Size(35, 13);
            this.lbl_CPF.TabIndex = 0;
            this.lbl_CPF.Text = "label1";
            // 
            // txt_CPF
            // 
            this.txt_CPF.Location = new System.Drawing.Point(6, 158);
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.Size = new System.Drawing.Size(331, 20);
            this.txt_CPF.TabIndex = 6;
            // 
            // txt_NomeCliente
            // 
            this.txt_NomeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_NomeCliente.Location = new System.Drawing.Point(6, 39);
            this.txt_NomeCliente.Name = "txt_NomeCliente";
            this.txt_NomeCliente.Size = new System.Drawing.Size(726, 20);
            this.txt_NomeCliente.TabIndex = 2;
            // 
            // lbl_NomeCliente
            // 
            this.lbl_NomeCliente.AutoSize = true;
            this.lbl_NomeCliente.Location = new System.Drawing.Point(6, 23);
            this.lbl_NomeCliente.Name = "lbl_NomeCliente";
            this.lbl_NomeCliente.Size = new System.Drawing.Size(35, 13);
            this.lbl_NomeCliente.TabIndex = 2;
            this.lbl_NomeCliente.Text = "label1";
            // 
            // txt_NomePai
            // 
            this.txt_NomePai.Location = new System.Drawing.Point(6, 78);
            this.txt_NomePai.Name = "txt_NomePai";
            this.txt_NomePai.Size = new System.Drawing.Size(504, 20);
            this.txt_NomePai.TabIndex = 3;
            // 
            // lbl_NomePai
            // 
            this.lbl_NomePai.AutoSize = true;
            this.lbl_NomePai.Location = new System.Drawing.Point(6, 62);
            this.lbl_NomePai.Name = "lbl_NomePai";
            this.lbl_NomePai.Size = new System.Drawing.Size(35, 13);
            this.lbl_NomePai.TabIndex = 4;
            this.lbl_NomePai.Text = "label1";
            // 
            // txt_NomeMae
            // 
            this.txt_NomeMae.Location = new System.Drawing.Point(7, 117);
            this.txt_NomeMae.Name = "txt_NomeMae";
            this.txt_NomeMae.Size = new System.Drawing.Size(503, 20);
            this.txt_NomeMae.TabIndex = 4;
            // 
            // lbl_NomeMae
            // 
            this.lbl_NomeMae.AutoSize = true;
            this.lbl_NomeMae.Location = new System.Drawing.Point(6, 101);
            this.lbl_NomeMae.Name = "lbl_NomeMae";
            this.lbl_NomeMae.Size = new System.Drawing.Size(35, 13);
            this.lbl_NomeMae.TabIndex = 6;
            this.lbl_NomeMae.Text = "label1";
            // 
            // txt_CEP
            // 
            this.txt_CEP.Location = new System.Drawing.Point(6, 32);
            this.txt_CEP.Name = "txt_CEP";
            this.txt_CEP.Size = new System.Drawing.Size(111, 20);
            this.txt_CEP.TabIndex = 7;
            this.txt_CEP.Leave += new System.EventHandler(this.txt_CEP_Leave);
            // 
            // lbl_CEP
            // 
            this.lbl_CEP.AutoSize = true;
            this.lbl_CEP.Location = new System.Drawing.Point(6, 16);
            this.lbl_CEP.Name = "lbl_CEP";
            this.lbl_CEP.Size = new System.Drawing.Size(35, 13);
            this.lbl_CEP.TabIndex = 10;
            this.lbl_CEP.Text = "label1";
            // 
            // txt_Logradouro
            // 
            this.txt_Logradouro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Logradouro.Location = new System.Drawing.Point(123, 32);
            this.txt_Logradouro.Name = "txt_Logradouro";
            this.txt_Logradouro.Size = new System.Drawing.Size(606, 20);
            this.txt_Logradouro.TabIndex = 8;
            // 
            // lbl_Logradouro
            // 
            this.lbl_Logradouro.AutoSize = true;
            this.lbl_Logradouro.Location = new System.Drawing.Point(120, 16);
            this.lbl_Logradouro.Name = "lbl_Logradouro";
            this.lbl_Logradouro.Size = new System.Drawing.Size(35, 13);
            this.lbl_Logradouro.TabIndex = 12;
            this.lbl_Logradouro.Text = "label1";
            // 
            // txt_Complemento
            // 
            this.txt_Complemento.Location = new System.Drawing.Point(6, 71);
            this.txt_Complemento.Name = "txt_Complemento";
            this.txt_Complemento.Size = new System.Drawing.Size(305, 20);
            this.txt_Complemento.TabIndex = 9;
            // 
            // lbl_Complemento
            // 
            this.lbl_Complemento.AutoSize = true;
            this.lbl_Complemento.Location = new System.Drawing.Point(7, 55);
            this.lbl_Complemento.Name = "lbl_Complemento";
            this.lbl_Complemento.Size = new System.Drawing.Size(35, 13);
            this.lbl_Complemento.TabIndex = 14;
            this.lbl_Complemento.Text = "label1";
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Bairro.Location = new System.Drawing.Point(317, 71);
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(412, 20);
            this.txt_Bairro.TabIndex = 10;
            // 
            // lbl_Bairro
            // 
            this.lbl_Bairro.AutoSize = true;
            this.lbl_Bairro.Location = new System.Drawing.Point(314, 55);
            this.lbl_Bairro.Name = "lbl_Bairro";
            this.lbl_Bairro.Size = new System.Drawing.Size(35, 13);
            this.lbl_Bairro.TabIndex = 16;
            this.lbl_Bairro.Text = "label1";
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Location = new System.Drawing.Point(314, 94);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(35, 13);
            this.lbl_Estado.TabIndex = 18;
            this.lbl_Estado.Text = "label1";
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Location = new System.Drawing.Point(6, 32);
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(328, 20);
            this.txt_Telefone.TabIndex = 13;
            // 
            // lbl_Telefone
            // 
            this.lbl_Telefone.AutoSize = true;
            this.lbl_Telefone.Location = new System.Drawing.Point(6, 16);
            this.lbl_Telefone.Name = "lbl_Telefone";
            this.lbl_Telefone.Size = new System.Drawing.Size(35, 13);
            this.lbl_Telefone.TabIndex = 20;
            this.lbl_Telefone.Text = "label1";
            // 
            // txt_Profissao
            // 
            this.txt_Profissao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Profissao.Location = new System.Drawing.Point(340, 32);
            this.txt_Profissao.Name = "txt_Profissao";
            this.txt_Profissao.Size = new System.Drawing.Size(389, 20);
            this.txt_Profissao.TabIndex = 14;
            // 
            // lbl_Profissao
            // 
            this.lbl_Profissao.AutoSize = true;
            this.lbl_Profissao.Location = new System.Drawing.Point(339, 16);
            this.lbl_Profissao.Name = "lbl_Profissao";
            this.lbl_Profissao.Size = new System.Drawing.Size(35, 13);
            this.lbl_Profissao.TabIndex = 22;
            this.lbl_Profissao.Text = "label1";
            // 
            // txt_RendaFamiliar
            // 
            this.txt_RendaFamiliar.Location = new System.Drawing.Point(6, 72);
            this.txt_RendaFamiliar.Name = "txt_RendaFamiliar";
            this.txt_RendaFamiliar.Size = new System.Drawing.Size(328, 20);
            this.txt_RendaFamiliar.TabIndex = 15;
            // 
            // lbl_RendaFamiliar
            // 
            this.lbl_RendaFamiliar.AutoSize = true;
            this.lbl_RendaFamiliar.Location = new System.Drawing.Point(6, 56);
            this.lbl_RendaFamiliar.Name = "lbl_RendaFamiliar";
            this.lbl_RendaFamiliar.Size = new System.Drawing.Size(35, 13);
            this.lbl_RendaFamiliar.TabIndex = 24;
            this.lbl_RendaFamiliar.Text = "label1";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(6, 19);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(268, 20);
            this.txt_Codigo.TabIndex = 1;
            // 
            // grp_Codigo
            // 
            this.grp_Codigo.Controls.Add(this.btn_Busca);
            this.grp_Codigo.Controls.Add(this.txt_Codigo);
            this.grp_Codigo.Location = new System.Drawing.Point(10, 28);
            this.grp_Codigo.Name = "grp_Codigo";
            this.grp_Codigo.Size = new System.Drawing.Size(349, 51);
            this.grp_Codigo.TabIndex = 28;
            this.grp_Codigo.TabStop = false;
            this.grp_Codigo.Text = "groupBox1";
            // 
            // btn_Busca
            // 
            this.btn_Busca.Location = new System.Drawing.Point(274, 17);
            this.btn_Busca.Name = "btn_Busca";
            this.btn_Busca.Size = new System.Drawing.Size(69, 24);
            this.btn_Busca.TabIndex = 2;
            this.btn_Busca.Text = "button1";
            this.btn_Busca.UseVisualStyleBackColor = true;
            this.btn_Busca.Click += new System.EventHandler(this.btn_Busca_Click);
            // 
            // grp_DadosPessoais
            // 
            this.grp_DadosPessoais.Controls.Add(this.grp_Genero);
            this.grp_DadosPessoais.Controls.Add(this.grp_TemPai);
            this.grp_DadosPessoais.Controls.Add(this.lbl_NomeCliente);
            this.grp_DadosPessoais.Controls.Add(this.txt_NomeCliente);
            this.grp_DadosPessoais.Controls.Add(this.lbl_NomePai);
            this.grp_DadosPessoais.Controls.Add(this.txt_NomePai);
            this.grp_DadosPessoais.Controls.Add(this.lbl_NomeMae);
            this.grp_DadosPessoais.Controls.Add(this.txt_NomeMae);
            this.grp_DadosPessoais.Controls.Add(this.lbl_CPF);
            this.grp_DadosPessoais.Controls.Add(this.txt_CPF);
            this.grp_DadosPessoais.Location = new System.Drawing.Point(10, 85);
            this.grp_DadosPessoais.Name = "grp_DadosPessoais";
            this.grp_DadosPessoais.Size = new System.Drawing.Size(738, 196);
            this.grp_DadosPessoais.TabIndex = 29;
            this.grp_DadosPessoais.TabStop = false;
            this.grp_DadosPessoais.Text = "groupBox1";
            // 
            // grp_Genero
            // 
            this.grp_Genero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_Genero.Controls.Add(this.rdb_Indefinido);
            this.grp_Genero.Controls.Add(this.rdb_Feminino);
            this.grp_Genero.Controls.Add(this.rdb_Masculino);
            this.grp_Genero.Location = new System.Drawing.Point(342, 140);
            this.grp_Genero.Name = "grp_Genero";
            this.grp_Genero.Size = new System.Drawing.Size(390, 38);
            this.grp_Genero.TabIndex = 37;
            this.grp_Genero.TabStop = false;
            // 
            // rdb_Indefinido
            // 
            this.rdb_Indefinido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rdb_Indefinido.AutoSize = true;
            this.rdb_Indefinido.Location = new System.Drawing.Point(280, 15);
            this.rdb_Indefinido.Name = "rdb_Indefinido";
            this.rdb_Indefinido.Size = new System.Drawing.Size(85, 17);
            this.rdb_Indefinido.TabIndex = 34;
            this.rdb_Indefinido.TabStop = true;
            this.rdb_Indefinido.Text = "radioButton7";
            this.rdb_Indefinido.UseVisualStyleBackColor = true;
            // 
            // rdb_Feminino
            // 
            this.rdb_Feminino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_Feminino.AutoSize = true;
            this.rdb_Feminino.Location = new System.Drawing.Point(155, 15);
            this.rdb_Feminino.Name = "rdb_Feminino";
            this.rdb_Feminino.Size = new System.Drawing.Size(85, 17);
            this.rdb_Feminino.TabIndex = 32;
            this.rdb_Feminino.TabStop = true;
            this.rdb_Feminino.Text = "radioButton5";
            this.rdb_Feminino.UseVisualStyleBackColor = true;
            // 
            // rdb_Masculino
            // 
            this.rdb_Masculino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_Masculino.AutoSize = true;
            this.rdb_Masculino.Location = new System.Drawing.Point(34, 15);
            this.rdb_Masculino.Name = "rdb_Masculino";
            this.rdb_Masculino.Size = new System.Drawing.Size(85, 17);
            this.rdb_Masculino.TabIndex = 33;
            this.rdb_Masculino.TabStop = true;
            this.rdb_Masculino.Text = "radioButton6";
            this.rdb_Masculino.UseVisualStyleBackColor = true;
            // 
            // grp_TemPai
            // 
            this.grp_TemPai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_TemPai.Controls.Add(this.chk_TemPai);
            this.grp_TemPai.Location = new System.Drawing.Point(516, 65);
            this.grp_TemPai.Name = "grp_TemPai";
            this.grp_TemPai.Size = new System.Drawing.Size(216, 72);
            this.grp_TemPai.TabIndex = 9;
            this.grp_TemPai.TabStop = false;
            // 
            // chk_TemPai
            // 
            this.chk_TemPai.AutoSize = true;
            this.chk_TemPai.Location = new System.Drawing.Point(30, 32);
            this.chk_TemPai.Name = "chk_TemPai";
            this.chk_TemPai.Size = new System.Drawing.Size(80, 17);
            this.chk_TemPai.TabIndex = 0;
            this.chk_TemPai.Text = "checkBox1";
            this.chk_TemPai.UseVisualStyleBackColor = true;
            this.chk_TemPai.CheckedChanged += new System.EventHandler(this.chk_TemPai_CheckedChanged);
            // 
            // grp_Endereco
            // 
            this.grp_Endereco.Controls.Add(this.cmb_Estados);
            this.grp_Endereco.Controls.Add(this.lbl_Cidade);
            this.grp_Endereco.Controls.Add(this.txt_Cidade);
            this.grp_Endereco.Controls.Add(this.lbl_CEP);
            this.grp_Endereco.Controls.Add(this.txt_CEP);
            this.grp_Endereco.Controls.Add(this.lbl_Logradouro);
            this.grp_Endereco.Controls.Add(this.txt_Logradouro);
            this.grp_Endereco.Controls.Add(this.lbl_Complemento);
            this.grp_Endereco.Controls.Add(this.txt_Complemento);
            this.grp_Endereco.Controls.Add(this.lbl_Bairro);
            this.grp_Endereco.Controls.Add(this.txt_Bairro);
            this.grp_Endereco.Controls.Add(this.lbl_Estado);
            this.grp_Endereco.Location = new System.Drawing.Point(10, 287);
            this.grp_Endereco.Name = "grp_Endereco";
            this.grp_Endereco.Size = new System.Drawing.Size(738, 145);
            this.grp_Endereco.TabIndex = 30;
            this.grp_Endereco.TabStop = false;
            this.grp_Endereco.Text = "groupBox1";
            // 
            // cmb_Estados
            // 
            this.cmb_Estados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Estados.FormattingEnabled = true;
            this.cmb_Estados.Location = new System.Drawing.Point(317, 109);
            this.cmb_Estados.Name = "cmb_Estados";
            this.cmb_Estados.Size = new System.Drawing.Size(412, 21);
            this.cmb_Estados.TabIndex = 21;
            // 
            // lbl_Cidade
            // 
            this.lbl_Cidade.AutoSize = true;
            this.lbl_Cidade.Location = new System.Drawing.Point(7, 94);
            this.lbl_Cidade.Name = "lbl_Cidade";
            this.lbl_Cidade.Size = new System.Drawing.Size(35, 13);
            this.lbl_Cidade.TabIndex = 20;
            this.lbl_Cidade.Text = "label1";
            // 
            // txt_Cidade
            // 
            this.txt_Cidade.Location = new System.Drawing.Point(6, 110);
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.Size = new System.Drawing.Size(305, 20);
            this.txt_Cidade.TabIndex = 11;
            // 
            // grp_Outros
            // 
            this.grp_Outros.Controls.Add(this.lbl_Telefone);
            this.grp_Outros.Controls.Add(this.txt_Telefone);
            this.grp_Outros.Controls.Add(this.lbl_Profissao);
            this.grp_Outros.Controls.Add(this.txt_Profissao);
            this.grp_Outros.Controls.Add(this.txt_RendaFamiliar);
            this.grp_Outros.Controls.Add(this.lbl_RendaFamiliar);
            this.grp_Outros.Location = new System.Drawing.Point(10, 437);
            this.grp_Outros.Name = "grp_Outros";
            this.grp_Outros.Size = new System.Drawing.Size(738, 100);
            this.grp_Outros.TabIndex = 31;
            this.grp_Outros.TabStop = false;
            this.grp_Outros.Text = "groupBox1";
            // 
            // tls_Principal
            // 
            this.tls_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripButton1,
            this.abrirToolStripButton1,
            this.salvarToolStripButton1,
            this.ApagatoolStripButton,
            this.LimpartoolStripButton,
            this.imprimirToolStripButton1,
            this.toolStripSeparator2,
            this.recortarToolStripButton,
            this.copiarToolStripButton,
            this.colarToolStripButton,
            this.toolStripSeparator3,
            this.ajudaToolStripButton});
            this.tls_Principal.Location = new System.Drawing.Point(0, 0);
            this.tls_Principal.Name = "tls_Principal";
            this.tls_Principal.Size = new System.Drawing.Size(1185, 25);
            this.tls_Principal.TabIndex = 32;
            this.tls_Principal.Text = "toolStrip1";
            // 
            // novoToolStripButton1
            // 
            this.novoToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.novoToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripButton1.Image")));
            this.novoToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novoToolStripButton1.Name = "novoToolStripButton1";
            this.novoToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.novoToolStripButton1.Text = "&Novo";
            this.novoToolStripButton1.Click += new System.EventHandler(this.novoToolStripButton1_Click);
            // 
            // abrirToolStripButton1
            // 
            this.abrirToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.abrirToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripButton1.Image")));
            this.abrirToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripButton1.Name = "abrirToolStripButton1";
            this.abrirToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.abrirToolStripButton1.Text = "&Abrir";
            this.abrirToolStripButton1.Click += new System.EventHandler(this.abrirToolStripButton1_Click);
            // 
            // salvarToolStripButton1
            // 
            this.salvarToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvarToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton1.Image")));
            this.salvarToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton1.Name = "salvarToolStripButton1";
            this.salvarToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.salvarToolStripButton1.Text = "&Salvar";
            this.salvarToolStripButton1.Click += new System.EventHandler(this.salvarToolStripButton1_Click);
            // 
            // ApagatoolStripButton
            // 
            this.ApagatoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ApagatoolStripButton.Image = global::CursoWindowsForms.Properties.Resources.ExcluirBarra;
            this.ApagatoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ApagatoolStripButton.Name = "ApagatoolStripButton";
            this.ApagatoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ApagatoolStripButton.Text = "toolStripButton1";
            this.ApagatoolStripButton.Click += new System.EventHandler(this.ApagatoolStripButton_Click);
            // 
            // LimpartoolStripButton
            // 
            this.LimpartoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LimpartoolStripButton.Image = global::CursoWindowsForms.Properties.Resources.LimparBarra;
            this.LimpartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LimpartoolStripButton.Name = "LimpartoolStripButton";
            this.LimpartoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.LimpartoolStripButton.Text = "toolStripButton1";
            this.LimpartoolStripButton.Click += new System.EventHandler(this.LimpartoolStripButton_Click);
            // 
            // imprimirToolStripButton1
            // 
            this.imprimirToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imprimirToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripButton1.Image")));
            this.imprimirToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimirToolStripButton1.Name = "imprimirToolStripButton1";
            this.imprimirToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.imprimirToolStripButton1.Text = "&Imprimir";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // recortarToolStripButton
            // 
            this.recortarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.recortarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("recortarToolStripButton.Image")));
            this.recortarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.recortarToolStripButton.Name = "recortarToolStripButton";
            this.recortarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.recortarToolStripButton.Text = "Recor&tar";
            // 
            // copiarToolStripButton
            // 
            this.copiarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copiarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripButton.Image")));
            this.copiarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiarToolStripButton.Name = "copiarToolStripButton";
            this.copiarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copiarToolStripButton.Text = "&Copiar";
            // 
            // colarToolStripButton
            // 
            this.colarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("colarToolStripButton.Image")));
            this.colarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colarToolStripButton.Name = "colarToolStripButton";
            this.colarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.colarToolStripButton.Text = "C&olar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // ajudaToolStripButton
            // 
            this.ajudaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ajudaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ajudaToolStripButton.Image")));
            this.ajudaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ajudaToolStripButton.Name = "ajudaToolStripButton";
            this.ajudaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ajudaToolStripButton.Text = "&Ajuda";
            // 
            // grp_DataGrid
            // 
            this.grp_DataGrid.Controls.Add(this.dg_Clientes);
            this.grp_DataGrid.Location = new System.Drawing.Point(754, 85);
            this.grp_DataGrid.Name = "grp_DataGrid";
            this.grp_DataGrid.Size = new System.Drawing.Size(419, 452);
            this.grp_DataGrid.TabIndex = 33;
            this.grp_DataGrid.TabStop = false;
            this.grp_DataGrid.Text = "groupBox1";
            // 
            // dg_Clientes
            // 
            this.dg_Clientes.AllowUserToAddRows = false;
            this.dg_Clientes.AllowUserToDeleteRows = false;
            this.dg_Clientes.AllowUserToOrderColumns = true;
            this.dg_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome});
            this.dg_Clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_Clientes.Location = new System.Drawing.Point(3, 16);
            this.dg_Clientes.MultiSelect = false;
            this.dg_Clientes.Name = "dg_Clientes";
            this.dg_Clientes.ReadOnly = true;
            this.dg_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Clientes.Size = new System.Drawing.Size(413, 433);
            this.dg_Clientes.TabIndex = 0;
            this.dg_Clientes.DoubleClick += new System.EventHandler(this.dg_Clientes_DoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Código Cliente";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 120;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome do Cliente";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 250;
            // 
            // frm_CadastroCliente_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grp_DataGrid);
            this.Controls.Add(this.tls_Principal);
            this.Controls.Add(this.grp_Outros);
            this.Controls.Add(this.grp_Endereco);
            this.Controls.Add(this.grp_DadosPessoais);
            this.Controls.Add(this.grp_Codigo);
            this.Name = "frm_CadastroCliente_UC";
            this.Size = new System.Drawing.Size(1185, 552);
            this.grp_Codigo.ResumeLayout(false);
            this.grp_Codigo.PerformLayout();
            this.grp_DadosPessoais.ResumeLayout(false);
            this.grp_DadosPessoais.PerformLayout();
            this.grp_Genero.ResumeLayout(false);
            this.grp_Genero.PerformLayout();
            this.grp_TemPai.ResumeLayout(false);
            this.grp_TemPai.PerformLayout();
            this.grp_Endereco.ResumeLayout(false);
            this.grp_Endereco.PerformLayout();
            this.grp_Outros.ResumeLayout(false);
            this.grp_Outros.PerformLayout();
            this.tls_Principal.ResumeLayout(false);
            this.tls_Principal.PerformLayout();
            this.grp_DataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CPF;
        private System.Windows.Forms.TextBox txt_CPF;
        private System.Windows.Forms.TextBox txt_NomeCliente;
        private System.Windows.Forms.Label lbl_NomeCliente;
        private System.Windows.Forms.TextBox txt_NomePai;
        private System.Windows.Forms.Label lbl_NomePai;
        private System.Windows.Forms.TextBox txt_NomeMae;
        private System.Windows.Forms.Label lbl_NomeMae;
        private System.Windows.Forms.TextBox txt_CEP;
        private System.Windows.Forms.Label lbl_CEP;
        private System.Windows.Forms.TextBox txt_Logradouro;
        private System.Windows.Forms.Label lbl_Logradouro;
        private System.Windows.Forms.TextBox txt_Complemento;
        private System.Windows.Forms.Label lbl_Complemento;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.Label lbl_Bairro;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.TextBox txt_Telefone;
        private System.Windows.Forms.Label lbl_Telefone;
        private System.Windows.Forms.TextBox txt_Profissao;
        private System.Windows.Forms.Label lbl_Profissao;
        private System.Windows.Forms.TextBox txt_RendaFamiliar;
        private System.Windows.Forms.Label lbl_RendaFamiliar;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.GroupBox grp_Codigo;
        private System.Windows.Forms.GroupBox grp_DadosPessoais;
        private System.Windows.Forms.GroupBox grp_Endereco;
        private System.Windows.Forms.GroupBox grp_Outros;
        private System.Windows.Forms.Label lbl_Cidade;
        private System.Windows.Forms.TextBox txt_Cidade;
        private System.Windows.Forms.GroupBox grp_TemPai;
        private System.Windows.Forms.CheckBox chk_TemPai;
        private System.Windows.Forms.GroupBox grp_Genero;
        private System.Windows.Forms.RadioButton rdb_Indefinido;
        private System.Windows.Forms.RadioButton rdb_Feminino;
        private System.Windows.Forms.RadioButton rdb_Masculino;
        private System.Windows.Forms.ComboBox cmb_Estados;
        private System.Windows.Forms.ToolStrip tls_Principal;
        private System.Windows.Forms.ToolStripButton novoToolStripButton1;
        private System.Windows.Forms.ToolStripButton abrirToolStripButton1;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton1;
        private System.Windows.Forms.ToolStripButton imprimirToolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton recortarToolStripButton;
        private System.Windows.Forms.ToolStripButton copiarToolStripButton;
        private System.Windows.Forms.ToolStripButton colarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ajudaToolStripButton;
        private System.Windows.Forms.ToolStripButton ApagatoolStripButton;
        private System.Windows.Forms.ToolStripButton LimpartoolStripButton;
        private System.Windows.Forms.Button btn_Busca;
        private System.Windows.Forms.GroupBox grp_DataGrid;
        private System.Windows.Forms.DataGridView dg_Clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    }
}
