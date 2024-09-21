using Microsoft.Data.Sqlite;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
namespace Minha_Biblioteca_ofc1
{
    public partial class Login : Form
    {

        private Conex�o connectionManager;
        public Login()
        {
            InitializeComponent();
        }

        private bool ValidarLogin(string usuario, string senha)
        {
            string dbPath = "C:\\Users\\Loure\\source\\repos\\Minha Biblioteca_ofc1\\Minha Biblioteca_ofc1\\bin\\Debug\\Biblioteca.db";
            connectionManager = new Conex�o(dbPath);

            try
            {
                using (var connection = new SqliteConnection($"Data Source={dbPath}"))
                {
                    connection.Open();

                    // Consulta para verificar o login
                    string selectQuery = "SELECT Usuario, Senha FROM Login WHERE Usuario = @Usuario AND Senha = @Senha";
                    using (var command = new SqliteCommand(selectQuery, connection))
                    {
                        // Adiciona par�metros para evitar SQL Injection
                        command.Parameters.AddWithValue("@Usuario", usuario.Trim());
                        command.Parameters.AddWithValue("@Senha", senha.Trim());

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string usuarioEncontrado = reader["Usuario"].ToString();
                                string senhaEncontrada = reader["Senha"].ToString();

                                // Verifica se os dados correspondem
                                if (usuarioEncontrado.Equals(usuario.Trim(), StringComparison.OrdinalIgnoreCase) &&
                                    senhaEncontrada.Equals(senha.Trim(), StringComparison.OrdinalIgnoreCase))
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao validar login: {ex.Message}");
            }

            // Se n�o encontrou o login ou os dados n�o correspondem
            return false;
        }

        private void btn_Logar_Click(object sender, EventArgs e)
        {

            //TestarConexaoSimplificado();
            //VerificarTabelaLogin();
            //AdicionarDadosDeTeste();
            //MostrarConteudoTabelaLogin();
            



            if (string.IsNullOrWhiteSpace(txb_Usuario.Text) || string.IsNullOrWhiteSpace(txb_Senha.Text))
            {
                MessageBox.Show("Por favor, preencha os campos de usu�rio e senha.");
                return;
            }


            try
            {
                bool loginValido = ValidarLogin(txb_Usuario.Text, txb_Senha.Text);

                if (loginValido)
                {
                    Tela_Principal tel = new Tela_Principal();
                    tel.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usu�rio ou senha incorretos.");
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao validar o login");
            }

        }


        private void TestarConexaoSimplificado()
        {
            try
            {
                string dbPath = "Biblioteca.db";

                using (var connection = new SqliteConnection($"Data Source={dbPath}"))
                {
                    connection.Open();
                    MessageBox.Show("Conex�o bem-sucedida com o banco de dados!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void VerificarTabelaLogin()
        {
            try
            {
                string dbPath = "C:\\Users\\Loure\\source\\repos\\Minha Biblioteca_ofc1\\Minha Biblioteca_ofc1\\bin\\Debug\\Biblioteca.db";

                using (var connection = new SqliteConnection($"Data Source={dbPath}"))
                {
                    connection.Open();
                    MessageBox.Show("Conex�o com o banco de dados estabelecida com sucesso!");

                    // Consultar se a tabela existe
                    string query = "SELECT name FROM sqlite_master WHERE type='table' AND name='Login'";
                    using (var command = new SqliteCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();

                        // Mensagem de depura��o para verificar o resultado
                        if (result != null)
                        {
                            MessageBox.Show("Tabela 'Login' existe.");
                        }
                        else
                        {
                            MessageBox.Show("Tabela 'Login' n�o encontrada.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar a tabela: {ex.Message}");
            }
        }

        private void MostrarConteudoTabelaLogin()
        {
            string dbPath = "C:\\Users\\Loure\\source\\repos\\Minha Biblioteca_ofc1\\Minha Biblioteca_ofc1\\bin\\Debug\\Biblioteca.db";

            try
            {
                using (var connection = new SqliteConnection($"Data Source={dbPath}"))
                {
                    connection.Open();
                    MessageBox.Show("Conex�o com o banco de dados estabelecida.");

                    // Consulta para recuperar todos os registros da tabela Login
                    string selectQuery = "SELECT Usuario, Senha FROM Login";
                    using (var command = new SqliteCommand(selectQuery, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            var messageBuilder = new StringBuilder();
                            messageBuilder.AppendLine("Conte�do da tabela Login:");

                            // Verifica se o reader cont�m registros
                            if (!reader.HasRows)
                            {
                                messageBuilder.AppendLine("A tabela 'Login' est� vazia.");
                            }
                            else
                            {
                                while (reader.Read())
                                {
                                    string usuario = reader["Usuario"].ToString();
                                    string senha = reader["Senha"].ToString();
                                    messageBuilder.AppendLine($"Usu�rio: {usuario}, Senha: {senha}");
                                }
                            }

                            MessageBox.Show(messageBuilder.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao acessar a tabela: {ex.Message}");
            }
        }

        private void AdicionarDadosDeTeste()
        {
            string dbPath = "C:\\Users\\Loure\\source\\repos\\Minha Biblioteca_ofc1\\Minha Biblioteca_ofc1\\bin\\Debug\\Biblioteca.db";

            try
            {
                using (var connection = new SqliteConnection($"Data Source={dbPath}"))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO Login (Usuario, Senha) VALUES (@Usuario, @Senha)";
                    using (var command = new SqliteCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Usuario", " ");
                        command.Parameters.AddWithValue("@Senha", " ");

                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} registro(s) adicionado(s) � tabela 'Login'.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar dados: {ex.Message}");
            }
        }

    }
}
