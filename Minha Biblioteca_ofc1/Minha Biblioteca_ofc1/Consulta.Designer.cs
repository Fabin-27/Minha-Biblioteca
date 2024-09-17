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
            SuspendLayout();
            // 
            // Lista
            // 
            Lista.FormattingEnabled = true;
            Lista.ItemHeight = 15;
            Lista.Location = new Point(448, 38);
            Lista.Name = "Lista";
            Lista.Size = new Size(340, 394);
            Lista.TabIndex = 15;
            // 
            // CPF
            // 
            CPF.Location = new Point(52, 68);
            CPF.Name = "CPF";
            CPF.Size = new Size(357, 23);
            CPF.TabIndex = 19;
            // 
            // Nome
            // 
            Nome.Location = new Point(64, 38);
            Nome.Name = "Nome";
            Nome.Size = new Size(345, 23);
            Nome.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 71);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 17;
            label2.Text = "CPF";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 41);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 16;
            label1.Text = "Nome";
            // 
            // btn_Buscar
            // 
            btn_Buscar.Location = new Point(18, 110);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(75, 23);
            btn_Buscar.TabIndex = 20;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // btn_Editar
            // 
            btn_Editar.Location = new Point(18, 139);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(75, 23);
            btn_Editar.TabIndex = 21;
            btn_Editar.Text = "Editar";
            btn_Editar.UseVisualStyleBackColor = true;
            // 
            // Excluir
            // 
            Excluir.Location = new Point(18, 168);
            Excluir.Name = "Excluir";
            Excluir.Size = new Size(75, 23);
            Excluir.TabIndex = 22;
            Excluir.Text = "Excluir";
            Excluir.UseVisualStyleBackColor = true;
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}