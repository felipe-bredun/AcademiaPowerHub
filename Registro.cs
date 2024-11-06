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

            string login = textBoxLoginAbaRegistro.Text;
            string email = textBoxEmailAbaRegistro.Text;
            string senha = textBoxSenhaAbaRegistro.Text;
            string repSenha = textBoxRepSenhaAbaRegistro.Text;

           
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(repSenha))
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

    
            if (senha != repSenha)
            {
                MessageBox.Show("As senhas não coincidem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

          
            string caminhoArquivo = @"C:\Users\User\source\repos\AcademiaPowerHub\registros.txt";

            try
            {
                
                if (!File.Exists(caminhoArquivo))
                {
                    File.Create(caminhoArquivo).Close();
                }

       
                using (StreamWriter sw = new StreamWriter(caminhoArquivo, true))
                {
                    sw.WriteLine($"Login: {login}, Email: {email}, Senha: {senha}");
                }

            
                MessageBox.Show("Usuário registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

              
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
           
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }
    }
}
