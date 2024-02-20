using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace SistemaGerencial
{
    public partial class Fornecedores : Form
    {
        string connectionString = $"DataSource=localhost;Database=C:\\SGBR\\MASTER\\BD\\BASESGMASTER.FDB;Port=3050;User=SYSDBA;Password=masterkey;Charset=UTF8;Dialect=3;Connection lifetime=15;PacketSize=8192;ServerType=0;Unicode=True;Max Pool Size=1000";

        public Fornecedores()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                using (FbConnection connection = new FbConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Conexão realizada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }
    }
}
