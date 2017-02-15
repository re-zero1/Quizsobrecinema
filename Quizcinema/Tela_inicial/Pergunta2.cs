using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela_inicial
{
    public partial class Pergunta2 : Form
    {
        int id_jogador_BD;
        string jogadorrecebe2;
        public Pergunta2(int id_jogador, string jogadorecebe)
        {
            InitializeComponent();
            id_jogador_BD = id_jogador;
            jogadorrecebe2 = jogadorecebe;
        } 

        private void btnProxima_Click(object sender, EventArgs e)
        {

            if (rdb1.Checked == true)
            {
                using (SqlConnection conexao = new SqlConnection("Server=AME0556325W10-1\\SQLEXPRESS;Database=db_Quizcinema;Trusted_Connection=Yes"))
                {
                    using (SqlCommand comando = new SqlCommand("insert into tb_perguntas(Pergunta, resposta_correta, id_jogador, nivel, pontos) values(@Pt, @Resposcorreta, @ID_JOGADOR, @nivel, @pontos)", conexao))
                    {
                        comando.Parameters.AddWithValue("pt", lblpergunta2.Text);
                        comando.Parameters.AddWithValue("Resposcorreta", rdb1.Text);
                        comando.Parameters.AddWithValue("ID_JOGADOR", id_jogador_BD);
                        comando.Parameters.AddWithValue("nivel", "Dificl");
                        comando.Parameters.AddWithValue("pontos", 1);
                        conexao.Open();
                        comando.ExecuteNonQuery();
                    }
                    MessageBox.Show("Acertou Miseravel");
                    this.Close();


                }
            }
            else
            {
                MessageBox.Show("Errou Miseravel");
                this.Close();

            }

        }
    }
}
