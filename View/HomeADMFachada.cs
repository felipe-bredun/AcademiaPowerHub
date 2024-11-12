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

        public void FecharAbaHomeADM()
        {
            _homeAdm.Close();
        }

        public void IrParaCadastroDeProdutos()
        {
            CadastramentoDeProdutos formCadastro = new CadastramentoDeProdutos();
            formCadastro.Show();
            _homeAdm.Hide();
        }

        public void VerListaDeProdutos()
        {
            ListarProdutos formListar = new ListarProdutos();
            formListar.Show();
            _homeAdm.Hide();
        }

  
        public void SairLogin()
        {
            _homeAdm.Close();
        }
    }
}

