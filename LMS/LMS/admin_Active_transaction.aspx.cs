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
    public partial class WebForm21 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                populateActiveTransactionTable();
            }
        }


        public void populateActiveTransactionTable()
        {
            transaction_BAL objBal = new transaction_BAL();
            DataTable dt = new DataTable();
            dt = objBal.getActiveTransactions();

            rptActiveTransaction.DataSource = dt;
            rptActiveTransaction.DataBind();
        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            LinkButton clickedButton = (LinkButton)sender;
            RepeaterItem item = (RepeaterItem)clickedButton.NamingContainer;

            LinkButton btn = (LinkButton)sender;
            int transID = Convert.ToInt32(btn.CommandArgument);
            var status = "closed";

            transaction_data_schema objSchema = new transaction_data_schema();
            objSchema.trans_id = transID;
            objSchema.trans_status = status;

            transaction_BAL objBal = new transaction_BAL();
            int result = objBal.closeTransaction(objSchema);

            populateActiveTransactionTable();

        }
    }
}