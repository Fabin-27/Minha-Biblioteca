namespace Minha_Biblioteca_ofc1
{
    partial class Consulta
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
            Lista = new ListBox();
            CPF = new TextBox();
            Nome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btn_Buscar = new Button();
            btn_Editar = new Button();
            Excluir = new Button();
            btn_Voltar = new Button();
            Endereço = new TextBox();
            Telefone = new TextBox();
            Email = new TextBox();
            CPF_grid = new TextBox();
            Nome_grid = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            dataGridView_Clientes = new DataGridView();
            btn_Pesquisa = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clientes).BeginInit();
            SuspendLayout();
            // 
            // Lista
            // 
            Lista.FormattingEnabled = true;
            Lista.ItemHeight = 15;
            Lista.Location = new Point(292, 209);
            Lista.Name = "Lista";
            Lista.Size = new Size(496, 229);
            Lista.TabIndex = 15;
            Lista.SelectedIndexChanged += Lista_SelectedIndexChanged;
            // 
            // CPF
            // 
            CPF.Location = new Point(454, 42);
            CPF.Name = "CPF";
            CPF.Size = new Size(334, 23);
            CPF.TabIndex = 19;
            // 
            // Nome
            // 
            Nome.Location = new Point(454, 12);
            Nome.Name = "Nome";
            Nome.Size = new Size(334, 23);
            Nome.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(420, 45);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 17;
            label2.Text = "CPF";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(408, 15);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 16;
            label1.Text = "Nome";
            // 
            // btn_Buscar
            // 
            btn_Buscar.Location = new Point(509, 176);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(75, 23);
            btn_Buscar.TabIndex = 20;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // btn_Editar
            // 
            btn_Editar.Location = new Point(590, 176);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(75, 23);
            btn_Editar.TabIndex = 21;
            btn_Editar.Text = "Editar";
            btn_Editar.UseVisualStyleBackColor = true;
            btn_Editar.Click += btn_Editar_Click;
            // 
            // Excluir
            // 
            Excluir.Location = new Point(671, 176);
            Excluir.Name = "Excluir";
            Excluir.Size = new Size(75, 23);
            Excluir.TabIndex = 22;
            Excluir.Text = "Excluir";
            Excluir.UseVisualStyleBackColor = true;
            Excluir.Click += Excluir_Click;
            // 
            // btn_Voltar
            // 
            btn_Voltar.Location = new Point(22, 176);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(75, 23);
            btn_Voltar.TabIndex = 23;
            btn_Voltar.Text = "Voltar";
            btn_Voltar.UseVisualStyleBackColor = true;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // Endereço
            // 
            Endereço.Location = new Point(454, 136);
            Endereço.Name = "Endereço";
            Endereço.Size = new Size(334, 23);
            Endereço.TabIndex = 38;
            // 
            // Telefone
            // 
            Telefone.Location = new Point(454, 106);
            Telefone.Name = "Telefone";
            Telefone.Size = new Size(334, 23);
            Telefone.TabIndex = 37;
            // 
            // Email
            // 
            Email.Location = new Point(454, 77);
            Email.Name = "Email";
            Email.Size = new Size(334, 23);
            Email.TabIndex = 36;
            // 
            // CPF_grid
            // 
            CPF_grid.Location = new Point(56, 45);
            CPF_grid.Name = "CPF_grid";
            CPF_grid.Size = new Size(230, 23);
            CPF_grid.TabIndex = 35;
            // 
            // Nome_grid
            // 
            Nome_grid.Location = new Point(56, 15);
            Nome_grid.Name = "Nome_grid";
            Nome_grid.Size = new Size(230, 23);
            Nome_grid.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(408, 80);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 33;
            label5.Text = "E-mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(397, 109);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 32;
            label4.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(397, 139);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 31;
            label3.Text = "Endereço";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 48);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 30;
            label6.Text = "CPF";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 18);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 29;
            label7.Text = "Nome";
            // 
            // dataGridView_Clientes
            // 
            dataGridView_Clientes.AllowUserToAddRows = false;
            dataGridView_Clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Clientes.Location = new Point(10, 209);
            dataGridView_Clientes.Name = "dataGridView_Clientes";
            dataGridView_Clientes.ReadOnly = true;
            dataGridView_Clientes.Size = new Size(276, 229);
            dataGridView_Clientes.TabIndex = 39;
            dataGridView_Clientes.CellContentClick += dataGridView_Clientes_CellContentClick;
            // 
            // btn_Pesquisa
            // 
            btn_Pesquisa.Location = new Point(103, 177);
            btn_Pesquisa.Name = "btn_Pesquisa";
            btn_Pesquisa.Size = new Size(75, 23);
            btn_Pesquisa.TabIndex = 40;
            btn_Pesquisa.Text = "Pesquisar";
            btn_Pesquisa.UseVisualStyleBackColor = true;
            btn_Pesquisa.Click += btn_Pesquisa_Click;
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Pesquisa);
            Controls.Add(dataGridView_Clientes);
            Controls.Add(Endereço);
            Controls.Add(Telefone);
            Controls.Add(Email);
            Controls.Add(CPF_grid);
            Controls.Add(Nome_grid);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(btn_Voltar);
            Controls.Add(Excluir);
            Controls.Add(btn_Editar);
            Controls.Add(btn_Buscar);
            Controls.Add(CPF);
            Controls.Add(Nome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Lista);
            Name = "Consulta";
            Text = "Consulta";
            Load += Consulta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Lista;
        public TextBox CPF;
        public TextBox Nome;
        private Label label2;
        private Label label1;
        private Button btn_Buscar;
        private Button btn_Editar;
        private Button Excluir;
        private Button btn_Voltar;
        public TextBox Endereço;
        public TextBox Telefone;
        public TextBox Email;
        public TextBox CPF_grid;
        public TextBox Nome_grid;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView_Clientes;
        private Button btn_Pesquisa;
    }
}