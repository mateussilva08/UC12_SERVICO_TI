using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC12_SERVICO_TI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form telaCLIENTES = new CLIENTES();

            // telaCADASTRO.MdiParent = this;
            telaCLIENTES.Show();
            //  telaCLIENTES.WindowState = FormWindowState.Maximized;
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form telaSERVICO = new FormSERVICO();

            // telaCADASTRO.MdiParent = this;
            telaSERVICO.Show();
            //  telaCLIENTES.WindowState = FormWindowState.Maximized;
        }
    }
}
