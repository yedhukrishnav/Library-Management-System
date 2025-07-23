using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMS
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                populateFineTable();
            }
        }

        public void populateFineTable()
        {
            transaction_BAL objBal = new transaction_BAL();
            DataTable dt = new DataTable();
            dt = objBal.getFineDetails();

            if (dt.Rows.Count > 0)
            {
                rptFineTable.DataSource = dt;
                rptFineTable.DataBind();
            }
        }
    }
}