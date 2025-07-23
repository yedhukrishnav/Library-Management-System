using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMS
{
    public partial class WebForm23 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                result_label.Visible = false;
            }
        }

        protected void btn_AddBook_Click(object sender, EventArgs e)
        {
            result_label.Visible = true;
            result_label.ForeColor = System.Drawing.Color.Red;

            // Trim input values
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

            // Validate quantity is a number
            if (!int.TryParse(quantityText, out int quantity) || quantity < 0)
            {
                result_label.Text = "Please enter a valid non-negative number for quantity.";
                return;
            }

            // Populate schema
            book_data_schema objSchema = new book_data_schema();
            objSchema.bookTitle = title;
            objSchema.bookAuthor = author;
            objSchema.BookPublisher = publisher;
            objSchema.BookQuantity = quantity;

            // Add book
            book_BAL objBal = new book_BAL();
            int result = objBal.addNewBook(objSchema);

            if (result == 0)
            {
                result_label.Text = "Failed to add new Book.";
            }
            else
            {
                result_label.ForeColor = System.Drawing.Color.Green;
                result_label.Text = "Successfully added new Book.";
            }
        }

    }
}