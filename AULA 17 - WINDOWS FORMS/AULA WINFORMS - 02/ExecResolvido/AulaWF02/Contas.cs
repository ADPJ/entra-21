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
    public partial class Contas : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CTGVMBU\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        public Contas()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Exec02 f = new Exec02();
            this.FindForm().Hide();
            f.Show();
        }

        private void Contas_Load(object sender, EventArgs e)
        {
            string select = $"SELECT * from dbo.Conta";
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string temp = "";
                temp += "Conta: " + dr[1].ToString() + "  ";
                temp += "Saldo: " + dr[2].ToString();
                listContas.Items.Add(temp);
            }
            dr.Close();
            conn.Close();
        }
    }
}
