using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;


namespace LMS
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                result_label.Visible = false;
            }
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            result_label.Visible = true;
            result_label.ForeColor = System.Drawing.Color.Red;

            var email = txt_login_email.Text;
            var password = txt_login_password.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                result_label.Text = "Please enter both email and password.";
                return;
            }

            // Email format validation
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                result_label.Text = "Please enter a valid email address.";
                return;
            }

            User_Data_schema objSchema = new User_Data_schema();
            objSchema.Email = email;
            objSchema.Password = password;

            User_BAL objBal = new User_BAL();
            DataTable dt = new DataTable();
            dt = objBal.loginUser(objSchema);

            if (dt.Rows.Count > 0)
            {
                var accountType = dt.Rows[0][2].ToString();
                Session["user_id"] = dt.Rows[0][0];
                if(accountType == "admin")
                {
                    Response.Redirect("Admin_home.aspx");
                }
                else
                {
                    Response.Redirect("User_home.aspx");
                }
            }
            else
            {
                result_label.Text = "Please contact admin.";
            }


        }

        protected void btn_forgot_password_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_forgot_password.aspx");
        }

        protected void btn_create_an_account_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_register_account.aspx");
        }
    }
}