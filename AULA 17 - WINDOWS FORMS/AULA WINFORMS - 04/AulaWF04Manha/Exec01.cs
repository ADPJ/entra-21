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

namespace AulaWF04Manha
{
    public partial class Exec01 : Form
    {
        public Exec01()
        {
            InitializeComponent();
        }

        private void Exec01_Load(object sender, EventArgs e)
        {
            cbNomes.Items.Clear();
            List<string> elements = DBFunction.GenericUnitSelect("Nome", "Pessoa");
            foreach (var item in elements)
            {
                cbNomes.Items.Add(item);
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            dgNome.Rows.Clear();

            string select = $"SELECT * from dbo.Pessoa WHERE Nome = '{cbNomes.Text}'";
            SqlCommand cmd = new SqlCommand(select, DBFunction.Connection);
            DBFunction.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                string[] elements = { dr[0].ToString(), dr[1].ToString(), FormatCPF(dr[2].ToString()), dr[3].ToString() };
                dgNome.Rows.Add(elements);
            }
            dr.Close();
            DBFunction.Connection.Close();

        }
        private string FormatCPF(string Cpf)
        {
            return $@"{Convert.ToInt64(Cpf):000\.000\.000\-00}";
        }

        private void Exec01_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
