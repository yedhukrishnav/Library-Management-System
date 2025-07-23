using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMS
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                populateUserRepeater();
            }
        }

        public void populateUserRepeater()
        {
            User_BAL objBal = new User_BAL();
            DataTable dt = new DataTable();
            dt = objBal.getAllUserList();

            if(dt.Rows.Count > 0)
            {
                rptFeedback.DataSource = dt;
                rptFeedback.DataBind();
            }
        }

  

        protected void btnSuspend_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int userID = Convert.ToInt32(btn.CommandArgument);
            User_BAL objBal = new User_BAL();
            int result = objBal.suspendAccount(userID);

            populateUserRepeater();
        }

        protected void btnActivate_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int userID = Convert.ToInt32(btn.CommandArgument);
            User_BAL objBal = new User_BAL();
            int result = objBal.activateAccount(userID);

            populateUserRepeater();
        }
    }
}