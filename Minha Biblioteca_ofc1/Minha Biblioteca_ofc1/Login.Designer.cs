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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txb_Senha = new TextBox();
            txb_Usuario = new TextBox();
            label1 = new Label();
            label = new Label();
            btn_Logar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txb_Senha
            // 
            txb_Senha.Location = new Point(75, 223);
            txb_Senha.Name = "txb_Senha";
            txb_Senha.Size = new Size(259, 23);
            txb_Senha.TabIndex = 1;
            // 
            // txb_Usuario
            // 
            txb_Usuario.Location = new Point(75, 194);
            txb_Usuario.Name = "txb_Usuario";
            txb_Usuario.Size = new Size(259, 23);
            txb_Usuario.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Bold);
            label1.Location = new Point(11, 197);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 3;
            label1.Text = "Usuário";
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Bold);
            label.Location = new Point(11, 226);
            label.Name = "label";
            label.Size = new Size(48, 21);
            label.TabIndex = 4;
            label.Text = "Senha";
            // 
            // btn_Logar
            // 
            btn_Logar.BackColor = Color.Gainsboro;
            btn_Logar.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Logar.Location = new Point(11, 276);
            btn_Logar.Name = "btn_Logar";
            btn_Logar.Size = new Size(323, 83);
            btn_Logar.TabIndex = 6;
            btn_Logar.Text = "Login";
            btn_Logar.UseVisualStyleBackColor = false;
            btn_Logar.Click += btn_Logar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(59, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(346, 413);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Logar);
            Controls.Add(label);
            Controls.Add(label1);
            Controls.Add(txb_Usuario);
            Controls.Add(txb_Senha);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txb_Senha;
        private TextBox txb_Usuario;
        private Label label1;
        private Label label;
        private Button btn_Logar;
        private PictureBox pictureBox1;
    }
}
