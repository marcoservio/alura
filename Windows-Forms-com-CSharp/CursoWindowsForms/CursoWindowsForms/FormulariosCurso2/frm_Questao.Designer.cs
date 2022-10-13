namespace CursoWindowsForms
{
    partial class frm_Questao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Questao));
            this.lbl_Questao = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.pic_Imagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Questao
            // 
            this.lbl_Questao.AutoSize = true;
            this.lbl_Questao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Questao.Location = new System.Drawing.Point(29, 19);
            this.lbl_Questao.Name = "lbl_Questao";
            this.lbl_Questao.Size = new System.Drawing.Size(229, 20);
            this.lbl_Questao.TabIndex = 0;
            this.lbl_Questao.Text = "Você deseja validar o CPF?";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(152, 72);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(115, 23);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "Sim. Continue";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(152, 101);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(115, 23);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Não. Pare";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // pic_Imagem
            // 
            this.pic_Imagem.Image = ((System.Drawing.Image)(resources.GetObject("pic_Imagem.Image")));
            this.pic_Imagem.Location = new System.Drawing.Point(33, 61);
            this.pic_Imagem.Name = "pic_Imagem";
            this.pic_Imagem.Size = new System.Drawing.Size(75, 69);
            this.pic_Imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_Imagem.TabIndex = 3;
            this.pic_Imagem.TabStop = false;
            // 
            // frm_Questao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 151);
            this.Controls.Add(this.pic_Imagem);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.lbl_Questao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Questao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questão";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Questao;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.PictureBox pic_Imagem;
    }
}