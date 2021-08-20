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

namespace AulaWinForms03Manha
{
    public partial class Exec02 : Form
    {
        public Exec02()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Environment.Exit(1);
        }

        private void Exec02_Load(object sender, EventArgs e)
        {
            dgProduto.Columns.Add("FornecedorCol", "Fornecedor");
            dgProduto.Columns["FornecedorCol"].Width = 200;
            AtualizaDG();
        }

        private void AtualizaDG()
        {
            dgProduto.Rows.Clear();// limpa as linhas do DataGrid
            string select = "SELECT * from dbo.Produto";
            SqlCommand cmd = new SqlCommand(select, DBFunction.Connection);
            DBFunction.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string[] vetor = {dr[0].ToString(),dr[1].ToString(),dr[2].ToString(),dr[3].ToString() };
                dgProduto.Rows.Add(vetor);
            }
            dr.Close();
            DBFunction.Connection.Close();
        }

        private void btnExecuta_Click(object sender, EventArgs e)
        {
            if(checkAdd.Checked)
            {
                string insert = $"INSERT into dbo.Produto (Nome,Preco,Fornecedor) values ('{txtNome.Text}',{txtPreco.Text},'{txtFornecedor.Text}')";
                DBFunction.Executa(insert);
                AtualizaDG();
            }
            else if (checkRemove.Checked)
            {
                string remove = $"DELETE from dbo.Produto WHERE idProduto = {txtNome.Text}";
                DBFunction.Executa(remove);
                AtualizaDG();
            }
            else
            {
                MessageBox.Show("Por favor, marque o que desejas fazer");
            }
            txtNome.Clear();
            txtPreco.Clear();
            txtFornecedor.Clear();
        }

        private void checkAdd_CheckedChanged(object sender, EventArgs e)
        {
            if(checkAdd.Checked)
            {
                checkRemove.Checked = false;
                lblNome.Text = "Nome";
                txtPreco.Visible = true;
                txtFornecedor.Visible = true;
                lblPreco.Visible = true;
                lblFornecedor.Visible = true;
            }
        }
        private void checkRemove_CheckedChanged(object sender, EventArgs e)
        {
            if(checkRemove.Checked)
            {
                checkAdd.Checked = false;
                lblNome.Text = "ID";
                txtPreco.Visible = false;
                txtFornecedor.Visible = false;
                lblPreco.Visible = false;
                lblFornecedor.Visible = false;
            }
        }
    }
}
