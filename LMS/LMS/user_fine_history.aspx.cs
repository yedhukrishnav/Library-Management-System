using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMS
{
    public partial class WebForm18 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=YEDHUKRISHNA\\SQLEXPRESS; Initial Catalog=Library_Management_System; Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                populateFineHistory();
            }
        }

        public void populateFineHistory()
        {
            int userID = Convert.ToInt32(Session["user_id"]);
            int fine = 0;
            string query = "SELECT * from books_table inner join transaction_table on books_table.book_id = transaction_table.trans_bookID where trans_userID = " + userID + " and not trans_fine= "+ fine+"";

            StringBuilder sb = new StringBuilder();

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sb.Append("<tr>");
                    sb.AppendFormat("<td>{0}</td>", reader["b_title"]);
                    sb.AppendFormat("<td>{0}</td>", reader["b_author"]);
                    sb.AppendFormat("<td>{0}</td>", reader["trans_status"]);
                    sb.AppendFormat("<td>{0}</td>", reader["DOB"]);
                    sb.AppendFormat("<td>{0}</td>", reader["DOR"]);
                    sb.AppendFormat("<td>{0}</td>", reader["trans_fine"]);
                    sb.Append("</tr>");
                }
                conn.Close();
            }

            ltTableRows.Text = sb.ToString();
        }
    }
}