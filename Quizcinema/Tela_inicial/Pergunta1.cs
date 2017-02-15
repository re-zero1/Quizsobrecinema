using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela_inicial
{
    public partial class Pergunta1 : Form
    {
        int id_jogador_BD;
        public Pergunta1(int id_jogador)
        {
            InitializeComponent();
            id_jogador_BD = id_jogador;

        }

        private void btnProxima_Click(object sender, EventArgs e)
        {
            if (rdb2.Checked == true)
            {
                MessageBox.Show("Acertou Miseravel");
                this.Close();


            }
            else
            {
                MessageBox.Show("Errou Miseravel");
                this.Close();

            }

        }
    }
}
