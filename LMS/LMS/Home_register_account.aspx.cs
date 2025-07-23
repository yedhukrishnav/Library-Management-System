using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMS
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                result_label.Visible = false;
            }
        }

        protected void btn_register_Click(object sender, EventArgs e)
        {

            // Check if any required field is empty
            if (string.IsNullOrWhiteSpace(txt_full_name.Text) ||
                string.IsNullOrWhiteSpace(txt_phone_num.Text) ||
                string.IsNullOrWhiteSpace(txt_age.Text) ||
                string.IsNullOrWhiteSpace(txt_email.Text) ||
                string.IsNullOrWhiteSpace(txt_password.Text) ||
                string.IsNullOrWhiteSpace(txt_confirm_passsword.Text))
            {
                result_label.Text = "All fields are required.";
                result_label.ForeColor = System.Drawing.Color.Red;
                result_label.Visible = true;
                return;
            }

            // Passwords match validation
            if (txt_password.Text != txt_confirm_passsword.Text)
            {
                result_label.Text = "Passwords do not match.";
                result_label.ForeColor = System.Drawing.Color.Red;
                result_label.Visible = true;
                return;
            }

            // Age validation
            if (!int.TryParse(txt_age.Text, out int age))
            {
                result_label.Text = "Age must be a valid number.";
                result_label.ForeColor = System.Drawing.Color.Red;
                result_label.Visible = true;
                return;
            }


            var fullName = txt_full_name.Text;
            var accountType = "student";
            var phoneNumber = txt_phone_num.Text;
            age = Convert.ToInt32(txt_age.Text);
            var email = txt_email.Text;
            var password = txt_password.Text;
            var accountStatus = "pending";


            User_Data_schema objSchema = new User_Data_schema();
            objSchema.FullName = fullName;
            objSchema.AccountType = accountType;
            objSchema.PhoneNumber = phoneNumber;
            objSchema.Age = age;
            objSchema.Password = password;
            objSchema.Email = email;
            objSchema.AccountStatus = accountStatus;

            User_BAL objBal = new User_BAL();
            int sqlStatus = objBal.registerAccount(objSchema);

            result_label.Visible = true;
            if (sqlStatus == 0)
            {
                result_label.Text = "Registration Failed1";
            }
            else
            {
                result_label.Text = "Successfully Registered.";
            }
            clearTextBoxes();
        }

        public void clearTextBoxes()
        {
            txt_full_name.Text = "";
            txt_age.Text = "";
            txt_email.Text = "";
            txt_phone_num.Text = "";
            txt_password.Text = "";
            txt_confirm_passsword.Text = "";
        }
        protected void btn_forgot_password_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_forgot_password.aspx");
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_login.aspx");
        }
    }
}