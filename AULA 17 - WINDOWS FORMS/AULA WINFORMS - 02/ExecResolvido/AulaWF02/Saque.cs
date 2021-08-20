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
    public partial class Saque : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CTGVMBU\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");

        public Saque()
        {
            InitializeComponent();
        }



        private void Saque_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Exec02 f = new Exec02();
            this.FindForm().Hide();
            f.Show();
        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            int valor = ConfereSaldo();
            if (valor != -1)
            {
                MessageBox.Show("Saldo: " + valor.ToString());
            }

            //if (ConfereSaldo() != 0)
            //{
            //    MessageBox.Show(ConfereSaldo().ToString());
            //}
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            int valor = ConfereSaldo();
            if (valor != -1)
            {
                if (valor < Convert.ToInt32(txtQuantidade.Text))
                {
                    MessageBox.Show("Desculpe, saldo insuficiente");
                }
                else
                {
                    string update = $"UPDATE dbo.Conta Set Saldo = Saldo - {txtQuantidade.Text} WHERE NumeroConta = {txtConta.Text}";
                    SqlCommand cmd = new SqlCommand(update, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Saque efetuado");
                }
            }
            txtConta.Clear();
            txtQuantidade.Clear();
        }

        private int ConfereSaldo()
        {
            int retorno = -1;
            string select = $"SELECT Saldo from dbo.Conta WHERE NumeroConta = '{txtConta.Text}'";
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                retorno = Convert.ToInt32(dr[0]);
            }
            else
            {
                MessageBox.Show("Conta nao encontrada");
            }
            dr.Close();
            conn.Close();
            return retorno;
        }

    }
}
