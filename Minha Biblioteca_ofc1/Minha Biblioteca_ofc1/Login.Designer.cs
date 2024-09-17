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
            SuspendLayout();
            // 
            // txb_Senha
            // 
            txb_Senha.Location = new Point(330, 179);
            txb_Senha.Name = "txb_Senha";
            txb_Senha.Size = new Size(215, 23);
            txb_Senha.TabIndex = 1;
            // 
            // txb_Usuario
            // 
            txb_Usuario.Location = new Point(330, 150);
            txb_Usuario.Name = "txb_Usuario";
            txb_Usuario.Size = new Size(215, 23);
            txb_Usuario.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(249, 153);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Usuário";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(249, 182);
            label.Name = "label";
            label.Size = new Size(39, 15);
            label.TabIndex = 4;
            label.Text = "Senha";
            // 
            // btn_Logar
            // 
            btn_Logar.Location = new Point(249, 239);
            btn_Logar.Name = "btn_Logar";
            btn_Logar.Size = new Size(296, 55);
            btn_Logar.TabIndex = 6;
            btn_Logar.Text = "Login";
            btn_Logar.UseVisualStyleBackColor = true;
            btn_Logar.Click += btn_Logar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Logar);
            Controls.Add(label);
            Controls.Add(label1);
            Controls.Add(txb_Usuario);
            Controls.Add(txb_Senha);
            Name = "Login";
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
    }
}
