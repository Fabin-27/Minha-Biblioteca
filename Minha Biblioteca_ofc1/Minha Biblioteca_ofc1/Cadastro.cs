using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minha_Biblioteca_ofc1
{
    public partial class Cadastro : Form
    {
        private Conexão connectionManager;
        public Cadastro()
        {
            InitializeComponent();

            string dbPath = "C:\\Users\\Loure\\source\\repos\\Minha Biblioteca_ofc1\\Minha Biblioteca_ofc1\\bin\\Biblioteca.db";
            connectionManager = new Conexão(dbPath);

            Atualizar_Cadastros();

        }

        public void Atualizar_Cadastros()
        {

            Lista.Items.Clear();

            string selectQuery = "SELECT * FROM Cliente";

            using (var connection = connectionManager.GetConnection())
            {
                connectionManager.OpenConnection(connection);

                using (var command = new SqliteCommand(selectQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string informacoesCliente = $"Nome: {reader["Nome"]}, CPF: {reader["CPF"]}, " +
                                                        $"Email: {reader["Email"]}, Telefone: {reader["Telefone"]}, Endereço: {reader["Endereço"]}";
                            Lista.Items.Add(informacoesCliente);
                        }
                    }
                }

                connectionManager.CloseConnection(connection);
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                String insertQuery = $"INSERT INTO Cliente (Nome, CPF, Email, Telefone, Endereço) " +
                                     $" VALUES  ('{Nome.Text}', '{CPF.Text}', '{Email.Text}', '{Telefone.Text}', '{Endereço.Text}')";

                connectionManager.ExecuteNonQuery(insertQuery);
                Atualizar_Cadastros();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Tela_Principal tel = new Tela_Principal();
            tel.Show();
            this.Hide();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {

            Nome.Text = string.Empty;
            CPF.Text = string.Empty;
            Email.Text = string.Empty;
            Telefone.Text = string.Empty;
            Endereço.Text = string.Empty;

            Nome.Focus();

        }

        private bool ValidarCampos()
        {
            if (!Regex.IsMatch(CPF.Text, @"^\d+$"))
            {
                MessageBox.Show("CPF deve conter apenas números.");
                return false;
            }

            if (!Regex.IsMatch(Email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email inválido.");
                return false;
            }

            if (!Regex.IsMatch(Telefone.Text, @"^\d+$"))
            {
                MessageBox.Show("Telefone deve conter apenas números.");
                return false;
            }

            return true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
