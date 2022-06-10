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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntPesquisa_Click(object sender, EventArgs e)
        {
           

            string conexão = "Server=127.0.0.1;Database=telacadastro;Uid=root;Pwd=bruce@#2022;";

            string query = $@"select * from cadastros where nome like '{txtCampo.Text}'";

            MySqlConnection conexaoMysql = new MySqlConnection(conexão);
            DataTable tabela = new DataTable();

            try
            {
                conexaoMysql.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexaoMysql);
                adapter.Fill(tabela);
                dgvTelaCadastro.DataSource = tabela;

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

        private void button2_Click(object sender, EventArgs e)
        {
            string conexão = "Server=127.0.0.1;Database=telacadastro;Uid=root;Pwd=bruce@#2022;";

            string query = $@"select * from cadastros";

            MySqlConnection conexaoMysql = new MySqlConnection(conexão);
            DataTable tabela = new DataTable();

            try
            {
                conexaoMysql.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexaoMysql);
                adapter.Fill(tabela);
                dgvTelaCadastro.DataSource = tabela;

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
    }
}
