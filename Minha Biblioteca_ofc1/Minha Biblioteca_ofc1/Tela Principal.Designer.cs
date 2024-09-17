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
            btn_Cadastrar = new Button();
            btn_Consultar = new Button();
            btn_Sair = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.Location = new Point(21, 197);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(312, 60);
            btn_Cadastrar.TabIndex = 0;
            btn_Cadastrar.Text = "Cadastrar Novo Cliente";
            btn_Cadastrar.UseVisualStyleBackColor = true;
            btn_Cadastrar.Click += btn_Cadastrar_Click;
            // 
            // btn_Consultar
            // 
            btn_Consultar.Location = new Point(21, 282);
            btn_Consultar.Name = "btn_Consultar";
            btn_Consultar.Size = new Size(312, 60);
            btn_Consultar.TabIndex = 1;
            btn_Consultar.Text = "Consultar Cliente já Existente";
            btn_Consultar.UseVisualStyleBackColor = true;
            btn_Consultar.Click += btn_Consultar_Click;
            // 
            // btn_Sair
            // 
            btn_Sair.Location = new Point(21, 358);
            btn_Sair.Name = "btn_Sair";
            btn_Sair.Size = new Size(312, 60);
            btn_Sair.TabIndex = 2;
            btn_Sair.Text = "Sair";
            btn_Sair.UseVisualStyleBackColor = true;
            btn_Sair.Click += btn_Sair_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(83, 72);
            label1.MinimumSize = new Size(250, 0);
            label1.Name = "label1";
            label1.Size = new Size(250, 47);
            label1.TabIndex = 3;
            label1.Text = "Biblioteca";
            // 
            // Tela_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(362, 450);
            Controls.Add(label1);
            Controls.Add(btn_Sair);
            Controls.Add(btn_Consultar);
            Controls.Add(btn_Cadastrar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Tela_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela_Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Cadastrar;
        private Button btn_Consultar;
        private Button btn_Sair;
        private Label label1;
    }
}