using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGerencial
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        [DllImport("DwmApi")]

        private static extern int DwmSetWindowAttribute(IntPtr hwn, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
            {
                DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
            }
        }

        private void stripArquivosSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
        }

        private void stripArquivosClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            estoque.Show();
        }

        private void stripArquivosEstoque_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            estoque.Show();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            Fornecedores fornecedores = new Fornecedores();
            fornecedores.Show();
        }

        private void stripArquivosFornecedores_Click(object sender, EventArgs e)
        {
            Fornecedores fornecedores = new Fornecedores();
            fornecedores.Show();
        }
    }
}
