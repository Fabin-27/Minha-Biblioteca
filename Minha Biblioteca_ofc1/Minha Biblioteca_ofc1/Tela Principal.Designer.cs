namespace Minha_Biblioteca_ofc1
{
    partial class Tela_Principal
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
            if (disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Principal));
            btn_Cadastrar = new Button();
            btn_Consultar = new Button();
            btn_Sair = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.BackColor = Color.Gainsboro;
            btn_Cadastrar.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold);
            btn_Cadastrar.Location = new Point(22, 181);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(312, 82);
            btn_Cadastrar.TabIndex = 0;
            btn_Cadastrar.Text = "Cadastrar Novo Cliente";
            btn_Cadastrar.UseVisualStyleBackColor = false;
            btn_Cadastrar.Click += btn_Cadastrar_Click;
            // 
            // btn_Consultar
            // 
            btn_Consultar.BackColor = Color.Gainsboro;
            btn_Consultar.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold);
            btn_Consultar.Location = new Point(22, 283);
            btn_Consultar.Name = "btn_Consultar";
            btn_Consultar.Size = new Size(312, 77);
            btn_Consultar.TabIndex = 1;
            btn_Consultar.Text = "Consultar Cliente já Existente";
            btn_Consultar.UseVisualStyleBackColor = false;
            btn_Consultar.Click += btn_Consultar_Click;
            // 
            // btn_Sair
            // 
            btn_Sair.BackColor = Color.Gainsboro;
            btn_Sair.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold);
            btn_Sair.Location = new Point(22, 381);
            btn_Sair.Name = "btn_Sair";
            btn_Sair.Size = new Size(312, 57);
            btn_Sair.TabIndex = 2;
            btn_Sair.Text = "Sair";
            btn_Sair.UseVisualStyleBackColor = false;
            btn_Sair.Click += btn_Sair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(68, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Tela_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(362, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Sair);
            Controls.Add(btn_Consultar);
            Controls.Add(btn_Cadastrar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Tela_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela_Principal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Cadastrar;
        private Button btn_Consultar;
        private Button btn_Sair;
        private PictureBox pictureBox1;
    }
}