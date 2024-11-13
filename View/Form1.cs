using AcademiaPowerHub.View;

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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
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
        }

        private void txtBoxEmailLogin_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnLoginAbaLoginInicial_Click(object sender, EventArgs e)
        {
            if (txtBoxLoginInicio.Text == "Aluno" && txtBoxSenhaLogin.Text == "123")
            {
                MessageBox.Show("Seja bem-vindo, Aluno!", "Login Bem-sucedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HomeAlunosGeral homeAlunosGeral = new HomeAlunosGeral();
                homeAlunosGeral.Show();
                this.Hide();
            }
            else if (txtBoxLoginInicio.Text == "Admin" && txtBoxSenhaLogin.Text == "Admin")
            {
                MessageBox.Show("Seja bem-vindo, Admin!", "Login Bem-sucedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HomeADM homeADM = new HomeADM();
                homeADM.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblCliqueAquiParaSeRegistrar_Click(object sender, EventArgs e)
        {
            Registro irParaRegistro = new Registro();
            irParaRegistro.Show();
            this.Hide();
        }

        private void lblIrParaLoja_Click(object sender, EventArgs e)
        {
            PHStore phStore = new PHStore();
            phStore.Show();
            this.Hide();
        }
    }
}