using System;
using System.Collections.Generic;
using System.Data;
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
            string query = @"
                            SELECT * 
                            FROM books_table 
                            INNER JOIN transaction_table ON books_table.book_id = transaction_table.trans_bookID 
                            WHERE trans_userID = @userID 
                            AND TRY_CONVERT(datetime, DOR, 105) < CAST(GETDATE() AS DATE)";


            StringBuilder sb = new StringBuilder();
            DateTime today = DateTime.Today;

            DataTable dt = new DataTable();

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@userID", userID);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }

            foreach (DataRow row in dt.Rows)
            {
                string dorStr = row["DOR"].ToString();
                int fineInDb = row["trans_fine"] != DBNull.Value ? Convert.ToInt32(row["trans_fine"]) : 0;
                int transactionId = Convert.ToInt32(row["transId"]);

                int calculatedFine = 0;

                if (DateTime.TryParseExact(dorStr, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dorDate))
                {
                    if (dorDate < today)
                    {
                        int overdueDays = (today - dorDate).Days;
                        calculatedFine = overdueDays * 5;
                    }

                    if (calculatedFine != fineInDb)
                    {
                        UpdateFine(transactionId, calculatedFine);
                        fineInDb = calculatedFine;
                    }
                }

                sb.Append("<tr>");
                sb.AppendFormat("<td>{0}</td>", row["b_title"]);
                sb.AppendFormat("<td>{0}</td>", row["b_author"]);
                sb.AppendFormat("<td>{0}</td>", row["trans_status"]);
                sb.AppendFormat("<td>{0}</td>", row["DOB"]);
                sb.AppendFormat("<td>{0}</td>", row["DOR"]);
                sb.AppendFormat("<td>{0}</td>", fineInDb);
                sb.Append("</tr>");
            }

            ltTableRows.Text = sb.ToString();
        }

        public void UpdateFine(int transactionId, int fine)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE transaction_table SET trans_fine = @fine WHERE transId = @transactionId", conn))
            {
                cmd.Parameters.AddWithValue("@fine", fine);
                cmd.Parameters.AddWithValue("@transactionId", transactionId);

                if (conn.State != ConnectionState.Open)
                    conn.Open();

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

    }
}