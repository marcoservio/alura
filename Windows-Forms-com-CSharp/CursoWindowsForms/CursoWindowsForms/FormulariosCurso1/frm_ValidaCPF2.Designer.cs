namespace CursoWindowsForms
{
    partial class frm_ValidaCPF2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ValidaCPF2));
            this.msk_CPF = new System.Windows.Forms.MaskedTextBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Valida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msk_CPF
            // 
            this.msk_CPF.Location = new System.Drawing.Point(12, 26);
            this.msk_CPF.Mask = "000,000,000-00";
            this.msk_CPF.Name = "msk_CPF";
            this.msk_CPF.Size = new System.Drawing.Size(92, 20);
            this.msk_CPF.TabIndex = 0;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(123, 23);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(111, 23);
            this.btn_Reset.TabIndex = 2;
            this.btn_Reset.Text = "Limpa";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Valida
            // 
            this.btn_Valida.Location = new System.Drawing.Point(123, 52);
            this.btn_Valida.Name = "btn_Valida";
            this.btn_Valida.Size = new System.Drawing.Size(111, 23);
            this.btn_Valida.TabIndex = 3;
            this.btn_Valida.Text = "Valida";
            this.btn_Valida.UseVisualStyleBackColor = true;
            this.btn_Valida.Click += new System.EventHandler(this.btn_Valida_Click);
            // 
            // frm_ValidaCPF2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 97);
            this.Controls.Add(this.btn_Valida);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.msk_CPF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_ValidaCPF2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validação CPF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox msk_CPF;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Valida;
    }
}