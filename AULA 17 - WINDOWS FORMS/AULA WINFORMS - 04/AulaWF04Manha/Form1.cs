using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AulaWF04Manha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInicia_Click(object sender, EventArgs e)
        {
            if(rbExec01.Checked)
            {
                new Exec01().Show();
                this.Hide();
            }
            else if (rbExec02.Checked)
            {
                // carrega Exec02
                MessageBox.Show("Under Construction...");
            }
        }
    }
}
