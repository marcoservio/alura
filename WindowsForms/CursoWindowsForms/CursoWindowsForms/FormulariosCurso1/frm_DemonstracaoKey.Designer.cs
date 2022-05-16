namespace CursoWindowsForms
{
    partial class frm_DemonstracaoKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DemonstracaoKey));
            this.txt_Imput = new System.Windows.Forms.TextBox();
            this.txt_Msg = new System.Windows.Forms.TextBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.lbl_Minus = new System.Windows.Forms.Label();
            this.lbl_Maius = new System.Windows.Forms.Label();
            this.lbl_Uper = new System.Windows.Forms.Label();
            this.lbl_Lower = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Imput
            // 
            this.txt_Imput.Location = new System.Drawing.Point(8, 8);
            this.txt_Imput.Name = "txt_Imput";
            this.txt_Imput.Size = new System.Drawing.Size(100, 20);
            this.txt_Imput.TabIndex = 0;
            this.txt_Imput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Imput_KeyDown);
            // 
            // txt_Msg
            // 
            this.txt_Msg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Msg.Location = new System.Drawing.Point(8, 40);
            this.txt_Msg.Multiline = true;
            this.txt_Msg.Name = "txt_Msg";
            this.txt_Msg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Msg.Size = new System.Drawing.Size(304, 232);
            this.txt_Msg.TabIndex = 1;
            this.txt_Msg.TabStop = false;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Reset.Location = new System.Drawing.Point(328, 8);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 28);
            this.btn_Reset.TabIndex = 2;
            this.btn_Reset.Text = "Limpa";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // lbl_Minus
            // 
            this.lbl_Minus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Minus.AutoSize = true;
            this.lbl_Minus.Location = new System.Drawing.Point(320, 104);
            this.lbl_Minus.Name = "lbl_Minus";
            this.lbl_Minus.Size = new System.Drawing.Size(38, 13);
            this.lbl_Minus.TabIndex = 3;
            this.lbl_Minus.Text = "Minus.";
            // 
            // lbl_Maius
            // 
            this.lbl_Maius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Maius.AutoSize = true;
            this.lbl_Maius.Location = new System.Drawing.Point(320, 56);
            this.lbl_Maius.Name = "lbl_Maius";
            this.lbl_Maius.Size = new System.Drawing.Size(38, 13);
            this.lbl_Maius.TabIndex = 4;
            this.lbl_Maius.Text = "Maius.";
            // 
            // lbl_Uper
            // 
            this.lbl_Uper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Uper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Uper.Location = new System.Drawing.Point(364, 56);
            this.lbl_Uper.Name = "lbl_Uper";
            this.lbl_Uper.Size = new System.Drawing.Size(32, 23);
            this.lbl_Uper.TabIndex = 5;
            // 
            // lbl_Lower
            // 
            this.lbl_Lower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Lower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Lower.Location = new System.Drawing.Point(368, 104);
            this.lbl_Lower.Name = "lbl_Lower";
            this.lbl_Lower.Size = new System.Drawing.Size(32, 23);
            this.lbl_Lower.TabIndex = 6;
            // 
            // frm_DemonstracaoKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 281);
            this.Controls.Add(this.lbl_Lower);
            this.Controls.Add(this.lbl_Uper);
            this.Controls.Add(this.lbl_Maius);
            this.Controls.Add(this.lbl_Minus);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.txt_Msg);
            this.Controls.Add(this.txt_Imput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_DemonstracaoKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demonstração Evento Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Imput;
        private System.Windows.Forms.TextBox txt_Msg;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label lbl_Minus;
        private System.Windows.Forms.Label lbl_Maius;
        private System.Windows.Forms.Label lbl_Uper;
        private System.Windows.Forms.Label lbl_Lower;
    }
}