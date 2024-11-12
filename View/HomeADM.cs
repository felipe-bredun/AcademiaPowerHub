namespace AcademiaPowerHub
{
    public partial class HomeADM : Form
    {
        private HomeADMFacade _facade;

        public HomeADM()
        {
            InitializeComponent();
            _facade = new HomeADMFacade(this);
        }


        private void lblBotaoSairLogin_Click(object sender, EventArgs e)
        {
            _facade.SairLogin();


            void lblFecharAbaHomeAdiministração_Click(object sender, EventArgs e)
            {
                _facade.FecharAbaHomeADM();
            }


          void lblAddProdutoHomeAdiministração_Click(object sender, EventArgs e)
            {
                _facade.IrParaCadastroDeProdutos();
            }


           void lblVerListaDeProdutos_Click(object sender, EventArgs e)
            {
                _facade.VerListaDeProdutos();
            }

        
       void lblLogin_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Você clicou em 'Login'");
            }
        }
    }
}
