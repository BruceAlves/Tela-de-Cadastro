using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tela_de_Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            string comfirmarSenha = txtComfirmarSenha.Text;

            string conexão = "Server=127.0.0.1;Database=telacadastro;Uid=root;Pwd=bruce@#2022;";
            string comandoInsert = String.Empty;
            MySqlConnection conexaoMysql = new MySqlConnection(conexão);


            if(senha == comfirmarSenha)
            {
                comandoInsert = $@"
                Insert into cadastros(nome, email, senha)
                values('{nome}', '{email}', '{senha}');";
            }
            else
            {
                MessageBox.Show("Senha Não é compativel", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            try
            {
                conexaoMysql.Open();
                MySqlCommand executorComando = new MySqlCommand(comandoInsert, conexaoMysql);
                executorComando.ExecuteNonQuery();

                MessageBox.Show($"O Usuario {nome} foi Inserido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampo();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro Banco de Dados", $"Erro:\n{ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexaoMysql.Close();
            }
        }


        private void LimparCampo()
        {
           txtSenha.Text = string.Empty;
           txtNome.Text = string.Empty;
           txtEmail.Text = string.Empty;
           txtComfirmarSenha.Text = string.Empty;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampo();
        }
    }
}
