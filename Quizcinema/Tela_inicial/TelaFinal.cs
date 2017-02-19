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
    public partial class TelaFinal : Form
    {
        int id_jogador_DB;
        string jogadorrecebe2;
        int pontosrecebe;
        
        
        
        
        // int contador;
        public TelaFinal(int id_jogador, string jogadorecebe, int pontos)
        {
            InitializeComponent();
            id_jogador_DB = id_jogador;
            jogadorrecebe2 = jogadorecebe;
            pontos = pontosrecebe;
            
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void btnJogardenovo_Click(object sender, EventArgs e)
        {
            /*Paginainicial pn = new Paginainicial();
            pn.Show();
            this.Close();*/
        }

        private void TelaFinal_Load(object sender, EventArgs e)
        {
            if (pontosrecebe <= 4 )
            {
                txtmensagemfinal.Text = "Parabens" + id_jogador_DB;
                txtpontuacaofinal.Text = "sua pontuação foi" + pontosrecebe;
            }
            if(pontosrecebe == 2 )
            {
                txtmensagemfinal.Text = "foi bem" + id_jogador_DB;
                txtpontuacaofinal.Text = "sua ´pontuação foi" + pontosrecebe;
                
            }
            if (pontosrecebe <= 1)
            {
                txtmensagemfinal.Text = "Ez Noob" + id_jogador_DB;
                txtpontuacaofinal.Text = "sua pontuação foi" + pontosrecebe;
            }
        }
    }
}
