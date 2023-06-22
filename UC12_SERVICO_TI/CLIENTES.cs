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
    public partial class CLIENTES : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        public CLIENTES()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=controle_ti;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
            mostrarclientes();
        }
        private void mostrarclientes()
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT * FROM tbl_cliente  ORDER BY nome ASC;";

                MySqlDataAdapter adaptadorCONTATO = new MySqlDataAdapter(comando);

                DataTable tabelaCONTATO = new DataTable();
                adaptadorCONTATO.Fill(tabelaCONTATO);

                dataGridView1.DataSource = tabelaCONTATO;
                 



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
       

        

        private void buttonCADASTRAR_Click_1(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "INSERT INTO tbl_cliente (nome, cpf, celular, endereco) VALUES ('" + textBoxNOME.Text + "', '" + textBoxCPF.Text + "', '" + textBoxCELULAR.Text + "', '" + textBoxENDERECO.Text + "');";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
