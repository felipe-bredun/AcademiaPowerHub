using System;
using System.IO; // Necessário para manipulação de arquivos
using System.Windows.Forms;

namespace AcademiaPowerHub
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLoginAbaRegistro_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmailAbaRegistro_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSenhaAbaRegistro_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRepSenhaAbaRegistro_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxSenhasAbaRegistro_CheckedChanged(object sender, EventArgs e)
        {
            // Mostra ou esconde a senha de acordo com o estado do CheckBox
            if (checkBoxSenhasAbaRegistro.Checked)
            {
                textBoxSenhaAbaRegistro.UseSystemPasswordChar = false;
                textBoxRepSenhaAbaRegistro.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxSenhaAbaRegistro.UseSystemPasswordChar = true;
                textBoxRepSenhaAbaRegistro.UseSystemPasswordChar = true;
            }
        }

        private void btnRegistrarNovoUsuario_Click(object sender, EventArgs e)
        {
            // Captura os valores dos campos de texto
            string login = textBoxLoginAbaRegistro.Text;
            string email = textBoxEmailAbaRegistro.Text;
            string senha = textBoxSenhaAbaRegistro.Text;
            string repSenha = textBoxRepSenhaAbaRegistro.Text;

            // Verifica se algum dos campos está vazio
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(repSenha))
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica se as senhas são iguais
            if (senha != repSenha)
            {
                MessageBox.Show("As senhas não coincidem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Define o caminho do arquivo
            string caminhoArquivo = @"C:\Users\User\source\repos\AcademiaPowerHub\registros.txt";

            try
            {
                // Verifica se o arquivo já existe, se não existir, cria
                if (!File.Exists(caminhoArquivo))
                {
                    File.Create(caminhoArquivo).Close();
                }

                // Salva o registro no arquivo
                using (StreamWriter sw = new StreamWriter(caminhoArquivo, true))
                {
                    sw.WriteLine($"Login: {login}, Email: {email}, Senha: {senha}");
                }

                // Exibe mensagem de sucesso
                MessageBox.Show("Usuário registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpa os campos de texto após o registro
                textBoxLoginAbaRegistro.Clear();
                textBoxEmailAbaRegistro.Clear();
                textBoxSenhaAbaRegistro.Clear();
                textBoxRepSenhaAbaRegistro.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o registro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Cria o objeto do login e exibe o formulário de login
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }
    }
}
