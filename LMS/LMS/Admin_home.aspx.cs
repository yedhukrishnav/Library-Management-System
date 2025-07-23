using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMS
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=YEDHUKRISHNA\\SQLEXPRESS; Initial Catalog=Library_Management_System; Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDashboardData();
            }
        }

        private void LoadDashboardData()
        {
            conn.Open();

            // Total Users
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM user_details_table", conn))
            {
                lblTotalUsers.Text = cmd.ExecuteScalar().ToString();
            }

            // Total Books
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM books_table", conn))
            {
                lblTotalBooks.Text = cmd.ExecuteScalar().ToString();
            }

            // Issued Books
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM transaction_table WHERE trans_status = 'issued'", conn))
            {
                lblIssuedBooks.Text = cmd.ExecuteScalar().ToString();
            }

            // Overdue Books
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM transaction_table WHERE DOR < GETDATE() AND trans_status = 'issued'", conn))
            {
                lblOverdue.Text = cmd.ExecuteScalar().ToString();
            }

        }
    }
}