using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UC12_SERVICO_TI
{
    public partial class FormSERVICO : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        public FormSERVICO()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=controle_ti;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
        }

        private void buttonADICIONAR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "INSERT INTO tbl_servico (abrir_servico, orcamento, situacao, relatorio_servico) VALUES ('" + textBoxSERVICO.Text + "', '" + textBoxORCAMENTO.Text + "', '" + textBoxSITUACAO.Text + "', '" + textBoxRELATORIO.Text + "');";
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
