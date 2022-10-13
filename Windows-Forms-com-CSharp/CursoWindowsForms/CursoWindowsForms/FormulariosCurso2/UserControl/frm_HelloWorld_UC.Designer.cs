namespace CursoWindowsForms
{
    partial class frm_HelloWorld_UC
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
            this.txt_ConteudoLabel = new System.Windows.Forms.TextBox();
            this.btn_ModficaLabel = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_ConteudoLabel
            // 
            this.txt_ConteudoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ConteudoLabel.Location = new System.Drawing.Point(22, 71);
            this.txt_ConteudoLabel.Name = "txt_ConteudoLabel";
            this.txt_ConteudoLabel.Size = new System.Drawing.Size(490, 20);
            this.txt_ConteudoLabel.TabIndex = 6;
            // 
            // btn_ModficaLabel
            // 
            this.btn_ModficaLabel.Location = new System.Drawing.Point(22, 41);
            this.btn_ModficaLabel.Name = "btn_ModficaLabel";
            this.btn_ModficaLabel.Size = new System.Drawing.Size(202, 23);
            this.btn_ModficaLabel.TabIndex = 5;
            this.btn_ModficaLabel.Text = "Modifica Texto do Label";
            this.btn_ModficaLabel.UseVisualStyleBackColor = true;
            this.btn_ModficaLabel.Click += new System.EventHandler(this.btn_ModficaLabel_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(18, 19);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(206, 19);
            this.lbl_Titulo.TabIndex = 4;
            this.lbl_Titulo.Text = "Visual Studio .Net Version";
            // 
            // frm_HelloWorld_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_ConteudoLabel);
            this.Controls.Add(this.btn_ModficaLabel);
            this.Controls.Add(this.lbl_Titulo);
            this.Name = "frm_HelloWorld_UC";
            this.Size = new System.Drawing.Size(537, 330);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ConteudoLabel;
        private System.Windows.Forms.Button btn_ModficaLabel;
        private System.Windows.Forms.Label lbl_Titulo;
    }
}
