using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMS
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=YEDHUKRISHNA\\SQLEXPRESS; Initial Catalog=Library_Management_System; Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                reply_label.Visible = false;
                PopulateRepeater();


            }
        }

        protected void btnReply_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int fedId = Convert.ToInt32(btn.CommandArgument);
            hfFedId.Value = fedId.ToString(); 
            string query = "SELECT feedback_content FROM feedback_table WHERE fed_Id = @fedId";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@fedId", fedId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txt_Content.Text = reader["feedback_content"].ToString();
                }
                conn.Close();
            }
        }


        private void PopulateRepeater()
        {
            string query = "SELECT * FROM user_details_table INNER JOIN feedback_table ON user_details_table.userId = feedback_table.fed_userID";

            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }

            rptFeedback.DataSource = dt;
            rptFeedback.DataBind();
        }


        protected void btn_reply_Click(object sender, EventArgs e)
        {
            int fed_ID = Convert.ToInt32(hfFedId.Value);
            int admin_ID = Convert.ToInt32(Session["user_id"]);
            var response = txt_reply.Text;
            SqlCommand cmd = new SqlCommand("update feedback_table set feedback_response= '" + response + "', fed_adminID= " + admin_ID + " where fed_Id = " + fed_ID + "", conn);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            reply_label.Visible = true;
            if (result == 0)
            {
                reply_label.Text = "Failed to send response.";
            }
            else
            {
                reply_label.Text = "Responded.";
            }
            PopulateRepeater();
            clearTextBoxes();
        }

        public void clearTextBoxes()
        {
            txt_Content.Text = "";
            txt_reply.Text = "";
        }


    }
}