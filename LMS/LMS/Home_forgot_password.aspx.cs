using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMS
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                result_label.Visible = false;
            }
        }

        protected void btn_reset_password_Click(object sender, EventArgs e)
        {
            var passwordResetEmail = txt_forgot_email.Text;
            result_label.Visible = true;
            result_label.Text = "We will contact you soon.";
        }

        protected void btn_register_account_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_register_account.aspx");
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_login.aspx");
        }
    }
}