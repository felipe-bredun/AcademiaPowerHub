namespace AcademiaPowerHub
{
    public partial class HomeADM : Form
    {
        private HomeADMFacade _facade;  // Instância da Facade

        public HomeADM()
        {
            InitializeComponent();
            _facade = new HomeADMFacade(this);  // Inicializando a Facade
        }

        // Manipulador do clique do botão "Sair Login"
        private void lblBotaoSairLogin_Click(object sender, EventArgs e)
        {
            _facade.SairLogin();  // Delegando para a Facade
        }

        // Manipulador do clique do botão "Fechar Aba Home Administração"
        private void lblFecharAbaHomeAdiministração_Click(object sender, EventArgs e)
        {
            _facade.FecharAbaHomeADM();  // Delegando para a Facade
        }

        // Manipulador do clique do botão "Adicionar Produto"
        private void lblAddProdutoHomeAdiministração_Click(object sender, EventArgs e)
        {
            _facade.IrParaCadastroDeProdutos();  // Delegando para a Facade
        }

        // Manipulador do clique do botão "Ver Lista de Produtos"
        private void lblVerListaDeProdutos_Click(object sender, EventArgs e)
        {
            _facade.VerListaDeProdutos();  // Delegando para a Facade
        }

        // Manipulador do clique do botão "Login"
        private void lblLogin_Click(object sender, EventArgs e)
        {
            // Adicione qualquer lógica necessária para o evento de login aqui
            MessageBox.Show("Você clicou em 'Login'");
        }
    }
}
