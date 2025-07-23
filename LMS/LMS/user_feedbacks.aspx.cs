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
    public partial class WebForm19 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=YEDHUKRISHNA\\SQLEXPRESS; Initial Catalog=Library_Management_System; Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                result_label.Visible = false;
                populateFeedbackGrid();
            }
        }

        public void populateFeedbackGrid()
        {
            int userID = Convert.ToInt32(Session["user_id"]);
            string query = "SELECT * from user_details_table inner join feedback_table on user_details_table.userId = feedback_table.fed_adminID where feedback_table.fed_userId= "+ userID + "";

            StringBuilder sb = new StringBuilder();

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sb.Append("<tr>");
                    sb.AppendFormat("<td>{0}</td>", reader["u_FullName"]);
                    sb.AppendFormat("<td>{0}</td>", reader["feedback_content"]);
                    sb.AppendFormat("<td>{0}</td>", reader["feedback_response"]);
                    sb.Append("</tr>");
                }
                conn.Close();
            }

            ltTableRows.Text = sb.ToString();
        }
        
        protected void btn_save_response_Click(object sender, EventArgs e)
        {
            var response = txt_feedback.Text;
            int user_ID = Convert.ToInt32(Session["user_id"]);
            int adminID = 0;
            var reply = "pending.";
            SqlCommand cmd = new SqlCommand("INSERT INTO feedback_table values (" + adminID + ", " + user_ID + ", '"+ response + "', '" + reply + "')", conn);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            result_label.Visible = true;
            if (result == 0)
            {
                result_label.Text = "Failed to send feedback.";
            }
            else
            {
                result_label.Text = "feedback sent.";
            }
            populateFeedbackGrid();
        }
    }
}