using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMS
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                populateRequestRepeater();
            }
        }

        public void populateRequestRepeater()
        {
            User_BAL objBal = new User_BAL();
            DataTable dt = new DataTable();
            dt = objBal.getAllRequests();

            if (dt.Rows.Count > 0)
            {
                rptUserRequests.DataSource = dt;
                rptUserRequests.DataBind();
            }
        }

        protected void btnActivate_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int userID = Convert.ToInt32(btn.CommandArgument);

            User_BAL objBal = new User_BAL();
            int result = objBal.activateAccount(userID);

            populateRequestRepeater();
        }

        protected void btnReject_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int userID = Convert.ToInt32(btn.CommandArgument);

            User_BAL objBal = new User_BAL();
            int result = objBal.rejectAccount(userID);

            populateRequestRepeater();
        }
    }
}