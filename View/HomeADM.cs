using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaPowerHub
{
    public partial class HomeADM : Form
    {
        public HomeADM()
        {
            InitializeComponent();
        }

        private void lblBotaoSairLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void lblFecharAbaHomeAdiministração_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAddProdutoHomeAdiministração_Click(object sender, EventArgs e)
        {
            CadastramentoDeProdutos irParaCadastroDeProdutos = new CadastramentoDeProdutos();
            irParaCadastroDeProdutos.Show();
            this.Hide();
        }

        private void lblVerListaDeProdutos_Click(object sender, EventArgs e)
        {
            string filePath = "ListaDeProdutos.txt";

            if (!File.Exists(filePath) || new FileInfo(filePath).Length == 0)
            {
                MessageBox.Show("Não há itens cadastrados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string produtos = File.ReadAllText(filePath);
                MessageBox.Show(produtos, "Lista de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
