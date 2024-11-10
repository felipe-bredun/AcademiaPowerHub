using AcademiaPowerHub.View;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AcademiaPowerHub
{
    public partial class CadastramentoDeProdutos : Form
    {
        public CadastramentoDeProdutos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HomeADM homeADM = new HomeADM();
            homeADM.Show();
            this.Hide();
        }

        private void textBoxPreço_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxDescrição_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxQuantidade_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxTributacao_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxCategoria_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnApertoParaCadastrar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxNomeProduto.Text) ||
                string.IsNullOrWhiteSpace(textBoxPreço.Text) ||
                string.IsNullOrWhiteSpace(textBoxDescrição.Text) ||
                string.IsNullOrWhiteSpace(textBoxQuantidade.Text) ||
                string.IsNullOrWhiteSpace(textBoxTributacao.Text) ||
                string.IsNullOrWhiteSpace(textBoxCategoria.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string filePath = "ListaDeProdutos.txt";


            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }


            string produto = $"Nome: {textBoxNomeProduto.Text}, Preço: {textBoxPreço.Text}, Descrição: {textBoxDescrição.Text}, " +
                             $"Quantidade: {textBoxQuantidade.Text}, Tributação: {textBoxTributacao.Text}, Categoria: {textBoxCategoria.Text}";


            File.AppendAllText(filePath, produto + Environment.NewLine);

            MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            textBoxNomeProduto.Clear();
            textBoxPreço.Clear();
            textBoxDescrição.Clear();
            textBoxQuantidade.Clear();
            textBoxTributacao.Clear();
            textBoxCategoria.Clear();
        }

        private void btnVerListaDeProdutos_Click(object sender, EventArgs e)
        {
            ListarProdutos irParaListaDeProdutos = new ListarProdutos();
            irParaListaDeProdutos.Show();
            this.Hide();
        }
    }
}