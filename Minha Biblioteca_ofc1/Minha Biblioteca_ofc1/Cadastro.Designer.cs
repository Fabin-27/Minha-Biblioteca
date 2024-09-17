namespace Minha_Biblioteca_ofc1
{
    partial class Cadastro
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
            Endereço = new TextBox();
            Telefone = new TextBox();
            Email = new TextBox();
            CPF = new TextBox();
            Nome = new TextBox();
            btn_Limpar = new Button();
            btn_Cancelar = new Button();
            btn_Salvar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Lista = new ListBox();
            SuspendLayout();
            // 
            // Endereço
            // 
            Endereço.Location = new Point(76, 155);
            Endereço.Name = "Endereço";
            Endereço.Size = new Size(334, 23);
            Endereço.TabIndex = 28;
            // 
            // Telefone
            // 
            Telefone.Location = new Point(76, 125);
            Telefone.Name = "Telefone";
            Telefone.Size = new Size(334, 23);
            Telefone.TabIndex = 27;
            // 
            // Email
            // 
            Email.Location = new Point(76, 96);
            Email.Name = "Email";
            Email.Size = new Size(334, 23);
            Email.TabIndex = 26;
            // 
            // CPF
            // 
            CPF.Location = new Point(76, 69);
            CPF.Name = "CPF";
            CPF.Size = new Size(334, 23);
            CPF.TabIndex = 25;
            // 
            // Nome
            // 
            Nome.Location = new Point(76, 39);
            Nome.Name = "Nome";
            Nome.Size = new Size(334, 23);
            Nome.TabIndex = 24;
            // 
            // btn_Limpar
            // 
            btn_Limpar.Location = new Point(564, 91);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(75, 23);
            btn_Limpar.TabIndex = 23;
            btn_Limpar.Text = "Limpar";
            btn_Limpar.TextAlign = ContentAlignment.TopCenter;
            btn_Limpar.UseVisualStyleBackColor = true;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(564, 120);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(75, 23);
            btn_Cancelar.TabIndex = 22;
            btn_Cancelar.Text = "Voltar";
            btn_Cancelar.TextAlign = ContentAlignment.TopCenter;
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Salvar
            // 
            btn_Salvar.Location = new Point(564, 62);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(75, 23);
            btn_Salvar.TabIndex = 21;
            btn_Salvar.Text = "Salvar";
            btn_Salvar.TextAlign = ContentAlignment.TopCenter;
            btn_Salvar.UseVisualStyleBackColor = true;
            btn_Salvar.Click += btn_Salvar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 99);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 20;
            label5.Text = "E-mail";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 128);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 19;
            label4.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 158);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 18;
            label3.Text = "Endereço";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 72);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 17;
            label2.Text = "CPF";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 42);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 16;
            label1.Text = "Nome";
            // 
            // Lista
            // 
            Lista.FormattingEnabled = true;
            Lista.ItemHeight = 15;
            Lista.Location = new Point(12, 194);
            Lista.Name = "Lista";
            Lista.Size = new Size(776, 244);
            Lista.TabIndex = 29;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(Lista);
            Controls.Add(Endereço);
            Controls.Add(Telefone);
            Controls.Add(Email);
            Controls.Add(CPF);
            Controls.Add(Nome);
            Controls.Add(btn_Limpar);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Salvar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox Endereço;
        public TextBox Telefone;
        public TextBox Email;
        public TextBox CPF;
        public TextBox Nome;
        private Button btn_Limpar;
        private Button btn_Cancelar;
        private Button btn_Salvar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox Lista;
    }
}