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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta));
            Lista = new ListBox();
            btn_Voltar = new Button();
            CPF_grid = new TextBox();
            Nome_grid = new TextBox();
            label6 = new Label();
            label7 = new Label();
            dataGridView_Clientes = new DataGridView();
            btn_Pesquisa = new Button();
            Endereço = new TextBox();
            Telefone = new TextBox();
            Email = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            Excluir = new Button();
            btn_Editar = new Button();
            btn_Buscar = new Button();
            CPF = new TextBox();
            Nome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clientes).BeginInit();
            SuspendLayout();
            // 
            // Lista
            // 
            Lista.FormattingEnabled = true;
            Lista.ItemHeight = 15;
            Lista.Location = new Point(10, 340);
            Lista.Name = "Lista";
            Lista.Size = new Size(694, 109);
            Lista.TabIndex = 15;
            Lista.SelectedIndexChanged += Lista_SelectedIndexChanged;
            // 
            // btn_Voltar
            // 
            btn_Voltar.Location = new Point(548, 43);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(75, 23);
            btn_Voltar.TabIndex = 23;
            btn_Voltar.Text = "Voltar";
            btn_Voltar.UseVisualStyleBackColor = true;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // CPF_grid
            // 
            CPF_grid.Location = new Point(69, 42);
            CPF_grid.Name = "CPF_grid";
            CPF_grid.Size = new Size(220, 23);
            CPF_grid.TabIndex = 35;
            // 
            // Nome_grid
            // 
            Nome_grid.Location = new Point(69, 12);
            Nome_grid.Name = "Nome_grid";
            Nome_grid.Size = new Size(220, 23);
            Nome_grid.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Sitka Text", 12F, FontStyle.Italic);
            label6.Location = new Point(25, 42);
            label6.Name = "label6";
            label6.Size = new Size(38, 23);
            label6.TabIndex = 30;
            label6.Text = "CPF";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Sitka Text", 12F, FontStyle.Italic);
            label7.Location = new Point(10, 12);
            label7.Name = "label7";
            label7.Size = new Size(53, 23);
            label7.TabIndex = 29;
            label7.Text = "Nome";
            // 
            // dataGridView_Clientes
            // 
            dataGridView_Clientes.AllowUserToAddRows = false;
            dataGridView_Clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Clientes.Location = new Point(10, 71);
            dataGridView_Clientes.Name = "dataGridView_Clientes";
            dataGridView_Clientes.ReadOnly = true;
            dataGridView_Clientes.Size = new Size(694, 73);
            dataGridView_Clientes.TabIndex = 39;
            dataGridView_Clientes.CellContentClick += dataGridView_Clientes_CellContentClick;
            // 
            // btn_Pesquisa
            // 
            btn_Pesquisa.Location = new Point(629, 44);
            btn_Pesquisa.Name = "btn_Pesquisa";
            btn_Pesquisa.Size = new Size(75, 23);
            btn_Pesquisa.TabIndex = 40;
            btn_Pesquisa.Text = "Pesquisar";
            btn_Pesquisa.UseVisualStyleBackColor = true;
            btn_Pesquisa.Click += btn_Pesquisa_Click;
            // 
            // Endereço
            // 
            Endereço.Location = new Point(97, 288);
            Endereço.Name = "Endereço";
            Endereço.Size = new Size(192, 23);
            Endereço.TabIndex = 53;
            // 
            // Telefone
            // 
            Telefone.Location = new Point(97, 258);
            Telefone.Name = "Telefone";
            Telefone.Size = new Size(192, 23);
            Telefone.TabIndex = 52;
            // 
            // Email
            // 
            Email.Location = new Point(97, 229);
            Email.Name = "Email";
            Email.Size = new Size(192, 23);
            Email.TabIndex = 51;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sitka Text", 12F, FontStyle.Italic);
            label5.Location = new Point(32, 229);
            label5.Name = "label5";
            label5.Size = new Size(59, 23);
            label5.TabIndex = 50;
            label5.Text = "E-mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sitka Text", 12F, FontStyle.Italic);
            label4.Location = new Point(18, 258);
            label4.Name = "label4";
            label4.Size = new Size(73, 23);
            label4.TabIndex = 49;
            label4.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sitka Text", 12F, FontStyle.Italic);
            label3.Location = new Point(14, 288);
            label3.Name = "label3";
            label3.Size = new Size(77, 23);
            label3.TabIndex = 48;
            label3.Text = "Endereço";
            // 
            // Excluir
            // 
            Excluir.Location = new Point(629, 311);
            Excluir.Name = "Excluir";
            Excluir.Size = new Size(75, 23);
            Excluir.TabIndex = 47;
            Excluir.Text = "Excluir";
            Excluir.UseVisualStyleBackColor = true;
            Excluir.Click += Excluir_Click_1;
            // 
            // btn_Editar
            // 
            btn_Editar.Location = new Point(548, 311);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(75, 23);
            btn_Editar.TabIndex = 46;
            btn_Editar.Text = "Editar";
            btn_Editar.UseVisualStyleBackColor = true;
            btn_Editar.Click += btn_Editar_Click_1;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Location = new Point(467, 311);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(75, 23);
            btn_Buscar.TabIndex = 45;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click_1;
            // 
            // CPF
            // 
            CPF.Location = new Point(97, 194);
            CPF.Name = "CPF";
            CPF.Size = new Size(192, 23);
            CPF.TabIndex = 44;
            // 
            // Nome
            // 
            Nome.Location = new Point(97, 164);
            Nome.Name = "Nome";
            Nome.Size = new Size(192, 23);
            Nome.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Text", 12F, FontStyle.Italic);
            label2.Location = new Point(53, 194);
            label2.Name = "label2";
            label2.Size = new Size(38, 23);
            label2.TabIndex = 42;
            label2.Text = "CPF";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Text", 12F, FontStyle.Italic);
            label1.Location = new Point(38, 164);
            label1.Name = "label1";
            label1.Size = new Size(53, 23);
            label1.TabIndex = 41;
            label1.Text = "Nome";
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(716, 446);
            Controls.Add(Endereço);
            Controls.Add(Telefone);
            Controls.Add(Email);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Excluir);
            Controls.Add(btn_Editar);
            Controls.Add(btn_Buscar);
            Controls.Add(CPF);
            Controls.Add(Nome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Pesquisa);
            Controls.Add(dataGridView_Clientes);
            Controls.Add(CPF_grid);
            Controls.Add(Nome_grid);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(btn_Voltar);
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
        private Button btn_Voltar;
        public TextBox CPF_grid;
        public TextBox Nome_grid;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView_Clientes;
        private Button btn_Pesquisa;
        public TextBox Endereço;
        public TextBox Telefone;
        public TextBox Email;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button Excluir;
        private Button btn_Editar;
        private Button btn_Buscar;
        public TextBox CPF;
        public TextBox Nome;
        private Label label2;
        private Label label1;
    }
}