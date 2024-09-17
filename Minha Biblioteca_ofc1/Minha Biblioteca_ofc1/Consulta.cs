using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Minha_Biblioteca_ofc1
{
    public partial class Consulta : Form
    {

        private Conexão connectionManager;
        public Consulta()
        {
            InitializeComponent();

            string dbPath = "C:\\Users\\Loure\\source\\repos\\Minha Biblioteca_ofc1\\Minha Biblioteca_ofc1\\bin\\Biblioteca.db";
            connectionManager = new Conexão(dbPath);
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
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
                            string informacoesCliente = $"{reader["Id"]}: Nome: {reader["Nome"]}, CPF: {reader["CPF"]}, " +
                                                        $"Email: {reader["Email"]}, Telefone: {reader["Telefone"]}, Endereço: {reader["Endereço"]}";
                            Lista.Items.Add(informacoesCliente);
                        }
                    }
                }

                connectionManager.CloseConnection(connection);
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {

            if (Lista.SelectedIndex != -1)
            {
                // Extrair o ID do cliente selecionado na lista
                string selectedItem = Lista.SelectedItem.ToString();
                string idString = selectedItem.Split(':')[0]; // Extrai o ID antes do ":"

                if (int.TryParse(idString, out int id))
                {
                    // Atualizar os dados do cliente no banco de dados
                    string updateQuery = $"UPDATE Cliente SET Nome = @Nome, CPF = @CPF, Email = @Email, Telefone = @Telefone, Endereço = @Endereço WHERE Id = @Id";

                    using (var connection = connectionManager.GetConnection())
                    {
                        connectionManager.OpenConnection(connection);

                        using (var command = new SqliteCommand(updateQuery, connection))
                        {
                            // Definir os parâmetros com os novos valores dos TextBoxes
                            command.Parameters.AddWithValue("@Nome", Nome.Text.Trim());
                            command.Parameters.AddWithValue("@CPF", CPF.Text.Trim());
                            command.Parameters.AddWithValue("@Email", Email.Text.Trim());
                            command.Parameters.AddWithValue("@Telefone", Telefone.Text.Trim());
                            command.Parameters.AddWithValue("@Endereço", Endereço.Text.Trim());
                            command.Parameters.AddWithValue("@Id", id);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cliente atualizado com sucesso!");
                                Atualizar_Cadastros(); // Atualiza a lista após edição
                            }
                            else
                            {
                                MessageBox.Show("Erro ao atualizar o cliente.");
                            }
                        }

                        connectionManager.CloseConnection(connection);
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao extrair o ID do cliente.");
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente para editar.");
            }


        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            {
                if (Lista.SelectedIndex != -1)
                {
                    string selectedItem = Lista.SelectedItem.ToString();
                    string idString = selectedItem.Split(':')[0];

                    if (int.TryParse(idString, out int id))
                    {
                        string deleteQuery = $"DELETE FROM Cliente WHERE Id = {id}";

                        connectionManager.ExecuteNonQuery(deleteQuery);

                        MessageBox.Show("Cliente deletado com sucesso!");

                        Atualizar_Cadastros();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao extrair o ID do cliente.");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um cliente para excluir.");
                }
            }

        }


        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Tela_Principal tel = new Tela_Principal();
            tel.Show();
            this.Hide();
        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (Lista.SelectedIndex != -1)
                {
                    // Extrair o ID do cliente selecionado na lista
                    string selectedItem = Lista.SelectedItem.ToString();
                    string idString = selectedItem.Split(':')[0]; // Extrai o ID antes do ":"

                    if (int.TryParse(idString, out int id))
                    {
                        // Carregar os dados do cliente do banco de dados usando o ID
                        string selectQuery = $"SELECT * FROM Cliente WHERE Id = {id}";

                        using (var connection = connectionManager.GetConnection())
                        {
                            connectionManager.OpenConnection(connection);

                            using (var command = new SqliteCommand(selectQuery, connection))
                            {
                                using (var reader = command.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        // Preenche os TextBoxes com os valores do cliente
                                        Nome.Text = reader["Nome"].ToString();
                                        CPF.Text = reader["CPF"].ToString();
                                        Email.Text = reader["Email"].ToString();
                                        Telefone.Text = reader["Telefone"].ToString();
                                        Endereço.Text = reader["Endereço"].ToString();
                                    }
                                }
                            }

                            connectionManager.CloseConnection(connection);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao carregar os dados do cliente.");
                    }
                }
            }
        }
    }


}
