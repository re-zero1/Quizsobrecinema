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
    public partial class Paginainicial : Form
    {
        
        public Paginainicial(int id_jogador)
        {
            InitializeComponent();
           

        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            txtNome.Text = "";
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = "Digite seu nome";
            }
            
        }

        private void txtSobrenome_Enter(object sender, EventArgs e)
        {
            txtSobrenome.Text = ""; 
        }

        private void txtSobrenome_Leave(object sender, EventArgs e)
        {
            if (txtSobrenome.Text == "")
            {
                txtSobrenome.Text = "Digite seu Sobrenome";
            }
            else { txtNome.Focus(); }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.Text = "";
;       }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if(txtEmail.Text == "")
            txtEmail.Text = "Digite seu Email";
        }

        private void btnComeca_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" && txtSobrenome.Text == "" && txtEmail.Text == "")
            {
                MessageBox.Show("Por favor coloque um nome", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //txtEmail.Focus();
               // txtNome.Focus();
                txtSobrenome.Focus();
            }
            //jogador cadastrado no banco de dados
            else
            {
                using (SqlConnection conexao = new SqlConnection("Server=AME0556325W10-1\\SQLEXPRESS;Database = db_Quizcinema;Trusted_Connection= Yes")) 
                using (SqlConnection comando = new SqlConnection("insert into tb_Players (Nome, Sobrenome, Email) OUTPUT INSERT.ID Values(@Nome, @Sobrenome, @Email)",conexao)) 
                {
                    comando.Parameters.AddWithValue("Nome", txtNome.Text);
                    comando.Parameters.AddWithValue("Sobrenome", txtSobrenome.Text);
                    comando.Parameters.AddWithValue("Email", txtEmail.Text);
                    conexao.Open();
                    int Id_jogador = (int)comando.ExecuteScalar();
                    if (Id_jogador > 0)
                    {
                        MessageBox.Show("Jogador Inserido" + Id_jogador);
                        Instrucoes itr = new Instrucoes(Id_jogador);
                        itr.ShowDialog();
                        Pergunta1 p1 = new Pergunta1(Id_jogador);
                        p1.ShowDialog();
                       /* Pergunta1 p2 = new Pergunta1(Id_jogador);
                        p2.ShowDialog();
                        Pergunta1 p3 = new Pergunta1(Id_jogador);
                        p3.ShowDialog();
                        TelaFinal tf = new TelaFinal(Id_jogador);*/


                    }
                    
                }
                }
                

            }
        }
    }
}
