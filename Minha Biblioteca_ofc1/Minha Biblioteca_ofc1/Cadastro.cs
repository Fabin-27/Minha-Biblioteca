﻿using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

            string databasePath = "Biblioteca.db";
            connectionManager = new Conexão(databasePath);

            string createTableQuery = @"CREATE TABLE IF NOT EXISTS Cliente (
                                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        Nome TEXT NOT NULL,
                                        CPF TEXT UNIQUE NOT NULL,
                                        Email TEXT NOT NULL,
                                        Telefone TEXT NOT NULL,
                                        Endereço TEXT NOT NULL
                                    );";

            connectionManager.ExecuteNonQuery(createTableQuery);
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
            String insertQuery = $"INSERT INTO Cliente (Nome, CPF, Email, Telefone, Endereço) " +
                                 $" VALUES  ('{Nome.Text}', '{CPF.Text}', '{Email.Text}', '{Telefone.Text}', '{Endereço.Text}')";

            connectionManager.ExecuteNonQuery(insertQuery);

            Atualizar_Cadastros();

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {

        }
    }
}
