using AcademiaPowerHub.View;

namespace AcademiaPowerHub
{
    public class HomeADMFacade
    {
        private readonly HomeADM _homeAdm;

        public HomeADMFacade(HomeADM homeAdm)
        {
            _homeAdm = homeAdm;
        }

        // Método para fechar a aba da administração
        public void FecharAbaHomeADM()
        {
            _homeAdm.Close();
        }

        // Método para ir para o cadastro de produtos
        public void IrParaCadastroDeProdutos()
        {
            CadastramentoDeProdutos formCadastro = new CadastramentoDeProdutos();
            formCadastro.Show();
            _homeAdm.Hide();
        }

        // Método para exibir a lista de produtos
        public void VerListaDeProdutos()
        {
            ListarProdutos formListar = new ListarProdutos();
            formListar.Show();
            _homeAdm.Hide();
        }

        // Método para fazer logout (fechar a aplicação)
        public void SairLogin()
        {
            _homeAdm.Close();
        }
    }
}

