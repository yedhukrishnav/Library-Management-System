using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMS
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                loadBookRequestsRepeater();
            }
        }

        public void loadBookRequestsRepeater()
        {
            transaction_BAL objBAL = new transaction_BAL();
            DataTable dt = new DataTable();
            dt = objBAL.GetAllBooksRequests();

            rptBookRequests.DataSource = dt;
            rptBookRequests.DataBind();
        }

        protected void btnApprove_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int Trans_ID = Convert.ToInt32(btn.CommandArgument);
            RepeaterItem item = (RepeaterItem)btn.NamingContainer;
            HiddenField hf = (HiddenField)item.FindControl("hfBookId");
            int bookId = Convert.ToInt32(hf.Value);

            var borrowDate = DateTime.Now.ToString("dd-MM-yyyy");
            var getReturnDate = DateTime.Now.AddDays(14);
            var returnDate = getReturnDate.ToString("dd-MM-yyyy");
            var status = "issued";

            transaction_data_schema objSchema = new transaction_data_schema();
            objSchema.trans_id = Trans_ID;
            objSchema.trans_DOB = borrowDate;
            objSchema.trans_DOR = returnDate;
            objSchema.trans_status = status;


            transaction_BAL objBal = new transaction_BAL();
            int approveRequestResult = objBal.approveRequest(objSchema);

            book_data_schema objBookSchema = new book_data_schema();
            objBookSchema.bookID = bookId;
            book_BAL objBookBal = new book_BAL();
            int countUpdateResult = objBookBal.updateBookCountOnApproval(objBookSchema);

            loadBookRequestsRepeater();
        }

        protected void btnReject_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int Trans_ID = Convert.ToInt32(btn.CommandArgument);

            var status = "rejected";

            transaction_data_schema objSchema = new transaction_data_schema();
            objSchema.trans_id = Trans_ID;
            objSchema.trans_status = status;


            transaction_BAL objBal = new transaction_BAL();
            int result = objBal.rejectRequest(objSchema);

            loadBookRequestsRepeater();
        }
    }
}