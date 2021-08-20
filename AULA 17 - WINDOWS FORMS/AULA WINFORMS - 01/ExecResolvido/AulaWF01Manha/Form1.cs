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

namespace AulaWF01Manha
{
    public partial class Form1 : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=BUE205D39;Initial Catalog=BDTurmaManha;User ID=guest01;Password=@Senac2021");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string select = $"SELECT * from dbo.Cadastro WHERE LoginUser = '{txtLogin.Text}'";
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (txtPassword.Text == dr["PasswordKey"].ToString())
                {
                    MessageBox.Show("Login efetuado");
                }
                else
                {
                    MessageBox.Show("Login fracassou");
                }
            }
            dr.Close();
            conn.Close();

        }

        private void lblTeste_MouseEnter(object sender, EventArgs e)
        {
            lblTeste.Text = "Funcionou";
        }
    }
}
