using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AcademiaPowerHub.View
{
    public partial class ListarProdutos : Form
    {
        private string caminhoArquivo = "ListaDeProdutos.txt"; // arquivo TXT

        public ListarProdutos()
        {
            InitializeComponent();
            CarregarUsuarios();
        }

        private void CarregarUsuarios()
        {
            if (File.Exists(caminhoArquivo))
            {
                var usuarios = File.ReadAllLines(caminhoArquivo);
                foreach (var usuario in usuarios)
                {
                    userListBox.Items.Add(usuario);
                }
            }
            else
            {
                MessageBox.Show("Arquivo de usuários não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblVOLTARMENUADM_Click(object sender, EventArgs e)
        {
            HomeADM opanHomeADM = new HomeADM();
            opanHomeADM.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
         

            this.Hide();
            HomeADM homeADMForm = new HomeADM();
            homeADMForm.Show();

        }
    }
}
