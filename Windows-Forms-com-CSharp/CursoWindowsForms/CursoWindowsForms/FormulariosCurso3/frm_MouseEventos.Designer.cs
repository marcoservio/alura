namespace CursoWindowsForms
{
    partial class frm_MouseEventos
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
            this.btn_Mouse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Mouse
            // 
            this.btn_Mouse.Location = new System.Drawing.Point(58, 66);
            this.btn_Mouse.Name = "btn_Mouse";
            this.btn_Mouse.Size = new System.Drawing.Size(256, 100);
            this.btn_Mouse.TabIndex = 0;
            this.btn_Mouse.UseVisualStyleBackColor = true;
            this.btn_Mouse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Mouse_MouseDown);
            this.btn_Mouse.MouseEnter += new System.EventHandler(this.btn_Mouse_MouseEnter);
            this.btn_Mouse.MouseLeave += new System.EventHandler(this.btn_Mouse_MouseLeave);
            this.btn_Mouse.MouseHover += new System.EventHandler(this.btn_Mouse_MouseHover);
            this.btn_Mouse.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Mouse_MouseUp);
            // 
            // frm_MouseEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 239);
            this.Controls.Add(this.btn_Mouse);
            this.Name = "frm_MouseEventos";
            this.Text = "frm_MouseEventos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Mouse;
    }
}