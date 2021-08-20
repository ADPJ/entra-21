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

namespace ExecBDWFManha
{
    public partial class Form1 : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=BUE205D39;Initial Catalog=BDTurmaManha;User ID=guest01;Password=@Senac2021");
        private SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // pode-se fazer uma checagem se algum txtbox esta vazio
            string insert = $"INSERT into dbo.Produto (Nome,Preco,QtdEstoque) values ('{txtNome.Text}',{txtPreco.Text},{txtQuantidade.Text})";
            cmd = new SqlCommand(insert, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            txtNome.Clear();
            txtPreco.Text = "";
            txtQuantidade.Clear();
        }

        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            lblBD.Text = "";
            string select = "SELECT * from dbo.Produto";
            cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                for (int i = 0; i < 4; i++)
                {
                    lblBD.Text += dr[i].ToString() + "  ";
                }
                lblBD.Text += "\n";
            }

            dr.Close();
            conn.Close();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string delete = $"DELETE from dbo.Produto WHERE Nome = '{txtNome.Text}'";
            cmd = new SqlCommand(delete, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            txtNome.Clear();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string update = "";
            int conversao = 0;
            if (int.TryParse(txtAlterar.Text, out conversao))
            {
                update = $"UPDATE dbo.Produto Set Nome = '{txtNome.Text}',Preco = {txtPreco.Text},QtdEstoque = {txtQuantidade.Text} WHERE idProduto = {conversao}";
            }
            else
            {
                update = $"UPDATE dbo.Produto Set Nome = '{txtNome.Text}',Preco = {txtPreco.Text},QtdEstoque = {txtQuantidade.Text} WHERE Nome = '{txtAlterar.Text}'";
            }

            cmd = new SqlCommand(update, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            txtNome.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
            txtAlterar.Text = "Qual produto?";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            string update = $"UPDATE dbo.Produto SET QtdEstoque -= 1 WHERE Nome = '{txtNome.Text}'";
            cmd = new SqlCommand(update, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            txtNome.Clear();

        }
    }
}
