using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaWF04Manha
{
    public static class DBFunction
    {
        public static SqlConnection Connection { get; set; } = new SqlConnection(@"Data Source=DESKTOP-CTGVMBU\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");

        /// <summary>
        /// This function returns all elements selected in the table, the table already include dbo.
        /// </summary>
        /// <param name="table"></param>
        /// <param name="element"></param>
        /// <returns>List(string) allSelectElements</returns>
        public static List<string> GenericUnitSelect(string element,string table)
        {
            List<string> returnElements = new List<string>();

            string select = $"SELECT {element} from dbo.{table}";
            SqlCommand cmd = new SqlCommand(select, Connection);
            Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                returnElements.Add(dr[0].ToString());
            }
            dr.Close();
            Connection.Close();

            return returnElements;
        }

    }
}
