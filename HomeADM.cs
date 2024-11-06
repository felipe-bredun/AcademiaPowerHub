using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
