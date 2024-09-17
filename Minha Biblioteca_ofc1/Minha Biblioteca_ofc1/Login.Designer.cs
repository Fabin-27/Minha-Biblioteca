namespace Minha_Biblioteca_ofc1
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txb_Senha = new TextBox();
            txb_Usuario = new TextBox();
            label1 = new Label();
            label = new Label();
            btn_Logar = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // txb_Senha
            // 
            txb_Senha.Location = new Point(130, 164);
            txb_Senha.Name = "txb_Senha";
            txb_Senha.Size = new Size(242, 23);
            txb_Senha.TabIndex = 1;
            // 
            // txb_Usuario
            // 
            txb_Usuario.Location = new Point(130, 135);
            txb_Usuario.Name = "txb_Usuario";
            txb_Usuario.Size = new Size(242, 23);
            txb_Usuario.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 138);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Usuário";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(49, 167);
            label.Name = "label";
            label.Size = new Size(39, 15);
            label.TabIndex = 4;
            label.Text = "Senha";
            // 
            // btn_Logar
            // 
            btn_Logar.Location = new Point(49, 224);
            btn_Logar.Name = "btn_Logar";
            btn_Logar.Size = new Size(323, 83);
            btn_Logar.TabIndex = 6;
            btn_Logar.Text = "Login";
            btn_Logar.UseVisualStyleBackColor = true;
            btn_Logar.Click += btn_Logar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.WindowFrame;
            label2.Location = new Point(122, 59);
            label2.MinimumSize = new Size(250, 0);
            label2.Name = "label2";
            label2.Size = new Size(250, 47);
            label2.TabIndex = 7;
            label2.Text = "Biblioteca";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(424, 435);
            Controls.Add(label2);
            Controls.Add(btn_Logar);
            Controls.Add(label);
            Controls.Add(label1);
            Controls.Add(txb_Usuario);
            Controls.Add(txb_Senha);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txb_Senha;
        private TextBox txb_Usuario;
        private Label label1;
        private Label label;
        private Button btn_Logar;
        private Label label2;
    }
}
