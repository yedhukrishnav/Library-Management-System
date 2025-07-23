using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMS
{
    public partial class WebForm22 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                result_label.Visible = false;
                fillBookDetails();
            }
        }

        public void fillBookDetails()
        {
            int bookID = Convert.ToInt32(Session["book_id"]);

            book_BAL objBal = new book_BAL();
            DataTable dt = new DataTable();
            dt = objBal.getBookDetailsByID(bookID);

            if(dt.Rows.Count > 0)
            {
                txt_Book_Title.Text = dt.Rows[0][1].ToString();
                txt_Book_Author.Text = dt.Rows[0][2].ToString();
                txt_Book_Publisher.Text = dt.Rows[0][3].ToString();
                txt_Book_Quantity.Text = dt.Rows[0][4].ToString();
            }
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            result_label.Visible = true;
            result_label.ForeColor = System.Drawing.Color.Red;

            // Get book ID from session
            if (Session["book_id"] == null)
            {
                result_label.Text = "Book ID not found in session.";
                return;
            }

            if (!int.TryParse(Session["book_id"].ToString(), out int bookID))
            {
                result_label.Text = "Invalid Book ID.";
                return;
            }

            // Trim inputs
            var title = txt_Book_Title.Text.Trim();
            var author = txt_Book_Author.Text.Trim();
            var publisher = txt_Book_Publisher.Text.Trim();
            var quantityText = txt_Book_Quantity.Text.Trim();

            // Validate required fields
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) ||
                string.IsNullOrEmpty(publisher) || string.IsNullOrEmpty(quantityText))
            {
                result_label.Text = "Please fill in all the fields.";
                return;
            }

            // Validate quantity
            if (!int.TryParse(quantityText, out int quantity) || quantity < 0)
            {
                result_label.Text = "Please enter a valid non-negative number for quantity.";
                return;
            }

            book_data_schema objSchema = new book_data_schema();
            objSchema.bookID = bookID;
            objSchema.bookTitle = title;
            objSchema.bookAuthor = author;
            objSchema.BookPublisher = publisher;
            objSchema.BookQuantity = quantity;

            book_BAL objBal = new book_BAL();
            int result = objBal.updateBookDetails(objSchema);

            result_label.Visible = true;
            if (result == 0)
            {
                result_label.Text = "Failed to update Details.";
            }
            else
            {
                result_label.ForeColor = System.Drawing.Color.Green;
                result_label.Text = "Successfully updated Book Details.";
            }
        }
    }
}