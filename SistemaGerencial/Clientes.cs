using FirebirdSql.Data.FirebirdClient;
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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            gridDataClientes();
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

        string bdConnection = $"DataSource=localhost;Database=C:\\Users\\ramon\\source\\repos\\SistemaGerencial\\SistemaGerencial\\bin\\Debug\\BASEDADOS.FDB;Port=3050;User=SYSDBA;Password=masterkey;Charset=UTF8;Dialect=3;Connection lifetime=15;PacketSize=8192;ServerType=0;Unicode=True;Max Pool Size=1000";
        public FbConnection con;

        public void gridDataClientes()
        {
            con = new FbConnection(bdConnection);
            FbCommand comando = new FbCommand("SELECT * FROM CLIENTES", con);
            FbDataAdapter data = new FbDataAdapter(comando);
            DataSet dataset = new DataSet();
            con.Open();
            data.Fill(dataset, "CLIENTES");
            dataGridClientes.DataSource = dataset;
            dataGridClientes.DataMember = "CLIENTES";
            con.Close();
        }
    }
}
