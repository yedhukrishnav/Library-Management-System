using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMS
{
    public partial class WebForm6 : System.Web.UI.Page
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


        // Page size
        private int PageSize = 100;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
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

            rptAllBooks.DataSource = pds;
            rptAllBooks.DataBind();
        }

        public DataTable GetAllBooks()
        {
            book_BAL objBal = new book_BAL();
            DataTable dt = new DataTable();
            dt = objBal.GetAllBooksList();

            return dt;

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

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int bookID = Convert.ToInt32(btn.CommandArgument);

            Session["book_id"] = bookID;

            Response.Redirect("admin_edit_book_details.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int bookID = Convert.ToInt32(btn.CommandArgument);

            book_BAL objBal = new book_BAL();
            int result = objBal.deleteBook(bookID);
        }

        protected void btn_addBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin_Add_book.aspx");
        }

    }
}