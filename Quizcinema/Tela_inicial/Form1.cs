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
        
        public Paginainicial()
        {
            InitializeComponent();
           

        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            txtNome.Text = "";
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
           /* if (txtNome.Text == "")
            {
                txtNome.Text = "Digite seu nome";
            }*/
            
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
            int pontos;
            if (txtNome.Text == "" && txtSobrenome.Text == "" && txtEmail.Text == "")
            {
                MessageBox.Show("Por favor coloque um nome", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                 txtNome.Focus();
                txtSobrenome.Focus();
            }
            //jogador cadastrado no banco de dados
            else
            {
                using (SqlConnection conexao = new SqlConnection("Server=AME0556325W10-1\\SQLEXPRESS;Database=db_Quizcinema;Trusted_Connection=Yes"))
                {
                    using (SqlCommand comando = new SqlCommand("insert into tb_Players(nome, sobrenome, Email) OUTPUT INSERTED.ID_PLAYER values(@nome, @sobrenome, @Email)", conexao))
                    {

                        comando.Parameters.AddWithValue("nome", txtNome.Text);
                        comando.Parameters.AddWithValue("sobrenome", txtSobrenome.Text);
                        comando.Parameters.AddWithValue("Email", txtEmail.Text);
                        /*comando.Parameters.AddWithValue("nome", txtNome.Text);
                        comando.Parameters.AddWithValue("sobrenome", txtSobrenome.Text);
                        comando.Parameters.AddWithValue("Email", txtEmail.Text);*/
                        conexao.Open();
                        int id_jogador = (int)comando.ExecuteScalar();
                        string jogador = txtNome.Text;
                        if (id_jogador > 0)
                        {
                            MessageBox.Show("Jogador Inserido" + id_jogador);
                            Instrucoes itr = new Instrucoes(id_jogador, jogador);
                            itr.ShowDialog();
                            Pergunta1 p1 = new Pergunta1(id_jogador, jogador);
                            p1.ShowDialog();
                            Pergunta2 p2 = new Pergunta2(id_jogador, jogador);
                            p2.ShowDialog();
                            Pergunta3 p3 = new Pergunta3(id_jogador, jogador);
                            p3.ShowDialog();

                            //pontuação do jogador
                            comando.CommandText = "select count(pergunta) from tb_perguntas where id_jogador="  +id_jogador;
                            SqlDataReader dr_acertos = comando.ExecuteReader();
                            
                            dr_acertos.Read();

                            TelaFinal tf = new TelaFinal(id_jogador, jogador, dr_acertos.GetInt32(0));
                            tf.ShowDialog();
                            txtNome.Text = "";
                            txtSobrenome.Text = "";
                            txtEmail.Text = "";



                        }

                    }
                }


            }
        }

        private void Paginainicial_Load(object sender, EventArgs e)
        {

        }
    }
    }

