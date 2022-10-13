namespace CursoWindowsForms
{
    partial class frm_DemostracaoKey_UC
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
            this.lbl_Lower = new System.Windows.Forms.Label();
            this.lbl_Uper = new System.Windows.Forms.Label();
            this.lbl_Maius = new System.Windows.Forms.Label();
            this.lbl_Minus = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.txt_Msg = new System.Windows.Forms.TextBox();
            this.txt_Imput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Lower
            // 
            this.lbl_Lower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Lower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Lower.Location = new System.Drawing.Point(421, 120);
            this.lbl_Lower.Name = "lbl_Lower";
            this.lbl_Lower.Size = new System.Drawing.Size(32, 23);
            this.lbl_Lower.TabIndex = 13;
            // 
            // lbl_Uper
            // 
            this.lbl_Uper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Uper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Uper.Location = new System.Drawing.Point(417, 72);
            this.lbl_Uper.Name = "lbl_Uper";
            this.lbl_Uper.Size = new System.Drawing.Size(32, 23);
            this.lbl_Uper.TabIndex = 12;
            // 
            // lbl_Maius
            // 
            this.lbl_Maius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Maius.AutoSize = true;
            this.lbl_Maius.Location = new System.Drawing.Point(373, 72);
            this.lbl_Maius.Name = "lbl_Maius";
            this.lbl_Maius.Size = new System.Drawing.Size(38, 13);
            this.lbl_Maius.TabIndex = 11;
            this.lbl_Maius.Text = "Maius.";
            // 
            // lbl_Minus
            // 
            this.lbl_Minus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Minus.AutoSize = true;
            this.lbl_Minus.Location = new System.Drawing.Point(373, 120);
            this.lbl_Minus.Name = "lbl_Minus";
            this.lbl_Minus.Size = new System.Drawing.Size(38, 13);
            this.lbl_Minus.TabIndex = 10;
            this.lbl_Minus.Text = "Minus.";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Reset.Location = new System.Drawing.Point(376, 23);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 28);
            this.btn_Reset.TabIndex = 9;
            this.btn_Reset.Text = "Limpa";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // txt_Msg
            // 
            this.txt_Msg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Msg.Location = new System.Drawing.Point(20, 55);
            this.txt_Msg.Multiline = true;
            this.txt_Msg.Name = "txt_Msg";
            this.txt_Msg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Msg.Size = new System.Drawing.Size(337, 282);
            this.txt_Msg.TabIndex = 8;
            this.txt_Msg.TabStop = false;
            // 
            // txt_Imput
            // 
            this.txt_Imput.Location = new System.Drawing.Point(20, 23);
            this.txt_Imput.Name = "txt_Imput";
            this.txt_Imput.Size = new System.Drawing.Size(100, 20);
            this.txt_Imput.TabIndex = 7;
            this.txt_Imput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Imput_KeyDown);
            // 
            // frm_DemostracaoKey_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Lower);
            this.Controls.Add(this.lbl_Uper);
            this.Controls.Add(this.lbl_Maius);
            this.Controls.Add(this.lbl_Minus);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.txt_Msg);
            this.Controls.Add(this.txt_Imput);
            this.Name = "frm_DemostracaoKey_UC";
            this.Size = new System.Drawing.Size(472, 368);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Lower;
        private System.Windows.Forms.Label lbl_Uper;
        private System.Windows.Forms.Label lbl_Maius;
        private System.Windows.Forms.Label lbl_Minus;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.TextBox txt_Msg;
        private System.Windows.Forms.TextBox txt_Imput;
    }
}
