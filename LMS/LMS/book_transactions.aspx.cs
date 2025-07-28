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
    public partial class WebForm11 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=YEDHUKRISHNA\\SQLEXPRESS; Initial Catalog=Library_Management_System; Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                populateAllTransactionsTable();
            }
        }

        public void populateAllTransactionsTable()
        {
            transaction_BAL objBal = new transaction_BAL();
            DataTable dt = new DataTable();
            dt = objBal.getAllTransactions();

            DateTime today = DateTime.Today;

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (DateTime.TryParse(row["DOR"]?.ToString(), out DateTime returnDate))
                    {
                        int calculatedFine = (returnDate < today) ? (today - returnDate).Days * 5 : 0;
                        int existingFine = row["trans_fine"] != DBNull.Value ? Convert.ToInt32(row["trans_fine"]) : 0;

                        if (calculatedFine != existingFine)
                            objBal.UpdateFine(Convert.ToInt32(row["transId"]), calculatedFine);

                        row["trans_fine"] = calculatedFine;
                    }
                }

                rptAllTransactions.DataSource = dt;
                rptAllTransactions.DataBind();
            }
        }

        protected void btnCloseTransaction_Click(object sender, EventArgs e)
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

            if (result == 1)
            {
                clickedButton.Enabled = false;
                clickedButton.ForeColor = System.Drawing.Color.Gray;
            }

            populateAllTransactionsTable();
        }
    }
}