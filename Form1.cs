namespace AcademiaPowerHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //opaaaaaa
        }

        // L�gica para alternar a visibilidade da senha ao marcar/desmarcar o CheckBox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Se o CheckBox for marcado, mostra a senha; se desmarcado, esconde a senha
            if (checkBoxMostrarSenhaLogin.Checked)
            {
                txtBoxSenhaLogin.UseSystemPasswordChar = false;
            }
            else
            {
                txtBoxSenhaLogin.UseSystemPasswordChar = true;
            }
        }

        private void lblBotaoSairLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxSenhaLogin_TextChanged(object sender, EventArgs e)
        {
            // C�digo necess�rio para quando o texto da senha � alterado (caso precise de l�gica futura)
        }

        private void txtBoxEmailLogin_TextChanged(object sender, EventArgs e)
        {
            // C�digo necess�rio para quando o texto do email � alterado (caso precise de l�gica futura)
        }

        private void btnLoginAbaLoginInicial_Click(object sender, EventArgs e)
        {
            // Verifica se o email e a senha est�o corretos
            if (txtBoxLoginInicio.Text == "Aluno" && txtBoxSenhaLogin.Text == "123")
            {
                // Exibe mensagem de boas-vindas
                MessageBox.Show("Seja bem-vindo!", "Login Bem-sucedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cria o objeto da aba HomeAlunosGeral e esconde a aba atual
                HomeAlunosGeral homeAlunosGeral = new HomeAlunosGeral();
                homeAlunosGeral.Show();
                this.Hide();
            }
            else
            {
                // Exibe mensagem de erro se as credenciais estiverem incorretas
                MessageBox.Show("Usu�rio ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblCliqueAquiParaSeRegistrar_Click(object sender, EventArgs e)
        {
            Registro irParaRegistro = new Registro();
            irParaRegistro.Show();
            this.Hide();
        }
    }
}
