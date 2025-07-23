using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMS
{
    public partial class WebForm14 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=YEDHUKRISHNA\\SQLEXPRESS; Initial Catalog=Library_Management_System; Integrated Security=True");

        private int CurrentPage
        {
            get
            {
                if (ViewState["CurrentPage"] == null)
                    ViewState["CurrentPage"] = 0;
                return (int)ViewState["CurrentPage"];
            }
            set
            {
                ViewState["CurrentPage"] = value;
            }
        }

        // Page size
        private int PageSize = 100;

        private string SearchText
        {
            get
            {
                return ViewState["SearchText"] != null ? ViewState["SearchText"].ToString() : string.Empty;
            }
            set
            {
                ViewState["SearchText"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindRepeater();
            }
        }

        private void BindRepeater()
        {
            DataTable dt;
            if (!string.IsNullOrEmpty(SearchText))
            {
                dt = GetBooks(SearchText); // Filtered results
            }
            else
            {
                dt = GetAllBooks(); // All results
            }
            System.Web.UI.WebControls.PagedDataSource pds = new System.Web.UI.WebControls.PagedDataSource();
            pds.DataSource = dt.DefaultView;
            pds.AllowPaging = true;
            pds.PageSize = PageSize;
            pds.CurrentPageIndex = CurrentPage;

            btnPrevious.Enabled = !pds.IsFirstPage;
            btnNext.Enabled = !pds.IsLastPage;

            // Show page info
            lblPageInfo.Text = $"Page {CurrentPage + 1} of {pds.PageCount}";

            rptViewAllBooks.DataSource = pds;
            rptViewAllBooks.DataBind();
        }

        private DataTable GetBooks(string search)
        {
            string query = @"
                SELECT * FROM books_table
                WHERE b_title LIKE @search OR b_author LIKE @search
                ORDER BY book_id DESC"
            ;
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@search", "%" + search + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable GetAllBooks()
        {
            book_BAL objBal = new book_BAL();
            DataTable dt = new DataTable();
            dt = objBal.GetAllBooksList();

            return dt;
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SearchText = txtSearch.Text.Trim();
            CurrentPage = 0;
            BindRepeater();
        }

        protected void btnClearSearch_Click(object sender, EventArgs e)
        {
            SearchText = "";
            txtSearch.Text = "";
            CurrentPage = 0;
            BindRepeater();
        }

        protected void btnPrevious_Click(object sender, EventArgs e)
        {
            CurrentPage -= 1;
            BindRepeater();
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            CurrentPage += 1;
            BindRepeater();
        }

        protected void btnReserve_Click(object sender, EventArgs e)
        {
            LinkButton clickedButton = (LinkButton)sender;
            RepeaterItem item = (RepeaterItem)clickedButton.NamingContainer;

            LinkButton btn = (LinkButton)sender;
            int book_id = Convert.ToInt32(btn.CommandArgument);
            int user_ID = Convert.ToInt32(Session["user_id"]);
            var borrowDate = DateTime.Now.ToString("dd-MM-yyyy");
            var getReturnDate = DateTime.Now.AddDays(14);
            var returnDate = getReturnDate.ToString("dd-MM-yyyy");
            int fine = 0;
            var status = "requested";

            transaction_data_schema objSchema = new transaction_data_schema();
            objSchema.trans_userID = user_ID;
            objSchema.trans_bookID = book_id;
            objSchema.trans_DOB = borrowDate;
            objSchema.trans_DOR = returnDate;
            objSchema.trans_fine = fine;
            objSchema.trans_status = status;

            transaction_BAL objBal = new transaction_BAL();
            int result = objBal.requestBook(objSchema);

            if (result == 1)
            {
                clickedButton.Enabled = false;
                clickedButton.ForeColor = System.Drawing.Color.Gray;
            }
        }

    }
}