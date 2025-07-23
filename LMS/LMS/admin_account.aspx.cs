using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMS
{
    public partial class WebForm13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                result_label.Visible = false;
                fillTextBoxes();
            }
        }

        public void fillTextBoxes()
        {
            var userID = Convert.ToInt32(Session["user_id"]);
            
            DataTable dt = new DataTable();
            User_BAL objBal = new User_BAL();
            dt = objBal.getUserDetailsByID(userID);
            
            if(dt.Rows.Count > 0)
            {
                txt_full_name.Text = dt.Rows[0][1].ToString();
                txt_phone_num.Text = dt.Rows[0][3].ToString();
                txt_age.Text = dt.Rows[0][4].ToString();
                txt_email.Text = dt.Rows[0][5].ToString();
                txt_old_password.Text = dt.Rows[0][6].ToString();
                Session["old_password"] = txt_old_password.Text;
            }
        }

        public void clearTextBoxes()
        {
            txt_full_name.Text = "";
            txt_phone_num.Text = "";
            txt_age.Text = "";
            txt_email.Text = "";
            txt_old_password.Text = "";
            txt_new_password.Text = "";
            txt_confirm_passsword.Text = "";
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            result_label.Visible = true;
            result_label.ForeColor = System.Drawing.Color.Red;

            // Trim and capture inputs
            var fullName = txt_full_name.Text.Trim();
            var phoneNum = txt_phone_num.Text.Trim();
            var ageText = txt_age.Text.Trim();
            var email = txt_email.Text.Trim();
            var password = txt_new_password.Text.Trim();
            var confirmPassword = txt_confirm_passsword.Text.Trim();
            var userID = Convert.ToInt32(Session["user_id"]);

            // Validate required fields
            if (string.IsNullOrEmpty(fullName) ||
                string.IsNullOrEmpty(phoneNum) ||
                string.IsNullOrEmpty(ageText) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPassword))
            {
                result_label.Text = "Please fill in all required fields.";
                return;
            }

            // Validate age
            if (!int.TryParse(ageText, out int age))
            {
                result_label.Text = "Please enter a valid numeric age.";
                return;
            }

            // Password match check
            if (password != confirmPassword)
            {
                result_label.Text = "New password and confirm password do not match.";
                return;
            }

            User_Data_schema objSchema = new User_Data_schema();
            objSchema.UserId = userID;
            objSchema.FullName = fullName;
            objSchema.PhoneNumber = phoneNum;
            objSchema.Age = Convert.ToInt32(age);
            if (password != null)
            {
                objSchema.Password = password;
            }
            objSchema.Email = email;

            User_BAL objBal = new User_BAL();
            int sqlStatus = objBal.UpdateChanges(objSchema);

            result_label.Visible = true;
            if (sqlStatus == 0)
            {
                result_label.Text = "Updating changes Failed.";
            }
            else
            {
                result_label.ForeColor = System.Drawing.Color.Green;
                result_label.Text = "Successfully updated changes.";
            }
            clearTextBoxes();
        }
    }
}