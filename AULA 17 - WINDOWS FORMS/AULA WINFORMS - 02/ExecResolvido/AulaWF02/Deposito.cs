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

namespace AulaWF02
{
    public partial class Deposito : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CTGVMBU\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");

        public Deposito()
        {
            InitializeComponent();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            string update = $"UPDATE dbo.Conta Set Saldo = Saldo + {txtQuantidade.Text} WHERE NumeroConta = {txtConta.Text}";
            SqlCommand cmd = new SqlCommand(update, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            txtConta.Clear();
            txtQuantidade.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Exec02 f = new Exec02();
            this.FindForm().Hide();
            f.Show();
        }
    }
}
