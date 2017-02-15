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
    public partial class Instrucoes : Form
    {
        int id_jogador_DB;
        public Instrucoes(int id_jogador)
        {
            InitializeComponent();
            id_jogador_DB = id_jogador;
        }

        private void Instrucoes_Load(object sender, EventArgs e)
        {
            lblinstrução.Text = "Bem vindo NO jogo você respondera as perguntas na tela pelo tema Cinema"+ id_jogador_DB ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
